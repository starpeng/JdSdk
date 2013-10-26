#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:39.19880 +08:00
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
    /// 客服日未回复量统计 Request
    /// </summary>
    public class JingdongImPopUnreplystatGetRequest : JdRequestBase<JingdongImPopUnreplystatGetResponse>
    {
        /// <summary>
        /// 需要查询的客服账号列表，为空默认查询的是商家主账户
        /// </summary>
        /// <example></example>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public List<String> Waiter
        {
            get;
            set;
        }

        /// <summary>
        /// 需要查询数据的开始日期（取DateTime的年月日部分）
        /// </summary>
        /// <example></example>
        [XmlElement("startTime")]
        [JsonProperty("startTime")]
        public DateTime StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 需要查询数据的截止日期（取DateTime的年月日部分），查询起止日期相差不能大于7天，查询的日期距现在不能大于3个月
        /// </summary>
        /// <example></example>
        [XmlElement("endTime")]
        [JsonProperty("endTime")]
        public DateTime EndTime
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.im.pop.unreplystat.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waiter" ,this.Waiter);
            paramters.Add("starttime" ,this.StartTime);
            paramters.Add("endtime" ,this.EndTime);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("startTime", this.StartTime);
            RequestValidator.ValidateRequired("endTime", this.EndTime);
        }

    }
}
