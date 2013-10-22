#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.95766 +08:00
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
    /// 获取商家每月消费账单 Request
    /// </summary>
    public class JingdongKuaicheBillSearchRequest : JdRequestBase<JingdongKuaicheBillSearchResponse>
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Nullable<Int64> BillNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.bill.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("bill_no", this.BillNo);

        }

        public override void Validate()
        {
        }

    }
}
