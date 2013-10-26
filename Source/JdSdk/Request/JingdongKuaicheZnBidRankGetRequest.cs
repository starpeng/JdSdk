#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.84401 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据计划信息获取排名信息 Request
    /// </summary>
    public class JingdongKuaicheZnBidRankGetRequest : JdRequestBase<JingdongKuaicheZnBidRankGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：PlanDetailInfo结构体中；把对象转相应的json
        /// </summary>
        [XmlElement("plan_json")]
        [JsonProperty("plan_json")]
        public String PlanJson
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价频道id （三级类目id）
        /// </summary>
        /// <example>870</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Int64 Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价的关键词组id
        /// </summary>
        [XmlElement("kwg_id")]
        [JsonProperty("kwg_id")]
        public Int64 KwgId
        {
            get;
            set;
        }

        /// <summary>
        /// 预测日期 格式20130706
        /// </summary>
        [XmlElement("plan_date")]
        [JsonProperty("plan_date")]
        public String PlanDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.bid.rank.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_json" ,this.PlanJson);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("kwg_id" ,this.KwgId);
            paramters.Add("plan_date" ,this.PlanDate);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("plan_json", this.PlanJson);
        }

    }
}
