#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:034 +08:00
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
    /// 根据条件检索订单信息 Request
    /// </summary>
    public class OrderSearchRequest : JdRequestBase<OrderSearchResponse>
    {
        /// <summary>
        /// 开始时间 和 结束时间 不得相差超过1个月
        /// </summary>
        /// <example>2010-12-20 17:15:00</example>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间 和 结束时间 不得相差超过1个月
        /// </summary>
        /// <example>2010-12-20 17:15:00</example>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 多订单状态可以用逗号隔开( WAIT_SELLER_STOCK_OUT 等待出库 ,SEND_TO_DISTRIBUTION_CENER 发往配送中心(只适用于LBP,SOPL商家),DISTRIBUTION_CENTER_RECEIVED 配送中心已收货(只适用于LBP,SOPL商家)，WAIT_GOODS_RECEIVE_CONFIRM 等待确认收货,RECEIPTS_CONFIRM 收款确认(服务完成)(只适用于LBP,SOPL商家)FINISHED_L 完成,TRADE_CANCELED 取消)LOCKED 已锁定（锁定的订单不返回订单详情）
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
        /// 查询的页数
        /// </summary>
        /// <example>1</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Int32 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页的条数（最大page_size 100条）
        /// </summary>
        /// <example>12</example>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int32 PageSize
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
            get { return "360buy.order.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("start_date", this.StartDate);
            paramters.Add("end_date", this.EndDate);
            paramters.Add("order_state", this.OrderState);
            paramters.Add("page", this.Page);
            paramters.Add("page_size", this.PageSize);
            paramters.Add("optional_fields", this.OptionalFields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_state", this.OrderState);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
