#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.65770 +08:00
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
    /// 根据计划信息获取排名信息 Request
    /// </summary>
    public class JingdongKuaicheZnBidRankGetRequest : JdRequestBase<JingdongKuaicheZnBidRankGetResponse>
    {
        /// <summary>
        /// plan json格式
        /// </summary>
        [XmlElement("plan_json")]
        [JsonProperty("plan_json")]
        public String PlanJson
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价频道id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价的关键词组id
        /// </summary>
        [XmlElement("kwg_id")]
        [JsonProperty("kwg_id")]
        public Nullable<Int64> KwgId
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
            get { return "jingdong.kuaiche.zn.bid.rank.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("plan_json", this.PlanJson);
            paramters.Add("cid", this.Cid);
            paramters.Add("kwg_id", this.KwgId);
            paramters.Add("plan_date", this.PlanDate);

        }

        public override void Validate()
        {
        }

    }
}
