#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.65770 +08:00
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
    public class JingdongKuaicheZnBidRankGetRequest : IJdRequest<JingdongKuaicheZnBidRankGetResponse>
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
        public Nullable<Decimal> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价的关键词组id
        /// </summary>
        [XmlElement("kwg_id")]
        [JsonProperty("kwg_id")]
        public Nullable<Decimal> KwgId
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

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.bid.rank.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("plan_json" ,this.PlanJson);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("kwg_id" ,this.KwgId);
            paramters.Add("plan_date" ,this.PlanDate);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
