#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:46:427 +08:00
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
            get { return "360buy.order.lbp.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("order_id", this.OrderId);
            paramters.Add("send_type", this.SendType);
            paramters.Add("package_num", this.PackageNum);
            paramters.Add("logistics_id", this.LogisticsId);
            paramters.Add("waybill", this.Waybill);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("send_type", this.SendType);
            RequestValidator.ValidateRequired("package_num", this.PackageNum);
            RequestValidator.ValidateRequired("logistics_id", this.LogisticsId);
            //RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
