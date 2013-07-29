using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk
{
    [Serializable]
    public abstract class JdResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg
        {
            get
            {
                return String.Concat(EnErrMsg, ZhErrMsg);
            }

            internal set
            {
                this.ZhErrMsg = value;
            }
        }

        [XmlElement("zh_desc")]
        [JsonProperty("zh_desc")]
        public string ZhErrMsg { get; set; }

        /// <summary>
        /// 英文错误信息
        /// </summary>
        [XmlElement("en_desc")]
        [JsonProperty("en_desc")]
        public string EnErrMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// HTTP GET请求的URL
        /// </summary>
        public string ReqUrl { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return (!string.IsNullOrEmpty(this.ErrCode)
                    && !String.Equals(this.ErrCode, "0", StringComparison.InvariantCultureIgnoreCase)
                    )
                    || !string.IsNullOrEmpty(this.ErrMsg);
            }
        }
    }
}
