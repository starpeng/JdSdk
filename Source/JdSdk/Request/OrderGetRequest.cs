#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:45:008 +08:00
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
    /// 输入单个订单id，得到所有相关订单信息 Request
    /// </summary>
    public class OrderGetRequest : JdRequestBase<OrderGetResponse>
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
        /// 多订单状态可以用逗号隔开( WAIT_SELLER_STOCK_OUT 等待出库 ,SEND_TO_DISTRIBUTION_CENER 发往配送中心(只适用于LBP,SOPL商家),DISTRIBUTION_CENTER_RECEIVED 配送中心已收货(只适用于LBP,SOPL商家)，WAIT_GOODS_RECEIVE_CONFIRM 等待确认收货,RECEIPTS_CONFIRM 收款确认(服务完成)(只适用于LBP,SOPL商家)FINISHED_L 完成,TRADE_CANCELED 取消) LOCKED 已锁定（锁定的订单不返回订单详情）
        /// </summary>
        /// <example>WAIT_SELLER_STOCK_OUT</example>
        [XmlElement("order_state")]
        [JsonProperty("order_state")]
        public String OrderState
        {
            get;
            set;
        }

        /// <summary>
        /// 商家希望返回的订单的信息字段,每个字段以逗号分隔
        /// </summary>
        [XmlElement("optional_fields")]
        [JsonProperty("optional_fields")]
        public String OptionalFields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.order.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("order_id", this.OrderId);
            paramters.Add("order_state", this.OrderState);
            paramters.Add("optional_fields", this.OptionalFields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

    }
}
