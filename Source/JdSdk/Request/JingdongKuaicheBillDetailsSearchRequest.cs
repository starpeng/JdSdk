#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.71765 +08:00
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
    public class JingdongKuaicheBillDetailsSearchRequest : IJdRequest<JingdongKuaicheBillDetailsSearchResponse>
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

        public String ApiName
        {
            get{ return "jingdong.kuaiche.bill.details.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("bill_no" ,this.BillNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bill_no", this.BillNo);
        }

    }
}
