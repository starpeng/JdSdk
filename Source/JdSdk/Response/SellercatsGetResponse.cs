#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:17.41034 +08:00
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
    /// 根据商家编号获取店内分类 Response
    /// </summary>
    public class SellercatsGetResponse : JdResponse
    {
        /// <summary>
        /// 店铺类目信息
        /// </summary>
        [XmlElement("shopCats")]
        [JsonProperty("shopCats")]
        public List<ShopCategory> ShopCats
        {
            get;
            set;
        }

    }
}
