#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26092 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 活动对象列表属性
    /// </summary>
    [Serializable]
    public class UnionPlanActivity : JdObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activityName")]
        [JsonProperty("activityName")]
        public String ActivityName
        {
            get;
            set;
        }

        /// <summary>
        /// 活动链接
        /// </summary>
        [XmlElement("activityUrl")]
        [JsonProperty("activityUrl")]
        public String ActivityUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 活动开始时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("activityStarttime")]
        [JsonProperty("activityStarttime")]
        public Nullable<DateTime> ActivityStarttime
        {
            get;
            set;
        }

        /// <summary>
        /// 活动结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("activityEndtime")]
        [JsonProperty("activityEndtime")]
        public Nullable<DateTime> ActivityEndtime
        {
            get;
            set;
        }

        /// <summary>
        /// 活动图片列表
        /// </summary>
        [XmlElement("activityImgList")]
        [JsonProperty("activityImgList")]
        public List<UnionActivityImg> ActivityImgList
        {
            get;
            set;
        }

    }
}
