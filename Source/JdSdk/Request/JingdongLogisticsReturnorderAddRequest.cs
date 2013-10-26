#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.82159 +08:00
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
    /// 退货入库单申请 Request
    /// </summary>
    public class JingdongLogisticsReturnorderAddRequest : JdRequestBase<JingdongLogisticsReturnorderAddResponse>
    {
        /// <summary>
        /// ISV商家编号
        /// </summary>
        /// <example>EDB0001</example>
        [XmlElement("seller_no")]
        [JsonProperty("seller_no")]
        public String SellerNo
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL库房编号
        /// </summary>
        /// <example>BJ000000001</example>
        [XmlElement("warehouse_no")]
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        /// <summary>
        /// ISV入库单号
        /// </summary>
        /// <example>EDBI001111</example>
        [XmlElement("inbound_no")]
        [JsonProperty("inbound_no")]
        public String InboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL出库单号
        /// </summary>
        /// <example>JOSL1000012</example>
        [XmlElement("josl_outbound_no")]
        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL预计送达日期
        /// </summary>
        /// <example>2013-06-18 11:00:59</example>
        [XmlElement("expected_date")]
        [JsonProperty("expected_date")]
        public DateTime ExpectedDate
        {
            get;
            set;
        }

        /// <summary>
        /// ISV来源
        /// </summary>
        /// <example>http://www.centaur.cn/</example>
        [XmlElement("isv_source")]
        [JsonProperty("isv_source")]
        public String IsvSource
        {
            get;
            set;
        }

        /// <summary>
        /// 审批人
        /// </summary>
        /// <example>张三</example>
        [XmlElement("approver")]
        [JsonProperty("approver")]
        public String Approver
        {
            get;
            set;
        }

        /// <summary>
        /// JOSL商品编码
        /// </summary>
        /// <example>JGNO1000000052</example>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public List<String> GoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 入库数量
        /// </summary>
        /// <example>10</example>
        [XmlElement("expected_qty")]
        [JsonProperty("expected_qty")]
        public List<Int64> ExpectedQty
        {
            get;
            set;
        }

        /// <summary>
        /// 库存等级标识代码
        /// </summary>
        /// <example>1良品，2残品，3样品，4新品</example>
        [XmlElement("stock_mark")]
        [JsonProperty("stock_mark")]
        public List<String> StockMark
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.returnorder.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("seller_no", this.SellerNo);
            paramters.Add("warehouse_no", this.WarehouseNo);
            paramters.Add("inbound_no", this.InboundNo);
            paramters.Add("josl_outbound_no", this.JoslOutboundNo);
            paramters.Add("expected_date", this.ExpectedDate);
            paramters.Add("isv_source", this.IsvSource);
            paramters.Add("approver", this.Approver);
            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("expected_qty", this.ExpectedQty);
            paramters.Add("stock_mark", this.StockMark);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("warehouse_no", this.WarehouseNo);
            RequestValidator.ValidateRequired("inbound_no", this.InboundNo);
            RequestValidator.ValidateRequired("josl_outbound_no", this.JoslOutboundNo);
            RequestValidator.ValidateRequired("expected_date", this.ExpectedDate);
            RequestValidator.ValidateRequired("approver", this.Approver);
            RequestValidator.ValidateRequired("goods_no", this.GoodsNo);
            RequestValidator.ValidateRequired("expected_qty", this.ExpectedQty);
            RequestValidator.ValidateRequired("stock_mark", this.StockMark);
        }

    }
}
