#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:10.28719 +08:00
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
        /// 发货地址所对应id（可通过商家获取发货地址接口获取到）保留参数
        /// </summary>
        [XmlElement("address_id")]
        [JsonProperty("address_id")]
        public Nullable<Int64> AddressId
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
            get{ return "360buy.order.sopl.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("package_num" ,this.PackageNum);
            paramters.Add("address_id" ,this.AddressId);
            paramters.Add("logistics_id" ,this.LogisticsId);
            paramters.Add("waybill" ,this.Waybill);
            paramters.Add("trade_no" ,this.TradeNo);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("package_num", this.PackageNum);
            RequestValidator.ValidateRequired("logistics_id", this.LogisticsId);
            RequestValidator.ValidateRequired("waybill", this.Waybill);
        }

    }
}
