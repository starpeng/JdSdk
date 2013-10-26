#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.60952 +08:00
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
    /// 其它入库单申请 Request
    /// </summary>
    public class JingdongLogisticsOtherInstoreAddRequest : JdRequestBase<JingdongLogisticsOtherInstoreAddResponse>
    {
        /// <summary>
        /// 入库单类型
        /// </summary>
        [XmlElement("instore_type")]
        [JsonProperty("instore_type")]
        public String InstoreType
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
        /// 预计送达日期
        /// </summary>
        [XmlElement("expected_date")]
        [JsonProperty("expected_date")]
        public String ExpectedDate
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
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_no")]
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
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
        /// ISV的商品编号
        /// </summary>
        [XmlElement("isv_goods_no")]
        [JsonProperty("isv_goods_no")]
        public List<String> IsvGoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 申请入库数量
        /// </summary>
        [XmlElement("expected_qty")]
        [JsonProperty("expected_qty")]
        public List<Int64> ExpectedQty
        {
            get;
            set;
        }

        /// <summary>
        /// 商品状态
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
            get { return "jingdong.logistics.otherInstore.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("instore_type", this.InstoreType);
            paramters.Add("po_no", this.PoNo);
            paramters.Add("expected_date", this.ExpectedDate);
            paramters.Add("approver", this.Approver);
            paramters.Add("warehouse_no", this.WarehouseNo);
            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("isv_goods_no", this.IsvGoodsNo);
            paramters.Add("expected_qty", this.ExpectedQty);
            paramters.Add("goods_status", this.GoodsStatus);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("instore_type", this.InstoreType);
            RequestValidator.ValidateRequired("po_no", this.PoNo);
            RequestValidator.ValidateRequired("warehouse_no", this.WarehouseNo);
            RequestValidator.ValidateRequired("goods_no", this.GoodsNo);
            RequestValidator.ValidateRequired("isv_goods_no", this.IsvGoodsNo);
            RequestValidator.ValidateRequired("expected_qty", this.ExpectedQty);
            RequestValidator.ValidateRequired("goods_status", this.GoodsStatus);
        }

    }
}
