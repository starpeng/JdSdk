#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:50.79947 +08:00
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
    /// 客户订单 Request
    /// </summary>
    public class JingdongLogisticsOrderAddRequest : JdRequestBase<JingdongLogisticsOrderAddResponse>
    {
        /// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("channels_seller_no")]
        [JsonProperty("channels_seller_no")]
        public String ChannelsSellerNo
        {
            get;
            set;
        }

        /// <summary>
        /// 出库单号
        /// </summary>
        [XmlElement("channels_outbound_no")]
        [JsonProperty("channels_outbound_no")]
        public String ChannelsOutboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// 生产库房编号
        /// </summary>
        [XmlElement("warehouse_no")]
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        /// <summary>
        /// 承运商编号ID
        /// </summary>
        [XmlElement("carriers_id")]
        [JsonProperty("carriers_id")]
        public String CarriersId
        {
            get;
            set;
        }

        /// <summary>
        /// 期望发货日期(yyyy-mm-dd hh:mm:ss)
        /// </summary>
        [XmlElement("expect_date")]
        [JsonProperty("expect_date")]
        public String ExpectDate
        {
            get;
            set;
        }

        /// <summary>
        /// 平台销售单号
        /// </summary>
        [XmlElement("order_no")]
        [JsonProperty("order_no")]
        public String OrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// 平台店铺编号
        /// </summary>
        [XmlElement("shop_no")]
        [JsonProperty("shop_no")]
        public String ShopNo
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("consignee_name")]
        [JsonProperty("consignee_name")]
        public String ConsigneeName
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人省
        /// </summary>
        [XmlElement("address_province")]
        [JsonProperty("address_province")]
        public String AddressProvince
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人市
        /// </summary>
        [XmlElement("address_city")]
        [JsonProperty("address_city")]
        public String AddressCity
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人县
        /// </summary>
        [XmlElement("address_county")]
        [JsonProperty("address_county")]
        public String AddressCounty
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人镇
        /// </summary>
        [XmlElement("address_town")]
        [JsonProperty("address_town")]
        public String AddressTown
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("address")]
        [JsonProperty("address")]
        public String Address
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人邮编
        /// </summary>
        [XmlElement("zip_code")]
        [JsonProperty("zip_code")]
        public String ZipCode
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("phone")]
        [JsonProperty("phone")]
        public String Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人手机
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// 应收金额
        /// </summary>
        [XmlElement("receivable")]
        [JsonProperty("receivable")]
        public Int64 Receivable
        {
            get;
            set;
        }

        /// <summary>
        /// email
        /// </summary>
        [XmlElement("email")]
        [JsonProperty("email")]
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// 买家留言
        /// </summary>
        [XmlElement("buyer_remark")]
        [JsonProperty("buyer_remark")]
        public String BuyerRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("verify_remark")]
        [JsonProperty("verify_remark")]
        public String VerifyRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 退货收货人地址
        /// </summary>
        [XmlElement("return_consignee_address")]
        [JsonProperty("return_consignee_address")]
        public String ReturnConsigneeAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 退货收货人姓名
        /// </summary>
        [XmlElement("return_consignee_name")]
        [JsonProperty("return_consignee_name")]
        public String ReturnConsigneeName
        {
            get;
            set;
        }

        /// <summary>
        /// 退货收货人电话
        /// </summary>
        [XmlElement("return_consignee_phone")]
        [JsonProperty("return_consignee_phone")]
        public String ReturnConsigneePhone
        {
            get;
            set;
        }

        /// <summary>
        /// 站点编号
        /// </summary>
        [XmlElement("station_no")]
        [JsonProperty("station_no")]
        public String StationNo
        {
            get;
            set;
        }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        [JsonProperty("station_name")]
        public String StationName
        {
            get;
            set;
        }

        /// <summary>
        /// 订单标记位:50位的数字串，第1位为1代表货到付款
        /// </summary>
        [XmlElement("order_mark")]
        [JsonProperty("order_mark")]
        public String OrderMark
        {
            get;
            set;
        }

        /// <summary>
        /// 销售平台来源
        /// </summary>
        [XmlElement("shop_order_source")]
        [JsonProperty("shop_order_source")]
        public String ShopOrderSource
        {
            get;
            set;
        }

        /// <summary>
        /// 销售平台的下单时间:yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("shop_order_create_time")]
        [JsonProperty("shop_order_create_time")]
        public Nullable<DateTime> ShopOrderCreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 取件人
        /// </summary>
        [XmlElement("picker")]
        [JsonProperty("picker")]
        public String Picker
        {
            get;
            set;
        }

        /// <summary>
        /// 取件人电话
        /// </summary>
        [XmlElement("picker_call")]
        [JsonProperty("picker_call")]
        public String PickerCall
        {
            get;
            set;
        }

        /// <summary>
        /// 取件人身份证
        /// </summary>
        [XmlElement("piker_id")]
        [JsonProperty("piker_id")]
        public String PikerId
        {
            get;
            set;
        }

        /// <summary>
        /// 包装类型
        /// </summary>
        [XmlElement("pack_type")]
        [JsonProperty("pack_type")]
        public String PackType
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL商品编号
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public List<String> GoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// ISV商品编号
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public List<String> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 淘宝的商品编号
        /// </summary>
        [XmlElement("shopGoodsNo")]
        [JsonProperty("shopGoodsNo")]
        public List<String> ShopGoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 申请出库数量
        /// </summary>
        [XmlElement("qty")]
        [JsonProperty("qty")]
        public List<Int64> Qty
        {
            get;
            set;
        }

        /// <summary>
        /// 商品状态（1：良品；2：残品；3：样品；4：新品）
        /// </summary>
        [XmlElement("goods_status")]
        [JsonProperty("goods_status")]
        public List<String> GoodsStatus
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.order.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("channels_seller_no", this.ChannelsSellerNo);
            paramters.Add("channels_outbound_no", this.ChannelsOutboundNo);
            paramters.Add("warehouse_no", this.WarehouseNo);
            paramters.Add("carriers_id", this.CarriersId);
            paramters.Add("expect_date", this.ExpectDate);
            paramters.Add("order_no", this.OrderNo);
            paramters.Add("shop_no", this.ShopNo);
            paramters.Add("consignee_name", this.ConsigneeName);
            paramters.Add("address_province", this.AddressProvince);
            paramters.Add("address_city", this.AddressCity);
            paramters.Add("address_county", this.AddressCounty);
            paramters.Add("address_town", this.AddressTown);
            paramters.Add("address", this.Address);
            paramters.Add("zip_code", this.ZipCode);
            paramters.Add("phone", this.Phone);
            paramters.Add("mobile", this.Mobile);
            paramters.Add("receivable", this.Receivable);
            paramters.Add("email", this.Email);
            paramters.Add("buyer_remark", this.BuyerRemark);
            paramters.Add("verify_remark", this.VerifyRemark);
            paramters.Add("return_consignee_address", this.ReturnConsigneeAddress);
            paramters.Add("return_consignee_name", this.ReturnConsigneeName);
            paramters.Add("return_consignee_phone", this.ReturnConsigneePhone);
            paramters.Add("station_no", this.StationNo);
            paramters.Add("station_name", this.StationName);
            paramters.Add("order_mark", this.OrderMark);
            paramters.Add("shop_order_source", this.ShopOrderSource);
            paramters.Add("shop_order_create_time", this.ShopOrderCreateTime);
            paramters.Add("picker", this.Picker);
            paramters.Add("picker_call", this.PickerCall);
            paramters.Add("piker_id", this.PikerId);
            paramters.Add("pack_type", this.PackType);
            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("sku_id", this.SkuId);
            paramters.Add("shopgoodsno", this.ShopGoodsNo);
            paramters.Add("qty", this.Qty);
            paramters.Add("goods_status", this.GoodsStatus);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channels_seller_no", this.ChannelsSellerNo);
            RequestValidator.ValidateRequired("channels_outbound_no", this.ChannelsOutboundNo);
            RequestValidator.ValidateRequired("warehouse_no", this.WarehouseNo);
            RequestValidator.ValidateRequired("carriers_id", this.CarriersId);
            RequestValidator.ValidateRequired("consignee_name", this.ConsigneeName);
            RequestValidator.ValidateRequired("address_province", this.AddressProvince);
            RequestValidator.ValidateRequired("address_city", this.AddressCity);
            RequestValidator.ValidateRequired("address_county", this.AddressCounty);
            RequestValidator.ValidateRequired("address_town", this.AddressTown);
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("phone", this.Phone);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("receivable", this.Receivable);
            RequestValidator.ValidateRequired("order_mark", this.OrderMark);
            RequestValidator.ValidateRequired("shop_order_source", this.ShopOrderSource);
            RequestValidator.ValidateRequired("goods_no", this.GoodsNo);
            RequestValidator.ValidateRequired("qty", this.Qty);
            RequestValidator.ValidateRequired("goods_status", this.GoodsStatus);
        }

    }
}
