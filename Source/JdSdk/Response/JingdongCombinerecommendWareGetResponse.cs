#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:22.92365 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 商品推荐组合 Response
    /// </summary>
    public class JingdongCombinerecommendWareGetResponse : JdResponse
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
