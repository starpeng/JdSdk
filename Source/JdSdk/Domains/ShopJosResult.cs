#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-04-03 12:45:25.18278 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ShopJosResult结构
    /// </summary>
    [Serializable]
    public class ShopJosResult : JdObject
    {
        ﻿/// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public Nullable<Int64> VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺编号
        /// </summary>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Nullable<Int64> ShopId
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
        /// 开店时间
        /// </summary>
        [XmlElement("open_time")]
        [JsonProperty("open_time")]
        public Nullable<DateTime> OpenTime
        {
            get;
            set;
        }

        /// <summary>
        /// logo地址
        /// </summary>
        [XmlElement("logo_url")]
        [JsonProperty("logo_url")]
        public String LogoUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺简介
        /// </summary>
        [XmlElement("brief")]
        [JsonProperty("brief")]
        public String Brief
        {
            get;
            set;
        }

        /// <summary>
        /// 主营类目编号
        /// </summary>
        [XmlElement("category_main")]
        [JsonProperty("category_main")]
        public Nullable<Int64> CategoryMain
        {
            get;
            set;
        }

        /// <summary>
        /// 主营类目名称
        /// </summary>
        [XmlElement("category_main_name")]
        [JsonProperty("category_main_name")]
        public String CategoryMainName
        {
            get;
            set;
        }
    }
}
