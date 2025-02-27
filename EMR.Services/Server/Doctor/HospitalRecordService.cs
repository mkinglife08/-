﻿/*----------------------------------------------------------------
// Copyright (C) 2018-2019 杭州华卓信息科技有限公司   版权所有。 
// 文件名：HospitalRecordService.cs
// 文件功能描述： 入院服务层，为（控制器Control、WebService、WebAPI等UI逻辑层）提供公用代码字典相关数据的服务，一般返回与公用代码字典相关的实体或实体集合。
// 创建标识：朱天伟 2019-01-07
// 修改标识：
// 修改描述：
----------------------------------------------------------------*/

using EMR.Data;
using EMR.Data.Models;
using EMR.Services.Extension;
using EMR.Services.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Services.Server.Doctor
{
    public class HospitalRecordService
    {
        #region 增删改
        /// <summary>
        /// 增加和保存
        /// </summary>
        /// <param name="info"></param>
        public void SaveInfo(CD_HospitalRecord info)
        {
            if (!string.IsNullOrWhiteSpace(info.HospitalRecordId) && info.HospitalRecordId != "null")
            {
                info.UpdateTime = DateTime.Now;
                info.CreateTime = null;
                info.UpdateM("HospitalRecordId");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(info.InpatientId) && info.InpatientId != "null")
                {
                    CD_HospitalRecord nowinfo = GetInfoByInpatientId(info.InpatientId);
                    if (nowinfo != null)
                    {
                        info.UpdateTime = DateTime.Now;
                        info.CreateTime = null;
                        info.UpdateM("InpatientId");
                    }
                    else
                    {
                        info.HospitalRecordId = CommonService.GetPrimaryId(new GI_SerialInfo() { Name = "CD_HospitalRecord", ColumnName = "HospitalRecordId", OrganID = info.OrganID }) + "";
                        info.Creator = info.Updater;//添加的情况下创建医生就是修改医生
                        info.CreateTime = DateTime.Now;//添加情况下
                        info.UpdateTime = DateTime.Now;
                        info.SaveModelM();
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// 根据住院病人id获得入院记录
        /// </summary>
        /// <returns></returns>
        public CD_HospitalRecord GetInfoByInpatientId(string InpatientId)
        {
            CD_HospitalRecord info = EntityOperate<CD_HospitalRecord>.GetEntityById(InpatientId, "InpatientId");

            if (info != null)
            {
                if (!string.IsNullOrWhiteSpace(info.Creator))
                {
                    GI_UserInfo Creator = EntityOperate<GI_UserInfo>.GetEntityById(info.Creator, "UserID");
                    info.CreatorName = Creator?.UserName;                    
                }
                if (!string.IsNullOrWhiteSpace(info.Updater))
                {
                    GI_UserInfo Updater = EntityOperate<GI_UserInfo>.GetEntityById(info.Updater, "UserID");
                    info.UpdaterName = Updater?.UserName;
                }
            }
            return info;
        }



    }


}
