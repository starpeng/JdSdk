#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78527 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// CarriersDetail属性
    /// </summary>
    [Serializable]
    public class CarriersDetail : JdObject
    {
        /// <summary>
        /// 承运商编号ID
        /// </summary>
        [XmlElement("carriers_id")]
        [JsonProperty("carriers_id")]
        public String CarriersId
        {
            get;
            set;
        }

        /// <summary>
        /// 承运商名称
        /// </summary>
        [XmlElement("carriers_name")]
        [JsonProperty("carriers_name")]
        public String CarriersName
        {
            get;
            set;
        }

        /// <summary>
        /// 承运商电话
        /// </summary>
        [XmlElement("carriers_phone")]
        [JsonProperty("carriers_phone")]
        public String CarriersPhone
        {
            get;
            set;
        }

    }
}
