#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75046 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WareTemplate结构
    /// </summary>
    [Serializable]
    public class WareTemplate : JdObject
    {
        /// <summary>
        /// 版式ID
        /// </summary>
        /// <example>115 L</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <example>20032 L</example>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public Int64 VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 版式名称
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
        /// 版式内容, 列表顺序即为模板的顶部和底部，其中[0]表示顶部,[1],表示底部
        /// </summary>
        /// <example>[“顶部内容”,”底部内容”]</example>
        [XmlElement("contents")]
        [JsonProperty("contents")]
        public List<String> Contents
        {
            get;
            set;
        }

    }
}
