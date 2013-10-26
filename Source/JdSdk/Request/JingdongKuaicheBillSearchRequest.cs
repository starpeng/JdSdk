#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.23698 +08:00
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
    /// 获取商家每月消费账单 Request
    /// </summary>
    public class JingdongKuaicheBillSearchRequest : JdRequestBase<JingdongKuaicheBillSearchResponse>
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
            get{ return "jingdong.kuaiche.bill.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("bill_no" ,this.BillNo);
        }

        public override void Validate()
        {
        }

    }
}
