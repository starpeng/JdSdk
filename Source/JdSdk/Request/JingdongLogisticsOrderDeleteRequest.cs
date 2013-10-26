#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.00148 +08:00
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
    /// 订单取消 Request
    /// </summary>
    public class JingdongLogisticsOrderDeleteRequest : JdRequestBase<JingdongLogisticsOrderDeleteResponse>
    {
        /// <summary>
        /// JOSL单号
        /// </summary>
        [XmlElement("receipt_no")]
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.order.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("receipt_no", this.ReceiptNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("receipt_no", this.ReceiptNo);
        }

    }
}
