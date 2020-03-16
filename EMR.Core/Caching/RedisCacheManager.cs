using System;
using System.Text;
using Newtonsoft.Json;
using EMR.Core.Configuration;
using ServiceStack.Redis;
using System.Text.RegularExpressions;


namespace EMR.Core.Caching
{
    /// <summary>
    /// ������Redis�洢�л���Ĺ��������������κη�������������
    /// </summary>
    public partial class RedisCacheManager : ICacheManager
    {
        protected static IRedisClient Redis { get; private set; }
        private static string RedisPath = System.Configuration.ConfigurationSettings.AppSettings["RedisPath"];
        private bool _disposed = false;
        private static PooledRedisClientManager _prcm;
        private static ICacheManager _perRequestCacheManager
        {
            get
            {
                //�ж��Ƿ����redis����δ��⵽redis��ʹ��MemoryCache
                ICacheManager _temp = new RedisCacheManager();
                try { Redis.ContainsKey("aa"); }
                catch (Exception err) { _temp = new MemoryCacheManager(); }
                return _temp;
            }
        }

        /// <summary>
        /// ��������ʵ��
        /// </summary>
        /// <returns></returns>
        public static ICacheManager CreateInstance()
        {
            return _perRequestCacheManager;
        }

        public RedisCacheManager() {
            Redis = GetClient();
        }

        public static IRedisClient GetClient()
        {
            if (_prcm == null)
            {
                _prcm = CreateManager(new string[] { RedisPath }, new string[] { RedisPath });
            }
            return _prcm.GetClient();
        }

        private static PooledRedisClientManager CreateManager(string[] readWriteHosts, string[] readOnlyHosts)
        {
            //WriteServerList����д��Redis���ӵ�ַ��
            //ReadServerList���ɶ���Redis���ӵ�ַ��
            //MaxWritePoolSize�����д��������
            //MaxReadPoolSize��������������
            //AutoStart���Զ�������
            //LocalCacheTime�����ػ��浽��ʱ�䣬��λ:�롣
            //RecordeLog���Ƿ��¼��־,�����ý������Ų�redis����ʱ���ֵ�����,��redis��������,��رո��
            //RedisConfigInfo���Ǽ�¼redis������Ϣ������Ϣ�������ļ��е�RedisConfig���Ӧ

            // ֧�ֶ�д���룬���⸺�� 
            return new PooledRedisClientManager(readWriteHosts, readOnlyHosts, new RedisClientManagerConfig
            {
                MaxWritePoolSize = 5, // ��д�����ӳ������� 
                MaxReadPoolSize = 5, // ���������ӳ������� 
                AutoStart = true,
            });
        }

        /// <summary>
        ///  ��ȡ��ָ����������ֵ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <returns>��ָ����������ֵ</returns>
        public virtual T Get<T>(string key)
        {
            try
            {
                return Redis.Get<T>(key);
            }
            catch(Exception err) { throw new Exception(err.Message); }
        }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�Ƿ񻺴���ָ����������ֵ
        /// </summary>
        /// <param name="key">����</param>
        /// <returns></returns>
        public virtual bool IsSet(string key)
        {
            return Redis.ContainsKey(key);
        }

        /// <summary>
        /// �ӻ�����ɾ������ָ������ֵ
        /// </summary>
        /// <param name="key">����</param>
        public virtual void Remove(string key)
        {
            if (IsSet(key))
                Redis.Remove(key);
        }

        /// <summary>
        /// ��ƥ��Ĺ�ʽɾ����Ŀ
        /// </summary>
        /// <param name="pattern">ƥ��Ĺ�ʽ</param>
        /// <param name="key">����</param>
        public virtual void RemoveByPattern(string pattern, string key)
        {
            if (key != "")
            {
                var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Redis.GetAllItemsFromSet(key).RemoveWhere(p => regex.IsMatch(p.ToString()));
            }
        }

        /// <summary>
        /// ��ָ���ļ��Ͷ�����ӵ�������
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <param name="data">ֵ����</param>
        /// <param name="cacheTime_min">����ʱ�䣨���ӣ�</param>
        public virtual void Set<T>(string key, T data, int cacheTime_min)
        {
            if(!IsSet(key))
                Redis.Set(key, data,DateTime.Now.AddMinutes(cacheTime_min));
        }

        /// <summary>
        /// ���ݼ������»����ڵļ�ֵ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <param name="data">ֵ����</param>
        /// <param name="cacheTime_min">����ʱ�䣨���ӣ�</param>
        public virtual void Update<T>(string key, T data, int cacheTime_min)
        {
            if (IsSet(key))
                Remove("key");
            Set(key, data, cacheTime_min);
        }

        /// <summary>
        /// ������л�������
        /// </summary>
        public virtual void Clear()
        {
            foreach (string key in Redis.GetAllKeys())
            {
                Remove(key);
            }
        }

        /// <summary>
        /// �ͷŻ����ڴ�
        /// </summary>
        public virtual void Dispose()
        {
            if (!this._disposed)
            {
                Redis.Dispose();
                Redis = null;
                GC.SuppressFinalize(this);
            }
            this._disposed = true;
        }
    }
}
