#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.41756 +08:00
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
    /// 采购订单 Request
    /// </summary>
    public class JingdongLogisticsPoAddRequest : JdRequestBase<JingdongLogisticsPoAddResponse>
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
        /// 入库单号
        /// </summary>
        [XmlElement("po_no")]
        [JsonProperty("po_no")]
        public String PoNo
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
        /// 预计送达日期(yyyy-mm-dd)
        /// </summary>
        [XmlElement("expect_date")]
        [JsonProperty("expect_date")]
        public String ExpectDate
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        [JsonProperty("supplier_name")]
        public String SupplierName
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商编码
        /// </summary>
        [XmlElement("supplier_no")]
        [JsonProperty("supplier_no")]
        public String SupplierNo
        {
            get;
            set;
        }

        /// <summary>
        /// 审批人
        /// </summary>
        [XmlElement("approver")]
        [JsonProperty("approver")]
        public String Approver
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
        /// 预期入库数量
        /// </summary>
        [XmlElement("expected_qty")]
        [JsonProperty("expected_qty")]
        public List<Int64> ExpectedQty
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
            get { return "jingdong.logistics.po.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("channels_seller_no", this.ChannelsSellerNo);
            paramters.Add("po_no", this.PoNo);
            paramters.Add("warehouse_no", this.WarehouseNo);
            paramters.Add("expect_date", this.ExpectDate);
            paramters.Add("supplier_name", this.SupplierName);
            paramters.Add("supplier_no", this.SupplierNo);
            paramters.Add("approver", this.Approver);
            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("expected_qty", this.ExpectedQty);
            paramters.Add("goods_status", this.GoodsStatus);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channels_seller_no", this.ChannelsSellerNo);
            RequestValidator.ValidateRequired("po_no", this.PoNo);
            RequestValidator.ValidateRequired("warehouse_no", this.WarehouseNo);
            RequestValidator.ValidateRequired("expect_date", this.ExpectDate);
            RequestValidator.ValidateRequired("goods_no", this.GoodsNo);
            RequestValidator.ValidateRequired("expected_qty", this.ExpectedQty);
            RequestValidator.ValidateRequired("goods_status", this.GoodsStatus);
        }

    }
}
