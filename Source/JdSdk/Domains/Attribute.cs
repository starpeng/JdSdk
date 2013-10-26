#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:47:856 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// attribute结构
    /// </summary>
    [Serializable]
    public class Attribute : JdObject
    {
        /// <summary>
        /// 属性id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("aid")]
        [JsonProperty("aid")]
        public Nullable<Int64> Aid
        {
            get;
            set;
        }

        /// <summary>
        /// 属性名
        /// </summary>
        /// <example>12314</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 类目id
        /// </summary>
        /// <example>1354</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 关键属性
        /// </summary>
        /// <example>false</example>
        [XmlElement("is_key_prop")]
        [JsonProperty("is_key_prop")]
        public Nullable<Boolean> IsKeyProp
        {
            get;
            set;
        }

        /// <summary>
        /// 销售属性
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_sale_prop")]
        [JsonProperty("is_sale_prop")]
        public Nullable<Boolean> IsSaleProp
        {
            get;
            set;
        }

        /// <summary>
        /// 排序(越小越靠前)
        /// </summary>
        [XmlElement("index_id")]
        [JsonProperty("index_id")]
        public Nullable<Int64> IndexId
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        /// <example>1</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

        /// <summary>
        /// 属性类型1、关键属性2、不变属性3、可变属性4、销售属性
        /// </summary>
        [XmlElement("att_type")]
        [JsonProperty("att_type")]
        public String AttType
        {
            get;
            set;
        }

        /// <summary>
        /// 输入类型(1、单选， 2、多选3、输入(最大50个字符))
        /// </summary>
        [XmlElement("input_type")]
        [JsonProperty("input_type")]
        public Nullable<Int64> InputType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否必填
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_req")]
        [JsonProperty("is_req")]
        public String IsReq
        {
            get;
            set;
        }

        /// <summary>
        /// 是否筛选
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_fet")]
        [JsonProperty("is_fet")]
        public String IsFet
        {
            get;
            set;
        }

        /// <summary>
        /// 是否导航
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_nav")]
        [JsonProperty("is_nav")]
        public String IsNav
        {
            get;
            set;
        }

    }
}
