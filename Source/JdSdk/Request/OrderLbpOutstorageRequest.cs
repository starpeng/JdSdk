#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:08.42523 +08:00
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
    /// 输入单个订单id，进行lbp出库操作 Request
    /// </summary>
    public class OrderLbpOutstorageRequest : JdRequestBase<OrderLbpOutstorageResponse>
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
        /// 物流公司id(可通过获取商家物流公司接口获得,0,表示自送,)
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
        /// 运单号(当自送时运单号可为空)
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
            get{ return "360buy.order.lbp.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("package_num" ,this.PackageNum);
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
