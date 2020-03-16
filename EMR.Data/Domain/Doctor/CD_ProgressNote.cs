
using EMR.Data.CustomAttribute;
using System;

namespace EMR.Data.Models
{
    public partial class CD_ProgressNote
    {
        /// <summary>
        /// �����������
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string ProgressTypeName { get; set; }

        /// <summary>
        /// �����û�����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// �����û�����ǩ��ͼƬ��ַ
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string CreatorESign { get; set; }
        /// <summary>
        /// �鷿ҽʦ����
        /// </summary>
        [FieldType(FieldTypeEnum.Ignore)]
        public string WardRoundUserName { get; set; }

    }

    public partial class ProgressNote_Content_Item
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}