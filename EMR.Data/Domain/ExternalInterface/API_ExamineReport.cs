
using EMR.Data.CustomAttribute;
using System;

namespace EMR.Data.Models
{
    public partial class API_ExamineReport
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public string InpatientId { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public string zxh { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string zmc { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string bgsj { get; set; }

        /// <summary>
        /// �ͼ�ʱ��
        /// </summary>
        public string jysj { get; set; }

        /// <summary>
        /// �걾����
        /// </summary>
        public string bb { get; set; }

        /// <summary>
        /// ����ҽ��
        /// </summary>
        public string sqys { get; set; }

    }

    public partial class ExamineReport_Item
    {
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// ��λ
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// �ο���Χ
        /// </summary>
        public string ReferenceRange { get; set; }
    }

    public partial class API_DataGet_Config
    {
        /// <summary>
        /// ҽԺ���
        /// </summary>
        public string HospitalId { get; set; }

        /// <summary>
        /// HIS���
        /// </summary>
        public string HisCode { get; set; }

        public DataProviderEnum DataProvider { get; set; }

        /// <summary>
        /// �ⲿ���ݿ�������ַ���
        /// </summary>
        public string DBConnectionString { get; set; }

        /// <summary>
        /// sql���
        /// </summary>
        public string Sql { get; set; }
    }

    public enum DataProviderEnum
    {
        sql=1,
        oracle=2
    }

    
}