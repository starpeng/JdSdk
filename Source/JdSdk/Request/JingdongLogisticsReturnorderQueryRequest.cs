#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:53.22661 +08:00
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
    /// 退货入库单查询 Request
    /// </summary>
    public class JingdongLogisticsReturnorderQueryRequest : JdRequestBase<JingdongLogisticsReturnorderQueryResponse>
    {
        /// <summary>
        /// 要查询的josl退货入库单号
        /// </summary>
        /// <example>JRI000001</example>
        [XmlElement("receipt_no")]
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.returnorder.query"; }
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
