#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.20449 +08:00
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
    /// 获取订单信息 Request
    /// </summary>
    public class JingdongLogisticsOrderGetRequest : JdRequestBase<JingdongLogisticsOrderGetResponse>
    {
        /// <summary>
        /// JOSL唯一单号
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
            get { return "jingdong.logistics.order.get"; }
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
