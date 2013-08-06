#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17879 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SpacePageInfo 属性
    /// </summary>
    [Serializable]
    public class SpacePageInfo : JdObject
    {
        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        /// <summary>
        /// 页面分类是否有效 1有效 0无效
        /// </summary>
        [XmlElement("available")]
        [JsonProperty("available")]
        public Nullable<Decimal> Available
        {
            get;
            set;
        }

        /// <summary>
        /// 页面分类名称
        /// </summary>
        [XmlElement("category_name")]
        [JsonProperty("category_name")]
        public String CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// 父页面的id
        /// </summary>
        [XmlElement("parent_id")]
        [JsonProperty("parent_id")]
        public Nullable<Int64> ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// 页面对应的 URL
        /// </summary>
        [XmlElement("url")]
        [JsonProperty("url")]
        public String Url
        {
            get;
            set;
        }

        /// <summary>
        /// 页面类型 1 频道页(热门搜索词公用) 2 搜索结果页
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
        {
            get;
            set;
        }

    }
}
