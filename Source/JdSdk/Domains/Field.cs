#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2012-06-21 10:49:00:318 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Field对象结构
    /// </summary>
    [Serializable]
    public class Field : JdObject
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("key")]
        [JsonProperty("key")]
        public String Key
        {
            get;
            set;
        }

        /// <summary>
        /// 返回字段选择,每个字段以逗号分隔
        /// </summary>
        [XmlElement("value")]
        [JsonProperty("value")]
        public String Value
        {
            get;
            set;
        }

    }
}
