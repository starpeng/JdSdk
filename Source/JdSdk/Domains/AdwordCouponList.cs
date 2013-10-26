#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.80127 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 券集合adwordCouponList属性
    /// </summary>
    [Serializable]
    public class AdwordCouponList : JdObject
    {
        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 限品类不为空，非限品类为空
        /// </summary>
        [XmlElement("key")]
        [JsonProperty("key")]
        public String Key
        {
            get;
            set;
        }

        /// <summary>
        /// 券值大小
        /// </summary>
        [XmlElement("couponQouta")]
        [JsonProperty("couponQouta")]
        public Int64 CouponQouta
        {
            get;
            set;
        }

    }
}
