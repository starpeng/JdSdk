#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.77472 +08:00
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
    /// 咨询指定日期的平均等待时长 Request
    /// </summary>
    public class JingdongImPopConsultAvgwaittimeGetRequest : JdRequestBase<JingdongImPopConsultAvgwaittimeGetResponse>
    {
        /// <summary>
        /// 需要查询的客服账号，为空默认查询的是商家主账户 
        /// </summary>
        /// <example></example>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        /// <summary>
        /// 需要查询数据的日期（取DateTime的年月日部分），查询的日期距现在不能大于3个月
        /// </summary>
        /// <example></example>
        [XmlElement("date")]
        [JsonProperty("date")]
        public DateTime DateTime
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.im.pop.consult.avgwaittime.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("waiter" ,this.Waiter);
            paramters.Add("date" ,this.DateTime);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("date", this.DateTime);
        }

    }
}
