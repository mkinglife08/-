// File:    GI_CODEDICT.cs
// Author:  Administrator
// Created: 2018��10��24�� 15:28:29
// Purpose: Definition of Class GI_CODEDICT

using System;

namespace EMR.Data.Models
{
    /// <summary>
    /// - V_FUNINFO ʵ����
    /// </summary>
    public partial class V_FunInfo
    {
        /// <summary>
        ///  ��֯����
        /// </summary>
        public string OrganName { get; set; }
        /// <summary>
        ///  ϵͳģ��
        /// </summary>
        public string SYSName { get; set; }
        /// <summary>
        ///  �������
        /// </summary>
        public string FUNID { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string OrganID { get; set; }
        /// <summary>
        ///  �������
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string SYSID { get; set; }
        /// <summary>
        ///  ��������
        /// </summary>
        public string FUNName { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public int? IsLast { get; set; }
        /// <summary>
        ///  ����ҳ��
        /// </summary>
        public string FUNPage { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public int? IsShow { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string FunNtoe { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string FUNIcon { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string CheckIcon { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string SpellCode { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public DateTime ModifyTime { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string ModifyUserCode { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public int? FUNLevel { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public int? DisplaySort { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public int? IsCance { get; set; }
        /// <summary>
        ///  ��������
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// ��ʶ����
        /// </summary>
        public string Myidentity { get; set; }

        public string IsLastName { get; set; }
        /// <summary>
        /// �Ƿ���ʾ
        /// </summary>
        public string IsShowName { get; set; }
    }
}