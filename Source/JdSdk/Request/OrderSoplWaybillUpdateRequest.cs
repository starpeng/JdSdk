#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 23:18:26.61627 +08:00
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
    /// 输入单个订单id等修改运单号 Request
    /// </summary>
    public class OrderSoplWaybillUpdateRequest : JdRequestBase<OrderSoplWaybillUpdateResponse>
    {
        /// <summary>
        /// 订单id
        /// </summary>
        /// <example>123765123</example>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 物流公司ID(只可通过获取商家物流公司接口获得),多个物流公司以|分隔
        /// </summary>
        /// <example>65234</example>
        [XmlElement("logistics_id")]
        [JsonProperty("logistics_id")]
        public Int32 LogisticsId
        {
            get;
            set;
        }

        /// <summary>
        /// 运单号(当厂家自送时运单号可为空，不同物流公司的运单号用|分隔，如果同一物流公司有多个运单号，则用英文逗号分隔)
        /// </summary>
        /// <example>AFE234223</example>
        [XmlElement("waybill")]
        [JsonProperty("waybill")]
        public String Waybill
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
            get { return "360buy.order.sopl.waybill.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("order_id", this.OrderId);
            paramters.Add("logistics_id", this.LogisticsId);
            paramters.Add("waybill", this.Waybill);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("logistics_id", this.LogisticsId);
        }

    }
}
