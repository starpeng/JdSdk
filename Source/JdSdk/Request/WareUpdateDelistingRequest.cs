#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:18.09633 +08:00
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
    /// 通过api 根据ware_id 商品编号 操作商品下架 Request
    /// </summary>
    public class WareUpdateDelistingRequest : JdRequestBase<WareUpdateDelistingResponse>
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号
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
            get{ return "360buy.ware.update.delisting"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("trade_no" ,this.TradeNo);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
        }

    }
}
