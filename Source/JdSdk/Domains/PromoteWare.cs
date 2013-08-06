#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18178 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PromoteWare
    /// </summary>
    [Serializable]
    public class PromoteWare : JdObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        /// <example>305664</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <example>热敏传真机</example>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <example>839.00</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Nullable<Decimal> Price
        {
            get;
            set;
        }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("pic_url")]
        [JsonProperty("pic_url")]
        public String PicUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金，暂不返回
        /// </summary>
        [XmlElement("commission_fee")]
        [JsonProperty("commission_fee")]
        public String CommissionFee
        {
            get;
            set;
        }

        /// <summary>
        /// 商品推广URL ，例如：http://click.union.360buy.com/JdClick/?unionId=0&amp;to=http://www.360buy.com/products/5275-5337-6121.html
        /// </summary>
        [XmlElement("click_url")]
        [JsonProperty("click_url")]
        public String ClickUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品所在的店铺的推广URL,  暂不返回
        /// </summary>
        [XmlElement("shop_click_url")]
        [JsonProperty("shop_click_url")]
        public String ShopClickUrl
        {
            get;
            set;
        }

    }
}
