#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:853 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OrderInfo结构
    /// </summary>
    [Serializable]
    public class OrderInfo : JdObject
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_type")]
        [JsonProperty("pay_type")]
        public String PayType
        {
            get;
            set;
        }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("order_total_price")]
        [JsonProperty("order_total_price")]
        public String OrderTotalPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 用户应付金额
        /// </summary>
        [XmlElement("order_payment")]
        [JsonProperty("order_payment")]
        public String OrderPayment
        {
            get;
            set;
        }

        /// <summary>
        /// 订单结算金额
        /// </summary>
        [XmlElement("order_seller_price")]
        [JsonProperty("order_seller_price")]
        public String OrderSellerPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的运费
        /// </summary>
        [XmlElement("freight_price")]
        [JsonProperty("freight_price")]
        public String FreightPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("seller_discount")]
        [JsonProperty("seller_discount")]
        public String SellerDiscount
        {
            get;
            set;
        }

        /// <summary>
        /// 订单状态（英文）
        /// </summary>
        [XmlElement("order_state")]
        [JsonProperty("order_state")]
        public String OrderState
        {
            get;
            set;
        }

        /// <summary>
        /// 订单状态说明（中文）
        /// </summary>
        [XmlElement("order_state_remark")]
        [JsonProperty("order_state_remark")]
        public String OrderStateRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 送货（日期）类型
        /// </summary>
        [XmlElement("delivery_type")]
        [JsonProperty("delivery_type")]
        public String DeliveryType
        {
            get;
            set;
        }

        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice_info")]
        [JsonProperty("invoice_info")]
        public String InvoiceInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 买家下单时订单备注
        /// </summary>
        [XmlElement("order_remark")]
        [JsonProperty("order_remark")]
        public String OrderRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_start_time")]
        [JsonProperty("order_start_time")]
        public String OrderStartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 结单时间
        /// </summary>
        [XmlElement("order_end_time")]
        [JsonProperty("order_end_time")]
        public String OrderEndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人基本信息
        /// </summary>
        [XmlElement("consignee_info")]
        [JsonProperty("consignee_info")]
        public UserInfo ConsigneeInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 订单商品列表
        /// </summary>
        [XmlElement("item_info_list")]
        [JsonProperty("item_info_list")]
        public List<ItemInfo> ItemInfoList
        {
            get;
            set;
        }

        /// <summary>
        /// 订单商家优惠列表
        /// </summary>
        [XmlElement("coupon_detail_list")]
        [JsonProperty("coupon_detail_list")]
        public List<CouponDetail> CouponDetailList
        {
            get;
            set;
        }


        /// <summary>
        /// 换货订单标识 0:不是换货订单,1:换货订单(默认不返回)
        /// </summary>
        [XmlElement("return_order")]
        [JsonProperty("return_order")]
        public String ReturnOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 商家订单备注（不大于500字符）
        /// </summary>
        [XmlElement("vender_remark")]
        [JsonProperty("vender_remark")]
        public String VenderRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 即买家的账号信息
        /// </summary>
        [XmlElement("pin")]
        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        /// <summary>
        /// 订单更新时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        /// <summary>
        /// 余额支付金额
        /// </summary>
        [XmlElement("balance_used")]
        [JsonProperty("balance_used")]
        public String BalanceUsed
        {
            get;
            set;
        }

        /// <summary>
        /// 付款确认时间 如果没有付款时间 默认返回0001-01-01 00:00:00
        /// </summary>
        [XmlElement("payment_confirm_time")]
        [JsonProperty("payment_confirm_time")]
        public String PaymentConfirmTime
        {
            get;
            set;
        }

        /// <summary>
        /// 物流公司ID，多个物流公司以|分隔
        /// </summary>
        [XmlElement("logistics_id")]
        [JsonProperty("logistics_id")]
        public String LogisticsId
        {
            get;
            set;
        }

        /// <summary>
        /// 运单号，当物流公司是厂家自送时运单号可为空，不同物流公司的运单号用|分隔，如果同一物流公司有多个运单号，则用英文逗号分隔
        /// </summary>
        [XmlElement("waybill")]
        [JsonProperty("waybill")]
        public String Waybill
        {
            get;
            set;
        }

        /// <summary>
        /// 增值税发票
        /// </summary>
        [XmlElement("vat_invoice_info")]
        [JsonProperty("vat_invoice_info")]
        public VatInvoiceInfo VatInvoiceInfo
        {
            get;
            set;
        }
    }
}
