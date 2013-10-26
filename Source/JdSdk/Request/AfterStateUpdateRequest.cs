#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:31.71038 +08:00
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
    public class AfterStateUpdateRequest : JdRequestBase<AfterStateUpdateResponse>
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

        public override String ApiName
        {
            get{ return "360buy.after.state.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("return_id" ,this.ReturnId);
            paramters.Add("trade_no" ,this.TradeNo);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("return_id", this.ReturnId);
            RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
