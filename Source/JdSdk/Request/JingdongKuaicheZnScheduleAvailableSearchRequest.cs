#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:44.67012 +08:00
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
    /// 根据广告位id获取可以投放的日期 Request
    /// </summary>
    public class JingdongKuaicheZnScheduleAvailableSearchRequest : JdRequestBase<JingdongKuaicheZnScheduleAvailableSearchResponse>
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("space_id")]
        [JsonProperty("space_id")]
        public Int64 SpaceId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.schedule.available.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("space_id" ,this.SpaceId);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("space_id", this.SpaceId);
        }

    }
}
