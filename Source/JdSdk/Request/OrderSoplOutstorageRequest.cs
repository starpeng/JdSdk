#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:46:629 +08:00
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
    /// 输入单个订单id，进行sopl出库操作 Request
    /// </summary>
    public class OrderSoplOutstorageRequest : JdRequestBase<OrderSoplOutstorageResponse>
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
        /// 发货类型，默认是1
        /// </summary>
        /// <example>1</example>
        [XmlElement("send_type")]
        [JsonProperty("send_type")]
        public Int32 SendType
        {
            get;
            set;
        }

        /// <summary>
        /// 包裹数量
        /// </summary>
        [XmlElement("package_num")]
        [JsonProperty("package_num")]
        public Int32 PackageNum
        {
            get;
            set;
        }

        /// <summary>
        /// 发货地址所对应id（可通过商家获取发货地址接口获取到）
        /// </summary>
        [XmlElement("address_id")]
        [JsonProperty("address_id")]
        public Int64 AddressId
        {
            get;
            set;
        }

        /// <summary>
        /// 物流公司id(可通过获取商家物流公司接口获得,0,表示自送,)
        /// </summary>
        [XmlElement("logistics_id")]
        [JsonProperty("logistics_id")]
        public String LogisticsId
        {
            get;
            set;
        }

        /// <summary>
        /// 运单号(当自送时运单号可为空)
        /// </summary>
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
            get { return "360buy.order.sopl.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("order_id", this.OrderId);
            paramters.Add("send_type", this.SendType);
            paramters.Add("package_num", this.PackageNum);
            paramters.Add("address_id", this.AddressId);
            paramters.Add("logistics_id", this.LogisticsId);
            paramters.Add("waybill", this.Waybill);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("send_type", this.SendType);
            RequestValidator.ValidateRequired("package_num", this.PackageNum);
            //RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
