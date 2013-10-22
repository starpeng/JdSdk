#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26392 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ActivitySafVo（联盟活动对象列表）
    /// </summary>
    [Serializable]
    public class ActivitySafVo : JdObject
    {
        /// <summary>
        /// 活动名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("activity_name")]
        [JsonProperty("activity_name")]
        public String ActivityName
        {
            get;
            set;
        }

        /// <summary>
        /// 活动推广URL,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("activity_url")]
        [JsonProperty("activity_url")]
        public String ActivityUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [XmlElement("activity_width")]
        [JsonProperty("activity_width")]
        public Nullable<Decimal> ActivityWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 图片长度
        /// </summary>
        [XmlElement("activity_height")]
        [JsonProperty("activity_height")]
        public Nullable<Decimal> ActivityHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 活动开始时间,格式yyyy-MM-ddHH:mm:s
        /// </summary>
        [XmlElement("activity_start")]
        [JsonProperty("activity_start")]
        public String ActivityStart
        {
            get;
            set;
        }

        /// <summary>
        /// 活动结束时间,格式yyyy-MM-ddHH:mm:s
        /// </summary>
        [XmlElement("activity_end")]
        [JsonProperty("activity_end")]
        public String ActivityEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺名称,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("activity_shopName")]
        [JsonProperty("activity_shopName")]
        public String ActivityShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 主营类目,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("activity_mainCategory")]
        [JsonProperty("activity_mainCategory")]
        public String ActivityMainCategory
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金比例
        /// </summary>
        [XmlElement("activity_commRatio")]
        [JsonProperty("activity_commRatio")]
        public Nullable<Decimal> ActivityCommRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("activity_pk")]
        [JsonProperty("activity_pk")]
        public String ActivityPk
        {
            get;
            set;
        }

    }
}
