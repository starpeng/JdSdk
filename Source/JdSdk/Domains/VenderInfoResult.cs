#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 23:04:28.35233 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// VenderInfoResult结构
    /// </summary>
    [Serializable]
    public class VenderInfo : JdObject
    {
        /// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public Nullable<Decimal> VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家类型0：SOP1：FBP2：LBP5：SOPL
        /// </summary>
        [XmlElement("col_type")]
        [JsonProperty("col_type")]
        public Nullable<Decimal> ColType
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺编号
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Nullable<Decimal> ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        [JsonProperty("shop_name")]
        public String ShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 主营类目编号
        /// </summary>
        [XmlElement("cate_main")]
        [JsonProperty("cate_main")]
        public Nullable<Decimal> CateMain
        {
            get;
            set;
        }

    }
}
