#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75746 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ImgzoneCategory[] 属性
    /// </summary>
    [Serializable]
    public class ImgzoneCategory : JdObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("cate_id")]
        [JsonProperty("cate_id")]
        public Int64 CateId
        {
            get;
            set;
        }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("cate_name")]
        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        /// <summary>
        /// 分类层级，默认分类为0，父分类为1，子分类为2
        /// </summary>
        [XmlElement("cate_level")]
        [JsonProperty("cate_level")]
        public Int64 CateLevel
        {
            get;
            set;
        }

        /// <summary>
        /// 父分类ID
        /// </summary>
        [XmlElement("parent_cate_id")]
        [JsonProperty("parent_cate_id")]
        public Int64 ParentCateId
        {
            get;
            set;
        }

        /// <summary>
        /// 同级分类排序值，正整数，唯一但不一定连续
        /// </summary>
        [XmlElement("cate_order")]
        [JsonProperty("cate_order")]
        public Int64 CateOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }
}
