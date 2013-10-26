#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.46480 +08:00
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
    /// 添加促销道具, 道具类型允许组合，但不允许重复(相同类型的道具，最后一次添加有效，只适用于单品促销) Request
    /// </summary>
    public class JingdongSellerPromotionPropAddRequest : JdRequestBase<JingdongSellerPromotionPropAddResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>123456</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 道具类型，可选值：积分（2），京劵（4）
        /// </summary>
        /// <example>2</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public List<Int64> Type
        {
            get;
            set;
        }

        /// <summary>
        /// 道具数值，必须为10的倍数，比如类型是积分，则表示几个积分，类型是京券，则表示多少元
        /// </summary>
        /// <example>20</example>
        [XmlElement("num")]
        [JsonProperty("num")]
        public List<Int64> Num
        {
            get;
            set;
        }

        /// <summary>
        /// 道具使用方式，可选值：消耗（1），奖励（2），比如类型是积分，使用方式是奖励，则表示促销会奖励用户一定的积分
        /// </summary>
        /// <example>2</example>
        [XmlElement("used_way")]
        [JsonProperty("used_way")]
        public List<Int64> UsedWay
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.prop.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);
            paramters.Add("type", this.Type);
            paramters.Add("num", this.Num);
            paramters.Add("used_way", this.UsedWay);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("num", this.Num);
            RequestValidator.ValidateRequired("used_way", this.UsedWay);
        }

    }
}
