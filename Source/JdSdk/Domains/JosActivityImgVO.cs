#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.25591 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 活动列表
    /// </summary>
    [Serializable]
    public class JosActivityImgVO : JdObject
    {
        /// <summary>
        /// 活动主键
        /// </summary>
        [XmlElement("activity_pk")]
        [JsonProperty("activity_pk")]
        public Nullable<Decimal> ActivityPk
        {
            get;
            set;
        }

        /// <summary>
        /// 计划主键
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Decimal> PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        [JsonProperty("activity_name")]
        public String ActivityName
        {
            get;
            set;
        }

        /// <summary>
        /// 活动URL
        /// </summary>
        [XmlElement("activity_url")]
        [JsonProperty("activity_url")]
        public String ActivityUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 活动开始时间,yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03    00:00:00</example>
        [XmlElement("activity_starttime")]
        [JsonProperty("activity_starttime")]
        public Nullable<DateTime> ActivityStarttime
        {
            get;
            set;
        }

        /// <summary>
        /// 活动结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03    00:00:00</example>
        [XmlElement("activity_endtime")]
        [JsonProperty("activity_endtime")]
        public Nullable<DateTime> ActivityEndtime
        {
            get;
            set;
        }

        /// <summary>
        /// 类目平均佣金
        /// </summary>
        [XmlElement("average_commision")]
        [JsonProperty("average_commision")]
        public Nullable<Decimal> AverageCommision
        {
            get;
            set;
        }

        /// <summary>
        /// 图片主键
        /// </summary>
        [XmlElement("img_pk")]
        [JsonProperty("img_pk")]
        public Nullable<Decimal> ImgPk
        {
            get;
            set;
        }

        /// <summary>
        /// 图片相对url（完整url需加前缀字段img_urlprefix的值，如完整url为http://img30.360buyimg.com/ads//g15/M09/02/0C/rBEhWFHHtFsIAAAAAACVuAWYPKsAAAeAQPOChEAAJXQ933.jpg  ）
        /// </summary>
        /// <example>/g15/M09/02/0C/rBEhWFHHtFsIAAAAAACVuAWYPKsAAAeAQPOChEAAJXQ933.jpg</example>
        [XmlElement("img_url")]
        [JsonProperty("img_url")]
        public String ImgUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [XmlElement("img_width")]
        [JsonProperty("img_width")]
        public Nullable<Decimal> ImgWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 图片高度
        /// </summary>
        [XmlElement("img_height")]
        [JsonProperty("img_height")]
        public Nullable<Decimal> ImgHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 图片url前缀
        /// </summary>
        /// <example>http://img30.360buyimg.com/ads/</example>
        [XmlElement("img_urlprefix")]
        [JsonProperty("img_urlprefix")]
        public String ImgUrlprefix
        {
            get;
            set;
        }

    }
}
