
using EMR.Data.CustomAttribute;
using System;

namespace EMR.Data.Models
{
    public partial class CD_PatientDiagnosis
    {   
        public string DiagnosisFlagName { get; set; }
        public string DiagnosisTypeName { get; set; }
        /// <summary>
        /// סԺ��������
        /// </summary>
        public string InpatientName { get; set; }

        /// <summary>
        /// �����û�����ǩ��ͼƬ��ַ
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string RecordUserESign { get; set; }

    }
}