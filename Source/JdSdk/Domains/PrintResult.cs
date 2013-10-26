#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:47:859 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PrintResult结构
    /// </summary>
    [Serializable]
    public class PrintResult : JdObject
    {
        /// <summary>
        /// html内容(base64编码，调用方需要将其进行转码)(sdk 已经将base64编码转成html内容)
        /// </summary>
        [XmlElement("html_content")]
        [JsonProperty("html_content")]
        public String HtmlContent
        {
            get;
            set;
        }

        /// <summary>
        /// 打印订单的条形码(base64编码,调用方需要将内容拷贝拷贝到html中条形码 img的src里，即 src="base64编码的条形码")(sop商家返回的为空)
        /// </summary>
        [XmlElement("image_data")]
        [JsonProperty("image_data")]
        public String ImageData
        {
            get;
            set;
        }

    }
}
