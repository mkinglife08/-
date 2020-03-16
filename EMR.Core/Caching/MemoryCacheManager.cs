using System;
using System.Linq;
using System.Runtime.Caching;

namespace EMR.Core.Caching
{
    /// <summary>
    /// ������HTTP����֮����л���Ĺ�����
    /// </summary>
    public partial class MemoryCacheManager : ICacheManager
    {
        /// <summary>
        /// Cache object
        /// </summary>
        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }

        /// <summary>
        ///  ��ȡ��ָ����������ֵ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <returns>��ָ����������ֵ</returns>
        public virtual T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        /// <summary>
        /// ��ָ���ļ��Ͷ�����ӵ�������
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <param name="data">ֵ����</param>
        /// <param name="cacheTime_min">����ʱ�䣨���ӣ�</param>
        public virtual void Set<T>(string key, T data, int cacheTime)
        {
            if (data == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            policy.Priority = CacheItemPriority.NotRemovable;
            Cache.Add(new CacheItem(key, data), policy);
            //if (Command != null)
            //{
            //    System.Data.SqlClient.SqlDependency mSqlDependency = new System.Data.SqlClient.SqlDependency(Command);
            //    policy.ChangeMonitors.Add(new SqlChangeMonitor(mSqlDependency));
            //}
            
        }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�Ƿ񻺴���ָ����������ֵ
        /// </summary>
        /// <param name="key">����</param>
        /// <returns></returns>
        public virtual bool IsSet(string key)
        {
            return (Cache.Contains(key));
        }

        /// <summary>
        /// �ӻ�����ɾ������ָ������ֵ
        /// </summary>
        /// <param name="key">����</param>
        public virtual void Remove(string key)
        {
            Cache.Remove(key);
        }

        /// <summary>
        /// ��ƥ��Ĺ�ʽɾ����Ŀ
        /// </summary>
        /// <param name="pattern">ƥ��Ĺ�ʽ</param>
        /// <param name="key">����</param>
        public virtual void RemoveByPattern(string pattern,string key)
        {
            this.RemoveByPattern(pattern, Cache.Select(p => p.Key));
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
            foreach (var item in Cache)
                Remove(item.Key);
        }

        /// <summary>
        /// �ͷŻ����ڴ�
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}