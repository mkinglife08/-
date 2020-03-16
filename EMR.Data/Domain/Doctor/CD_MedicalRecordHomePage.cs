
using EMR.Data.CustomAttribute;
using System;

namespace EMR.Data.Models
{
    public partial class CD_MedicalRecordHomePage
    {
        /// <summary>
        /// ��Ժ;������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string AdmissionWayName { get; set; }
        /// <summary>
        /// Ѫ������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string BloodTypeName { get; set; }
        /// <summary>
        /// RH����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string RHName { get; set; }
        /// <summary>
        /// ��Ժ��ʽ����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string LeaveHospitalWayName { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string MedicalRecordMassName { get; set; }
        /// <summary>
        /// ת���������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string PrognosisOfDiseaseName { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CreatorName { get; set; }
        /// <summary>
        /// �޸�������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string UpdaterName { get; set; }
        
    }
}