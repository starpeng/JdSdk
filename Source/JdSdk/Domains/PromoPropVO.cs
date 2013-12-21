#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:57:01.23344 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PromoPropVO[]  属性
    /// </summary>
    [Serializable]
    public class PromoPropVO : JdObject
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
        /// 道具类型，可选值：京劵（4）
        /// </summary>
        /// <example>2</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 道具数值，必须为10的倍数，比如类型是京券，则表示多少元
        /// </summary>
        /// <example>20</example>
        [XmlElement("num")]
        [JsonProperty("num")]
        public Int64 Num
        {
            get;
            set;
        }

        /// <summary>
        /// 道具使用方式，可选值：奖励（2），比如类型是京券，使用方式是奖励，则表示促销会奖励用户一定的京券
        /// </summary>
        /// <example>2</example>
        [XmlElement("used_way")]
        [JsonProperty("used_way")]
        public Int64 UsedWay
        {
            get;
            set;
        }

    }
}
