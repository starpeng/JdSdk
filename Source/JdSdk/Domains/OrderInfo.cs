#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74546 +08:00
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
        /// 订单id, 默认必须返回
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 支付方式（1货到付款, 2邮局汇款, 3自提, 4在线支付, 5公司转账, 6银行转账）
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
        /// 订单货款金额（订单总金额-商家优惠金额）
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
        /// 订单状态（英文）具体返回值列表请发邮件至jos#jd.com获取
        /// </summary>
        [XmlElement("order_state")]
        [JsonProperty("order_state")]
        public String OrderState
        {
            get;
            set;
        }

        /// <summary>
        /// 订单状态说明（中文）具体返回值列表请发邮件至jos#jd.com获取
        /// </summary>
        [XmlElement("order_state_remark")]
        [JsonProperty("order_state_remark")]
        public String OrderStateRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 送货（日期）类型（1-只工作日送货(双休日、假日不用送);2-只双休日、假日送货(工作日不用送);3-工作日、双休日与假日均可送货;其他值-返回“任意时间”）
        /// </summary>
        [XmlElement("delivery_type")]
        [JsonProperty("delivery_type")]
        public String DeliveryType
        {
            get;
            set;
        }

        /// <summary>
        /// 发票信息        “invoice_info:  不需要开具发票”下无需开具发票；其它返回值请正常开具发票
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
        /// 结单时间        如返回信息为“0001-01-01  00:00:00”和“1970-01-01 00:00:00”，可认为此订单为未完成状态。
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
        /// 订单优惠列表
        /// </summary>
        [XmlElement("couponDetailList")]
        [JsonProperty("couponDetailList")]
        public List<CouponDetail> CouponDetailList
        {
            get;
            set;
        }

        /// <summary>
        /// 换货订单标识 0:不是换货订单,1:换货订单(默认不返回)
        /// </summary>
        /// <example>1</example>
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
        /// 付款确认时间如果没有付款时间默认返回0001-01-01 00:00:00
        /// </summary>
        /// <example>2013-08-19 15:24:43</example>
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
