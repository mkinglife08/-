// File:    GI_USERINFO.cs
// Author:  Administrator
// Created: 2018��10��24�� 15:28:29
// Purpose: Definition of Class GI_USERINFO

using System;
using System.Collections.Generic;

namespace EMR.Data.Models
{
    /// GI_USERINFO  ϵͳ�û���Ա
    public partial class GI_UserInfo
    {
        public string IsSuperName { get; set; }

        public string IsOnlineName { get; set; }
        /// <summary>
        /// �����б�����0����1����
        /// </summary>
        public string IsCanceName { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string DpetName { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string InpatientName { get; set; }
        /// <summary>
        /// �û�ҽ����
        /// </summary>
        public string MedicalName { get; set; }
        /// <summary>
        /// ְ��
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// ְ�񼶱�����
        /// </summary>
        public string JobLevelName { get; set; }
        /// <summary>
        /// �û�ְ��
        /// </summary>
        public string UserPositionName { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public List<AI_DeptInfo> DpetList { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public List<AI_DeptInfo> InpatientList { get; set; }
        /// <summary>
        /// ҽ���û���
        /// </summary>
        public List<AI_DoctorGroup> MedicalList { get; set; }

    }
}