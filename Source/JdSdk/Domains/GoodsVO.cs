#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.25992 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 商品对象列表属性
    /// </summary>
    [Serializable]
    public class GoodsVO : JdObject
    {
        /// <summary>
        /// SKUID（商品编号）
        /// </summary>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goodsName")]
        [JsonProperty("goodsName")]
        public String GoodsName
        {
            get;
            set;
        }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("saleVolume")]
        [JsonProperty("saleVolume")]
        public Nullable<Decimal> SaleVolume
        {
            get;
            set;
        }

        /// <summary>
        /// 好评度
        /// </summary>
        [XmlElement("praiseDegree")]
        [JsonProperty("praiseDegree")]
        public Nullable<Decimal> PraiseDegree
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金
        /// </summary>
        [XmlElement("commisionRatio")]
        [JsonProperty("commisionRatio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

    }
}
