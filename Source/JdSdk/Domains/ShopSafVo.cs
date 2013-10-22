#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26692 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ShopSafVo（店铺推广对象列表）
    /// </summary>
    [Serializable]
    public class ShopSafVo : JdObject
    {
        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("shop_pk")]
        [JsonProperty("shop_pk")]
        public Nullable<Decimal> ShopPk
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 推广URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_promotionUrl")]
        [JsonProperty("shop_promotionUrl")]
        public String ShopPromotionUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [XmlElement("shop_commRatio")]
        [JsonProperty("shop_commRatio")]
        public Nullable<Decimal> ShopCommRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 好评度
        /// </summary>
        [XmlElement("shop_praiseDegree")]
        [JsonProperty("shop_praiseDegree")]
        public Nullable<Decimal> ShopPraiseDegree
        {
            get;
            set;
        }

        /// <summary>
        /// 累计推广量
        /// </summary>
        [XmlElement("shop_promQuantity")]
        [JsonProperty("shop_promQuantity")]
        public Nullable<Decimal> ShopPromQuantity
        {
            get;
            set;
        }

        /// <summary>
        /// 商品总量
        /// </summary>
        [XmlElement("shop_goodsVolume")]
        [JsonProperty("shop_goodsVolume")]
        public Nullable<Decimal> ShopGoodsVolume
        {
            get;
            set;
        }

        /// <summary>
        /// 主图URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_materialUrl")]
        [JsonProperty("shop_materialUrl")]
        public String ShopMaterialUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 主营类目,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_mainCategories")]
        [JsonProperty("shop_mainCategories")]
        public String ShopMainCategories
        {
            get;
            set;
        }

    }
}
