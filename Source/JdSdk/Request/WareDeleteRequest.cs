#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:12.06981 +08:00
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
    /// 通过api 根据ware_id 商品编号 删除商品 Request
    /// </summary>
    public class WareDeleteRequest : JdRequestBase<WareDeleteResponse>
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public Int64 TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("ware_id", this.WareId);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
        }

    }
}
