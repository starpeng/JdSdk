#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:848 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OrderPrintData结构
    /// </summary>
    [Serializable]
    public class OrderPrintData : JdObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        /// <summary>
        /// 出库时间
        /// </summary>
        [XmlElement("out_bound_date")]
        [JsonProperty("out_bound_date")]
        public String OutBoundDate
        {
            get;
            set;
        }

        /// <summary>
        /// 是否送货前通知
        /// </summary>
        [XmlElement("bf_deli_good_glag")]
        [JsonProperty("bf_deli_good_glag")]
        public String BfDeliGoodGlag
        {
            get;
            set;
        }

        /// <summary>
        /// 送货时间
        /// </summary>
        [XmlElement("cod_time_name")]
        [JsonProperty("cod_time_name")]
        public String CodTimeName
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 配送中心名称
        /// </summary>
        [XmlElement("cky2_name")]
        [JsonProperty("cky2_name")]
        public String Cky2Name
        {
            get;
            set;
        }

        /// <summary>
        /// 分拣代码
        /// </summary>
        [XmlElement("sorting_code")]
        [JsonProperty("sorting_code")]
        public String SortingCode
        {
            get;
            set;
        }

        /// <summary>
        /// 订购时间
        /// </summary>
        [XmlElement("create_date")]
        [JsonProperty("create_date")]
        public String CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("should_pay")]
        [JsonProperty("should_pay")]
        public String ShouldPay
        {
            get;
            set;
        }

        /// <summary>
        /// 支付方式(中文名称)
        /// </summary>
        [XmlElement("payment_typeStr")]
        [JsonProperty("payment_typeStr")]
        public String PaymentTypeStr
        {
            get;
            set;
        }

        /// <summary>
        /// 配送站点名称
        /// </summary>
        [XmlElement("partner")]
        [JsonProperty("partner")]
        public String Partner
        {
            get;
            set;
        }

        /// <summary>
        /// 条形码(base64编码)
        /// </summary>
        [XmlElement("generade")]
        [JsonProperty("generade")]
        public String Generade
        {
            get;
            set;
        }

        /// <summary>
        /// 自提标示(base64编码)
        /// </summary>
        [XmlElement("pickUpSign")]
        [JsonProperty("pickUpSign")]
        public String PickUpSign
        {
            get;
            set;
        }

        /// <summary>
        /// 自提类型（1:地铁自提3:好邻居自提4：社区自提）
        /// </summary>
        [XmlElement("pickUpSign_type")]
        [JsonProperty("pickUpSign_type")]
        public String PickUpSignType
        {
            get;
            set;
        }

        /// <summary>
        /// 高新贵标示(base64编码)
        /// </summary>
        [XmlElement("orderLevelSign")]
        [JsonProperty("orderLevelSign")]
        public String OrderLevelSign
        {
            get;
            set;
        }

        /// <summary>
        /// 高新贵类型(2:贵重 3:高价值 4:贵重且高价值 5: 新用户)
        /// </summary>
        [XmlElement("orderLevel_Type")]
        [JsonProperty("orderLevel_Type")]
        public Int32 OrderLevelType
        {
            get;
            set;
        }

        /// <summary>
        /// 商品总数
        /// </summary>
        [XmlElement("items_count")]
        [JsonProperty("items_count")]
        public String ItemsCount
        {
            get;
            set;
        }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("order_item")]
        [JsonProperty("order_item")]
        public List<OrderItem> OrderItem
        {
            get;
            set;
        }

        /// <summary>
        /// 客户信息
        /// </summary>
        [XmlElement("Consignee")]
        [JsonProperty("Consignee")]
        public Consignee Consignee
        {
            get;
            set;
        }

    }
}
