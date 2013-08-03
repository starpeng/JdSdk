#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.95766 +08:00
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
    public class JingdongKuaicheBillSearchRequest : IJdRequest<JingdongKuaicheBillSearchResponse>
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Nullable<Decimal> BillNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.bill.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("bill_no" ,this.BillNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
