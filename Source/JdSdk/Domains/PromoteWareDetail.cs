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
    /// PromoteWareDetail
    /// </summary>
    [Serializable]
    public class PromoteWareDetail : JdObject
    {
        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("ware")]
        [JsonProperty("ware")]
        public Ware Ware
        {
            get;
            set;
        }

        /// <summary>
        /// 商品推广URL如http://show.union.360buy.com/JdShow/index.html?unionId=0&amp;wid=663186
        /// </summary>
        [XmlElement("click_url")]
        [JsonProperty("click_url")]
        public String ClickUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 商品所在的店铺的推广URL，暂不返回
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
