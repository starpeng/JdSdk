#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.21555 +08:00
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
    /// 其它出库单查询 Request
    /// </summary>
    public class JingdongLogisticsOtherOutstoreQueryRequest : JdRequestBase<JingdongLogisticsOtherOutstoreQueryResponse>
    {
        /// <summary>
        /// josl出库单号
        /// </summary>
        [XmlElement("josl_outbound_no")]
        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.otherOutstore.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("josl_outbound_no", this.JoslOutboundNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("josl_outbound_no", this.JoslOutboundNo);
        }

    }
}
