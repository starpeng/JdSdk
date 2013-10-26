#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.77247 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// KeywordVO属性
    /// </summary>
    [Serializable]
    public class KeywordVO : JdObject
    {
        /// <summary>
        /// 关键词，支持自定义的，长度不超过16个字符
        /// </summary>
        /// <example>“nike”</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词出价(单位：元)
        /// </summary>
        /// <example>1.2</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Int64 Price
        {
            get;
            set;
        }

    }
}
