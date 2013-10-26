#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:47:852 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Promotion结构
    /// </summary>
    [Serializable]
    public class Promotion : JdObject
    {
        /// <summary>
        /// 促销编号号
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        /// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 促销名称
        /// </summary>
        [XmlElement("promo_name")]
        [JsonProperty("promo_name")]
        public String PromoName
        {
            get;
            set;
        }

        /// <summary>
        /// 促销类型(中文)参见促销类型值
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        /// 会员级别(中文)参见会员级别值
        /// </summary>
        [XmlElement("level_member")]
        [JsonProperty("level_member")]
        public String LevelMember
        {
            get;
            set;
        }

        /// <summary>
        /// 促销开始时间
        /// </summary>
        [XmlElement("time_begin")]
        [JsonProperty("time_begin")]
        public String TimeBegin
        {
            get;
            set;
        }

        /// <summary>
        /// 促销结束时间
        /// </summary>
        [XmlElement("time_end")]
        [JsonProperty("time_end")]
        public String TimeEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 促销状态(中文)参见促销状态值
        /// </summary>
        [XmlElement("evt_status")]
        [JsonProperty("evt_status")]
        public String EvtStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 同步状态(中文)
        /// </summary>
        [XmlElement("synch_status")]
        [JsonProperty("synch_status")]
        public String SynchStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 审核状态(中文)参见参见审核状态值
        /// </summary>
        [XmlElement("check_status")]
        [JsonProperty("check_status")]
        public String CheckStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 商品信息对象
        /// </summary>
        [XmlElement("promotion_product_list")]
        [JsonProperty("promotion_product_list")]
        public List<PromotionProduct> PromotionProductList
        {
            get;
            set;
        }

    }
}
