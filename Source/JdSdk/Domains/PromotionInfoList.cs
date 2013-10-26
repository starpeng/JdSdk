#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.80127 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// promotionInfoList属性
    /// </summary>
    [Serializable]
    public class PromotionInfoList : JdObject
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        [XmlElement("promoId")]
        [JsonProperty("promoId")]
        public String PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 促销类型
        /// </summary>
        [XmlElement("promoType")]
        [JsonProperty("promoType")]
        public Int64 PromoType
        {
            get;
            set;
        }

        /// <summary>
        /// 单品扩展类型
        /// </summary>
        [XmlElement("extType")]
        [JsonProperty("extType")]
        public Int64 ExtType
        {
            get;
            set;
        }

        /// <summary>
        /// 满返满赠扩展类型
        /// </summary>
        [XmlElement("fullRefundType")]
        [JsonProperty("fullRefundType")]
        public Int64 FullRefundType
        {
            get;
            set;
        }

        /// <summary>
        /// 用户级别
        /// </summary>
        [XmlElement("userLevel")]
        [JsonProperty("userLevel")]
        public Int64 UserLevel
        {
            get;
            set;
        }

        /// <summary>
        /// 最小购买数
        /// </summary>
        [XmlElement("minNum")]
        [JsonProperty("minNum")]
        public Int64 MinNum
        {
            get;
            set;
        }

        /// <summary>
        /// 最大购买数
        /// </summary>
        [XmlElement("maxNum")]
        [JsonProperty("maxNum")]
        public Int64 MaxNum
        {
            get;
            set;
        }

        /// <summary>
        /// 是否为限购，4是限购
        /// </summary>
        [XmlElement("limitUserType")]
        [JsonProperty("limitUserType")]
        public Int64 LimitUserType
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        /// <summary>
        /// 直降直降
        /// </summary>
        [XmlElement("discount")]
        [JsonProperty("discount")]
        public String Discount
        {
            get;
            set;
        }

        /// <summary>
        /// 返现
        /// </summary>
        [XmlElement("reward")]
        [JsonProperty("reward")]
        public String Reward
        {
            get;
            set;
        }

        /// <summary>
        /// 加价购所加的钱
        /// </summary>
        [XmlElement("addMoney")]
        [JsonProperty("addMoney")]
        public String AddMoney
        {
            get;
            set;
        }

        /// <summary>
        /// 参加满返满赠所需的金额
        /// </summary>
        [XmlElement("needMondey")]
        [JsonProperty("needMondey")]
        public String NeedMondey
        {
            get;
            set;
        }

        /// <summary>
        /// 参加满返满赠所需的商品数量
        /// </summary>
        [XmlElement("needNum")]
        [JsonProperty("needNum")]
        public Int64 NeedNum
        {
            get;
            set;
        }

        /// <summary>
        /// 参加满返满赠减N件最低价的阶梯数
        /// </summary>
        [XmlElement("deliverNum")]
        [JsonProperty("deliverNum")]
        public Int64 DeliverNum
        {
            get;
            set;
        }

        /// <summary>
        /// 每满返的封顶价
        /// </summary>
        [XmlElement("topMoney")]
        [JsonProperty("topMoney")]
        public String TopMoney
        {
            get;
            set;
        }

        /// <summary>
        /// 参加满返促销的返现百分比
        /// </summary>
        [XmlElement("percent")]
        [JsonProperty("percent")]
        public Int64 Percent
        {
            get;
            set;
        }

        /// <summary>
        /// 折扣
        /// </summary>
        [XmlElement("rebate")]
        [JsonProperty("rebate")]
        public Int64 Rebate
        {
            get;
            set;
        }

        /// <summary>
        /// 是满赠还是满减促销
        /// </summary>
        [XmlElement("haveFullRefundGifts")]
        [JsonProperty("haveFullRefundGifts")]
        public Nullable<Boolean> HaveFullRefundGifts
        {
            get;
            set;
        }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("score")]
        [JsonProperty("score")]
        public Int64 Score
        {
            get;
            set;
        }

        /// <summary>
        /// 促销结束时间
        /// </summary>
        [XmlElement("promoEndTime")]
        [JsonProperty("promoEndTime")]
        public Int64 PromoEndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 券集合
        /// </summary>
        [XmlElement("adwordCouponList")]
        [JsonProperty("adwordCouponList")]
        public List<AdwordCoupon> AdwordCouponList
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品集合
        /// </summary>
        [XmlElement("adwordGiftSkuList")]
        [JsonProperty("adwordGiftSkuList")]
        public List<AdwordGiftSku> AdwordGiftSkuList
        {
            get;
            set;
        }

    }
}
