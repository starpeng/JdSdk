#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.03497 +08:00
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
    /// 查询月账单明细 Request
    /// </summary>
    public class JingdongKuaicheBillDetailsSearchRequest : JdRequestBase<JingdongKuaicheBillDetailsSearchResponse>
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Int64 BillNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.bill.details.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("bill_no" ,this.BillNo);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("bill_no", this.BillNo);
        }

    }
}
