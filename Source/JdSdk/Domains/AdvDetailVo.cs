#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.24391 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 简要描述 店铺推广详情返回对象
    /// </summary>
    [Serializable]
    public class AdvDetailVo : JdObject
    {
        /// <summary>
        /// 推广计划对象
        /// </summary>
        [XmlElement("promotion_plan")]
        [JsonProperty("promotion_plan")]
        public PromotionPlanVO PromotionPlan
        {
            get;
            set;
        }

        /// <summary>
        /// 推广店铺对象
        /// </summary>
        [XmlElement("promotion_shop")]
        [JsonProperty("promotion_shop")]
        public PromotionShopVO PromotionShop
        {
            get;
            set;
        }

        /// <summary>
        /// 推广商品对象
        /// </summary>
        [XmlElement("promotion_goods")]
        [JsonProperty("promotion_goods")]
        public PromotionGoodsVO PromotionGoods
        {
            get;
            set;
        }

        /// <summary>
        /// 推广活动对象
        /// </summary>
        [XmlElement("promotion_activity")]
        [JsonProperty("promotion_activity")]
        public PromotionActivityVO PromotionActivity
        {
            get;
            set;
        }

    }
}
