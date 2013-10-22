#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.71765 +08:00
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
    /// 查询月账单明细 Request
    /// </summary>
    public class JingdongKuaicheBillDetailsSearchRequest : JdRequestBase<JingdongKuaicheBillDetailsSearchResponse>
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Decimal BillNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.bill.details.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("bill_no", this.BillNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("bill_no", this.BillNo);
        }

    }
}
