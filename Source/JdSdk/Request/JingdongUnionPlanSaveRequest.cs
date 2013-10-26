#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:59.09095 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据商家输入的计划信息新建或修改商家计划 Request
    /// </summary>
    public class JingdongUnionPlanSaveRequest : JdRequestBase<JingdongUnionPlanSaveResponse>
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public String PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("planName")]
        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间,格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public String StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public String EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 说明
        /// </summary>
        [XmlElement("notes")]
        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

        /// <summary>
        /// 计划状态 ，1表示保存草稿，其它值表示保存
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 类目佣金json ，取jingdong.union.categoryinfo.search接口返回的信息即可，commisionRatioLevel2表示二级类目的佣金比例值，commisionRatio为三级类目佣金，目前只取二级佣金值
        /// </summary>
        /// <example>[{'categoryLevel1Id':652,'categoryLevel2Id':653,'categoryLevel3Id':'655','categoryLevel1Name':'  手机数码','categoryLevel2Name':'手机通讯','categoryLevel3Name':'手机  ','commisionRatio':'2','commisionRatioLevel2':'2'},……,]</example>
        [XmlElement("category")]
        [JsonProperty("category")]
        public String Category
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.plan.save"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("planid", this.PlanId);
            paramters.Add("planname", this.PlanName);
            paramters.Add("startdate", this.StartDate);
            paramters.Add("enddate", this.EndDate);
            paramters.Add("notes", this.Notes);
            paramters.Add("status", this.Status);
            paramters.Add("category", this.Category);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("planId", this.PlanId);
            RequestValidator.ValidateRequired("planName", this.PlanName);
            RequestValidator.ValidateRequired("startDate", this.StartDate);
            RequestValidator.ValidateRequired("endDate", this.EndDate);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("category", this.Category);
        }

    }
}
