#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:53.02460 +08:00
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
    /// 退货入库单取消 Request
    /// </summary>
    public class JingdongLogisticsReturnorderCancelRequest : JdRequestBase<JingdongLogisticsReturnorderCancelResponse>
    {
        /// <summary>
        /// 要取消的退货入库单号
        /// </summary>
        /// <example>JRI000001</example>
        [XmlElement("receipt_no")]
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        /// <summary>
        /// ISV来源
        /// </summary>
        /// <example>http://www.centaur.cn/</example>
        [XmlElement("isv_source")]
        [JsonProperty("isv_source")]
        public String IsvSource
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.returnorder.cancel"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("receipt_no", this.ReceiptNo);
            paramters.Add("isv_source", this.IsvSource);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("receipt_no", this.ReceiptNo);
        }

    }
}
