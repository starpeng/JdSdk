#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.88386 +08:00
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
    /// 通过api 根据商品Id，销售属性值Id增加图片 Response
    /// </summary>
    public class WarePropimgAddResponse : JdResponse
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值Id(颜色值Id)
        /// </summary>
        /// <example>12345</example>
        [XmlElement("attribute_value_id")]
        [JsonProperty("attribute_value_id")]
        public String AttributeValueId
        {
            get;
            set;
        }

        /// <summary>
        /// 属性图片的id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

    }
}
