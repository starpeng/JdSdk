#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.17578 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ShopCategory结构
    /// </summary>
    [Serializable]
    public class ShopCategory : JdObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 父类目编号
        /// </summary>
        [XmlElement("parent_id")]
        [JsonProperty("parent_id")]
        public Nullable<Int64> ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 类目是否为父类目，即：该类目是否还有子类目
        /// </summary>
        [XmlElement("is_parent")]
        [JsonProperty("is_parent")]
        public Nullable<Boolean> IsParent
        {
            get;
            set;
        }

        /// <summary>
        /// 是否展开
        /// </summary>
        [XmlElement("is_open")]
        [JsonProperty("is_open")]
        public Nullable<Boolean> IsOpen
        {
            get;
            set;
        }

    }
}
