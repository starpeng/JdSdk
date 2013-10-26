#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74646 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// UserInfo结构
    /// </summary>
    [Serializable]
    public class UserInfo : JdObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("fullname")]
        [JsonProperty("fullname")]
        public String Fullname
        {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("full_address")]
        [JsonProperty("full_address")]
        public String FullAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 固定电话
        /// </summary>
        [XmlElement("telephone")]
        [JsonProperty("telephone")]
        public String Telephone
        {
            get;
            set;
        }

        /// <summary>
        /// 手机
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province")]
        public String Province
        {
            get;
            set;
        }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city")]
        public String City
        {
            get;
            set;
        }

        /// <summary>
        /// 县
        /// </summary>
        [XmlElement("county")]
        [JsonProperty("county")]
        public String County
        {
            get;
            set;
        }

    }
}
