#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.79327 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 类目对象列表属性
    /// </summary>
    [Serializable]
    public class CategoryCommisionVO : JdObject
    {
        /// <summary>
        /// 一级类目编号
        /// </summary>
        [XmlElement("categoryLevel1Id")]
        [JsonProperty("categoryLevel1Id")]
        public Int64 CategoryLevel1Id
        {
            get;
            set;
        }

        /// <summary>
        /// 二级类目编号
        /// </summary>
        [XmlElement("categoryLevel2Id")]
        [JsonProperty("categoryLevel2Id")]
        public Int64 CategoryLevel2Id
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目编号
        /// </summary>
        [XmlElement("categoryLevel3Id")]
        [JsonProperty("categoryLevel3Id")]
        public Int64 CategoryLevel3Id
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
        /// 二级类目佣金比例，输入计划编号为空时没有此值
        /// </summary>
        [XmlElement("commisionRatioLevel2")]
        [JsonProperty("commisionRatioLevel2")]
        public Int64 CommisionRatioLevel2
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目佣金 比例，输入计划编号为空时没有此值
        /// </summary>
        [XmlElement("commisionRatio")]
        [JsonProperty("commisionRatio")]
        public Int64 CommisionRatio
        {
            get;
            set;
        }

        /// <summary>
        /// 起始佣金比例范围
        /// </summary>
        [XmlElement("priceStart")]
        [JsonProperty("priceStart")]
        public Int64 PriceStart
        {
            get;
            set;
        }

        /// <summary>
        /// 终止佣金比例范围
        /// </summary>
        [XmlElement("priceEnd")]
        [JsonProperty("priceEnd")]
        public Int64 PriceEnd
        {
            get;
            set;
        }

    }
}
