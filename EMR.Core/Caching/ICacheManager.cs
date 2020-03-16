using System;

namespace EMR.Core.Caching
{
    /// <summary>
    /// Cache manager interface
    /// </summary>
    public interface ICacheManager : IDisposable
    {
        /// <summary>
        /// ��ȡ��ָ����������ֵ
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">����</param>
        /// <returns>��ָ����������ֵ.</returns>
        T Get<T>(string key);

        /// <summary>
        /// ��ָ���ļ��Ͷ�����ӵ�������
        /// </summary>
        /// <param name="key">����</param>
        /// <param name="data">ֵ����</param>
        /// <param name="cacheTime_min">����ʱ�䣨���ӣ�</param>
        void Set<T>(string key, T data, int cacheTime_min);

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�Ƿ񻺴���ָ����������ֵ
        /// </summary>
        /// <param name="key">����</param>
        /// <returns></returns>
        bool IsSet(string key);

        /// <summary>
        /// ���ݼ������»����ڵļ�ֵ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">����</param>
        /// <param name="data">ֵ����</param>
        /// <param name="cacheTime_min">����ʱ�䣨���ӣ�</param>
        void Update<T>(string key, T data, int cacheTime_min);

        /// <summary>
        /// �ӻ�����ɾ������ָ������ֵ
        /// </summary>
        /// <param name="key">����</param>
        void Remove(string key);

        /// <summary>
        /// ��ƥ��Ĺ�ʽɾ����Ŀ
        /// </summary>
        /// <param name="pattern">ƥ��Ĺ�ʽ</param>
        void RemoveByPattern(string pattern, string key="");

        /// <summary>
        /// ������л�������
        /// </summary>
        void Clear();
    }
}
