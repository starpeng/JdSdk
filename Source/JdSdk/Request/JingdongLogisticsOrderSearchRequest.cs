#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.40651 +08:00
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
    /// 获取多订单信息 Request
    /// </summary>
    public class JingdongLogisticsOrderSearchRequest : JdRequestBase<JingdongLogisticsOrderSearchResponse>
    {
        /// <summary>
        /// JOSL唯一单号(多订单请用英文','分割,最大支持200单)
        /// </summary>
        [XmlElement("receipt_nos")]
        [JsonProperty("receipt_nos")]
        public String ReceiptNos
        {
            get;
            set;
        }

        /// <summary>
        /// 状态值集(,)
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.order.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("receipt_nos", this.ReceiptNos);
            paramters.Add("status", this.Status);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("receipt_nos", this.ReceiptNos);
        }

    }
}
