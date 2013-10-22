#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.27792 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 券集合adwordCoupon属性
    /// </summary>
    [Serializable]
    public class AdwordCoupon : JdObject
    {
        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
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
        public Nullable<Decimal> CouponQouta
        {
            get;
            set;
        }

    }
}
