#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.93471 +08:00
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
    /// 购买此商品用户最终购买的商品 Response
    /// </summary>
    public class JingdongUserbrowsebuyrecommendWareGetResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("favoriteWares")]
        [JsonProperty("favoriteWares")]
        public List<FavoriteWare> FavoriteWares
        {
            get;
            set;
        }

    }
}
