// File:    GI_ROLE.cs
// Author:  Administrator
// Created: 2018��10��24�� 15:28:29
// Purpose: Definition of Class GI_ROLE

using System;

namespace EMR.Data.Models
{
    /// GI_ROLE  ϵͳ�û�����
    public partial class GI_Role
    {
        public string PowerName { get; set; }

        /// <summary>
        /// layui��ѡ�б�ǣ�ǧ��Ҫ�Ĵ�Сд��������Ҫ���κ��޸ģ�
        /// </summary>
        public bool? LAY_CHECKED { get; set; }
        /// <summary>
        /// �Ƿ������б�0����1���� 
        /// </summary>
        public int? IsCance { get; set; }

    }
}