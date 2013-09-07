#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26492 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// GoodSafVo（商品推广对象列表）
    /// </summary>
    [Serializable]
    public class GoodSafVo : JdObject
    {
        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("good_pk")]
        [JsonProperty("good_pk")]
        public Nullable<Decimal> GoodPk
        {
            get;
            set;
        }

        /// <summary>
        /// sku id
        /// </summary>
        [XmlElement("good_skuId")]
        [JsonProperty("good_skuId")]
        public Nullable<Int64> GoodSkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("good_shopName")]
        [JsonProperty("good_shopName")]
        public String GoodShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品标题名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("good_name")]
        [JsonProperty("good_name")]
        public String GoodName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品价格，返回结果负数不做处理
        /// </summary>
        [XmlElement("good_price")]
        [JsonProperty("good_price")]
        public Nullable<Decimal> GoodPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 好评度
        /// </summary>
        [XmlElement("good_praiseDegree")]
        [JsonProperty("good_praiseDegree")]
        public Nullable<Decimal> GoodPraiseDegree
        {
            get;
            set;
        }

        /// <summary>
        /// 目标页URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("good_targetUrl")]
        [JsonProperty("good_targetUrl")]
        public String GoodTargetUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("good_shopUrl")]
        [JsonProperty("good_shopUrl")]
        public String GoodShopUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品主图素材URL,如果为null和设置field时没有设置该属性则在结果中不显示，字段为空不做特殊处理
        /// </summary>
        [XmlElement("good_materialUrl")]
        [JsonProperty("good_materialUrl")]
        public String GoodMaterialUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [XmlElement("good_commRatio")]
        [JsonProperty("good_commRatio")]
        public Nullable<Decimal> GoodCommRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金
        /// </summary>
        [XmlElement("good_commision")]
        [JsonProperty("good_commision")]
        public Nullable<Decimal> GoodCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 30天内的交易量
        /// </summary>
        [XmlElement("good_promQuantity")]
        [JsonProperty("good_promQuantity")]
        public Nullable<Decimal> GoodPromQuantity
        {
            get;
            set;
        }

        /// <summary>
        /// 推广开始时间,yyyy-MM-ddHH:mm:ss
        /// </summary>
        [XmlElement("good_startDate")]
        [JsonProperty("good_startDate")]
        public String GoodStartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 推广结束时间,yyyy-MM-ddHH:mm:ss
        /// </summary>
        [XmlElement("good_endDate")]
        [JsonProperty("good_endDate")]
        public String GoodEndDate
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
        /// 店铺推广URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_promUrl")]
        [JsonProperty("shop_promUrl")]
        public String ShopPromUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺佣金比例
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
        /// 店铺内商品总数
        /// </summary>
        [XmlElement("shop_goodsVolume")]
        [JsonProperty("shop_goodsVolume")]
        public Nullable<Decimal> ShopGoodsVolume
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺logurl,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("shop_materialUrl")]
        [JsonProperty("shop_materialUrl")]
        public String ShopMaterialUrl
        {
            get;
            set;
        }

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
