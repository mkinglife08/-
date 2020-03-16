
using EMR.Data.CustomAttribute;
using System;
using System.Collections.Generic;

namespace EMR.Data.Models
{
    public partial class CD_Inpatient
    {
        /// <summary>
        /// �Ƿ��в�����ҳID�������ж��Ƿ��״ε��롣
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string HomePageId { get; set; }

        /// <summary>
        /// ��Ժ��� �������Ϊ 2
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string Diagnosis { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string Report { get; set; }

        /// <summary>
        /// ����ҽʦ
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string VisitingName { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string PaymentTypeName { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string RecordTypeName { get; set; }

        /// <summary>
        /// �ٴ�·������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CpManageName { get; set; }

        /// <summary>
        /// ��ǰ��������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CurrentDeptName { get; set; }

        /// <summary>
        /// ��ǰ��������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CurrentWardName { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public int? AccessState { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public int? ApplyAccessNumber { get; set; }

        /// <summary>
        /// ���һ��ת����Ϣ
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string LastConversionDept { get; set; }
    }
}