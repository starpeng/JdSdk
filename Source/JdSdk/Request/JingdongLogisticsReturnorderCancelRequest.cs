#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:53.02460 +08:00
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
    /// 退货入库单取消 Request
    /// </summary>
    public class JingdongLogisticsReturnorderCancelRequest : IJdRequest<JingdongLogisticsReturnorderCancelResponse>
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

        public String ApiName
        {
            get{ return "jingdong.logistics.returnorder.cancel"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("receipt_no" ,this.ReceiptNo);
            paramters.Add("isv_source" ,this.IsvSource);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("receipt_no", this.ReceiptNo);
        }

    }
}
