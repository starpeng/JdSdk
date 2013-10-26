#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.79027 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PromotionVO属性
    /// </summary>
    [Serializable]
    public class PromotionVO : JdObject
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 促销名称，字符串长度小于等于10
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 促销类型，可选值：单品促销（1），赠品促销（4），套装促销（6）
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 优惠模型，暂不支持
        /// </summary>
        [XmlElement("favor_mode")]
        [JsonProperty("favor_mode")]
        public Int64 FavorMode
        {
            get;
            set;
        }

        /// <summary>
        /// 促销范围，暂不支持
        /// </summary>
        [XmlElement("bound")]
        [JsonProperty("bound")]
        public Int64 Bound
        {
            get;
            set;
        }

        /// <summary>
        /// 促销开始时间，格式为yyyy-MM-dd    HH:mm:ss
        /// </summary>
        [XmlElement("begin_time")]
        [JsonProperty("begin_time")]
        public String BeginTime
        {
            get;
            set;
        }

        /// <summary>
        /// 促销结束时间，格式为yyyy-MM-dd    HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time")]
        public String EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 会员限制，可选值：-1、不限，56、铁牌，60、铜牌，61、银牌，62、金牌，63、钻石，88、双钻，103、三钻，104、四钻，105、五钻，90、企业会员
        /// </summary>
        [XmlElement("member")]
        [JsonProperty("member")]
        public Int64 Member
        {
            get;
            set;
        }

        /// <summary>
        /// 广告语，字符串长度小于等于50
        /// </summary>
        [XmlElement("slogan")]
        [JsonProperty("slogan")]
        public String Slogan
        {
            get;
            set;
        }

        /// <summary>
        /// 活动备注，不超过200字节
        /// </summary>
        [XmlElement("comment")]
        [JsonProperty("comment")]
        public String Comment
        {
            get;
            set;
        }

        /// <summary>
        /// 促销状态，可选值：驳回（1），未审核（2），人工审（3），审核通过（4），已生效（5），已暂停（6），强制暂停（7）
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

    }
}
