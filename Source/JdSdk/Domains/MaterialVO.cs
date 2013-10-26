#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76547 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// MaterialVO 属性
    /// </summary>
    [Serializable]
    public class MaterialVO : JdObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        /// <example>1000029789”</example>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品展示显示的标题
        /// </summary>
        /// <example>“好看的裤子”</example>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 素材添加的标签
        /// </summary>
        /// <example>“1”</example>
        [XmlElement("labelId")]
        [JsonProperty("labelId")]
        public String LabelId
        {
            get;
            set;
        }

        /// <summary>
        /// 素材播放的日期（格式为8位的整形日期），如果showType为2，则不能为空；   showType为1，该值不传，表示在整个投放计划排期内进行播放。
        /// </summary>
        /// <example>[20130808,20130809]</example>
        [XmlElement("showDays")]
        [JsonProperty("showDays")]
        public List<Int32> ShowDays
        {
            get;
            set;
        }

    }
}
