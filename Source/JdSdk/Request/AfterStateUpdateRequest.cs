#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:440 +08:00
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
    /// 根据退货单id 进行退货确认操作 Request
    /// </summary>
    public class AfterStateUpdateRequest : IJdRequest<AfterStateUpdateResponse>
    {
        /// <summary>
        /// 退货单ID
        /// </summary>
        [XmlElement("return_id")]
        [JsonProperty("return_id")]
        public String ReturnId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public String TradeNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.after.state.update"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("return_id" ,this.ReturnId);
            paramters.Add("trade_no" ,this.TradeNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("return_id", this.ReturnId);
            RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
