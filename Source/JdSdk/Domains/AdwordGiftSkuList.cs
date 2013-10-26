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
    /// 赠品集合adwordGiftSkuList 属性
    /// </summary>
    [Serializable]
    public class AdwordGiftSkuList : JdObject
    {
        /// <summary>
        /// 赠品编号
        /// </summary>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品图片路径
        /// </summary>
        [XmlElement("imagePath")]
        [JsonProperty("imagePath")]
        public String ImagePath
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品数量
        /// </summary>
        [XmlElement("number")]
        [JsonProperty("number")]
        public Int64 Int64
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品类型，1-附件、2-普通赠品
        /// </summary>
        [XmlElement("giftType")]
        [JsonProperty("giftType")]
        public Int64 GiftType
        {
            get;
            set;
        }

    }
}
