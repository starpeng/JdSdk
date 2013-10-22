#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.25891 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 类目对象
    /// </summary>
    [Serializable]
    public class UnionCategoryCommision : JdObject
    {
        /// <summary>
        /// 一级类目编号
        /// </summary>
        [XmlElement("categoryLevel1Id")]
        [JsonProperty("categoryLevel1Id")]
        public Nullable<Int64> CategoryLevel1Id
        {
            get;
            set;
        }

        /// <summary>
        /// 二级类目编号
        /// </summary>
        [XmlElement("categoryLevel2Id")]
        [JsonProperty("categoryLevel2Id")]
        public Nullable<Int64> CategoryLevel2Id
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目编号
        /// </summary>
        [XmlElement("categoryLevel3Id")]
        [JsonProperty("categoryLevel3Id")]
        public Nullable<Int64> CategoryLevel3Id
        {
            get;
            set;
        }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [XmlElement("categoryLevel1Name")]
        [JsonProperty("categoryLevel1Name")]
        public String CategoryLevel1Name
        {
            get;
            set;
        }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [XmlElement("categoryLevel2Name")]
        [JsonProperty("categoryLevel2Name")]
        public String CategoryLevel2Name
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目名称
        /// </summary>
        [XmlElement("categoryLevel3Name")]
        [JsonProperty("categoryLevel3Name")]
        public String CategoryLevel3Name
        {
            get;
            set;
        }

        /// <summary>
        /// 二级类目佣金
        /// </summary>
        [XmlElement("commisionRatioLevel2")]
        [JsonProperty("commisionRatioLevel2")]
        public Nullable<Decimal> CommisionRatioLevel2
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目佣金
        /// </summary>
        [XmlElement("commisionRatio")]
        [JsonProperty("commisionRatio")]
        public Nullable<Decimal> CommisionRatio
        {
            get;
            set;
        }

    }
}
