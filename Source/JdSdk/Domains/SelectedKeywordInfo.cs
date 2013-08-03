#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17679 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SelectedKeywordInfo属性
    /// </summary>
    [Serializable]
    public class SelectedKeywordInfo : JdObject
    {
        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Nullable<Decimal> Id
        {
            get;
            set;
        }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Decimal> PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 词组名
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 分类名字
        /// </summary>
        [XmlElement("cname")]
        [JsonProperty("cname")]
        public String Cname
        {
            get;
            set;
        }

        /// <summary>
        /// 词组id
        /// </summary>
        [XmlElement("wgroup_id")]
        [JsonProperty("wgroup_id")]
        public String WgroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id")]
        public String CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 出价
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Nullable<Decimal> Price
        {
            get;
            set;
        }

        /// <summary>
        /// 词组类型
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Decimal> Type
        {
            get;
            set;
        }

        /// <summary>
        /// 基准价
        /// </summary>
        [XmlElement("base_price")]
        [JsonProperty("base_price")]
        public Nullable<Decimal> BasePrice
        {
            get;
            set;
        }

    }
}
