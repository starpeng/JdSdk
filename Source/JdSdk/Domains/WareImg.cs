#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18278 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WareImg结构
    /// </summary>
    [Serializable]
    public class WareImg : JdObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("img_name")]
        [JsonProperty("img_name")]
        public String ImgName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品标题
        /// </summary>
        /// <example>京东sop衬衫1</example>
        [XmlElement("url")]
        [JsonProperty("url")]
        public String Url
        {
            get;
            set;
        }

    }
}
