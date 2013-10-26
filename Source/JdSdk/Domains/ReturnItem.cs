#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74346 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ReturnItem结构
    /// </summary>
    [Serializable]
    public class ReturnItem : JdObject
    {
        /// <summary>
        /// 退货物品信息记录ID
        /// </summary>
        [XmlElement("return_item_id")]
        [JsonProperty("return_item_id")]
        public String ReturnItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 备件条码
        /// </summary>
        [XmlElement("attachment_code")]
        [JsonProperty("attachment_code")]
        public String AttachmentCode
        {
            get;
            set;
        }

        /// <summary>
        /// 京东的SKU
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU名称
        /// </summary>
        [XmlElement("sku_name")]
        [JsonProperty("sku_name")]
        public String SkuName
        {
            get;
            set;
        }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的单价
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        /// <summary>
        /// 退货类型: 售后RETURNED、拒收REJECTED、大库入FROMWAREHOUSE
        /// </summary>
        [XmlElement("return_type")]
        [JsonProperty("return_type")]
        public String ReturnType
        {
            get;
            set;
        }

        /// <summary>
        /// 退货原因
        /// </summary>
        [XmlElement("return_reason")]
        [JsonProperty("return_reason")]
        public String ReturnReason
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("modifid_time")]
        [JsonProperty("modifid_time")]
        public String ModifidTime
        {
            get;
            set;
        }

    }
}
