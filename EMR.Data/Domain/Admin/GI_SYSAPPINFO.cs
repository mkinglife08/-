// File:    GI_USERINFO.cs
// Author:  Administrator
// Created: 2018��10��24�� 15:28:29
// Purpose: Definition of Class GI_USERINFO

using System;

namespace EMR.Data.Models
{
    /// GI_USERINFO  ϵͳ�û���Ա
    public partial class GI_SYSAPPINFO
    {
        /// �Ƿ������б�0����1����
        public string IsCanceName { get; set; }

        /// <summary>
        /// layui��ѡ�б�ǣ�ǧ��Ҫ�Ĵ�Сд��������Ҫ���κ��޸ģ�
        /// </summary>
        public bool? LAY_CHECKED { get; set; }

    }
}