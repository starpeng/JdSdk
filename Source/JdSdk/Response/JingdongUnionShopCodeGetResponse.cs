#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:06.22727 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据店铺ID查询店铺推广代码 Response
    /// </summary>
    public class JingdongUnionShopCodeGetResponse : JdResponse
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
        /// 操作结果描述
        /// </summary>
        /// <example>获取推广代码成功</example>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
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

    }
}
