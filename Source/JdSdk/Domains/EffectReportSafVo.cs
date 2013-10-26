#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.26592 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// EffectReportSafVo（报表对象列表）
    /// </summary>
    [Serializable]
    public class EffectReportSafVo : JdObject
    {
        /// <summary>
        /// 联盟ID
        /// </summary>
        [XmlElement("report_unionId")]
        [JsonProperty("report_unionId")]
        public Nullable<Int64> ReportUnionId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("report_orderNo")]
        [JsonProperty("report_orderNo")]
        public Nullable<Int64> ReportOrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [XmlElement("report_commRatio")]
        [JsonProperty("report_commRatio")]
        public Nullable<Decimal> ReportCommRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金
        /// </summary>
        [XmlElement("report_commision")]
        [JsonProperty("report_commision")]
        public Nullable<Decimal> ReportCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 推广来源
        /// </summary>
        [XmlElement("report_sourceType")]
        [JsonProperty("report_sourceType")]
        public String ReportSourceType
        {
            get;
            set;
        }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("report_orderStatus")]
        [JsonProperty("report_orderStatus")]
        public Nullable<Decimal> ReportOrderStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("report_itemPrice")]
        [JsonProperty("report_itemPrice")]
        public Nullable<Decimal> ReportItemPrice
        {
            get;
            set;
        }

        /// <summary>
        /// skuid,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("report_skuId")]
        [JsonProperty("report_skuId")]
        public Nullable<Int64> ReportSkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("report_itemName")]
        [JsonProperty("report_itemName")]
        public String ReportItemName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品数量,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("report_itemNum")]
        [JsonProperty("report_itemNum")]
        public Nullable<Int64> ReportItemNum
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("report_shopName")]
        [JsonProperty("report_shopName")]
        public String ReportShopName
        {
            get;
            set;
        }

    }
}
