#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:03.18109 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据活动ID查询活动推广代码 Response
    /// </summary>
    public class JingdongUnionActivityCodeGetResponse : JdResponse
    {
        /// <summary>
        /// url推广代码
        /// </summary>
        [XmlElement("url_code")]
        [JsonProperty("url_code")]
        public String UrlCode
        {
            get;
            set;
        }

        /// <summary>
        /// 图片推广代码
        /// </summary>
        [XmlElement("img_code")]
        [JsonProperty("img_code")]
        public String ImgCode
        {
            get;
            set;
        }

        /// <summary>
        /// 文字链推广代码
        /// </summary>
        [XmlElement("link_code")]
        [JsonProperty("link_code")]
        public String LinkCode
        {
            get;
            set;
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <example>true,false</example>
        [XmlElement("success")]
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        /// <summary>
        /// 操作结果描述
        /// </summary>
        /// <example>操作成功!</example>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }
}
