
using EMR.Data.CustomAttribute;
using System;

namespace EMR.Data.Models
{
    public partial class API_Payment
    {
        /// <summary>
        /// Ԥ�ɿ�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string InpatientId { get; set; }

        /// <summary>
        /// Ԥ�ɿ�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string AdvancePayment { get; set; }


        /// <summary>
        /// ���
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// �ܶ�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string SelfCare { get; set; }

        /// <summary>
        /// �Է�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string SelfPay { get; set; }

        /// <summary>
        /// �ֽ�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string Cash { get; set; }

        /// <summary>
        /// �߿�
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string PressMoney { get; set; }

        /// <summary>
        /// �߿�ʱ��
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public DateTime? PressTime { get; set; }

    }
}