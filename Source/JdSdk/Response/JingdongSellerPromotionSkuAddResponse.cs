#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:57.07183 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 添加参加促销的sku，最多支持300个SKU，当基于套装促销添加SKU时，最多可设置3个商品的SKU，并且相同商品的次序要一致；当基于赠品促销添加SKU时，赠品SKU只能是1-5个，每个赠品只能赠送1-3个，赠品的总价应低于主商品中的最小京东价。 Response
    /// </summary>
    public class JingdongSellerPromotionSkuAddResponse : JdResponse
    {
        /// <summary>
        /// 促销SKU编号列表，返回的SKU列表是都参加促销的SKU，无效的SKU会被剔除
        /// </summary>
        [XmlElement("ids")]
        [JsonProperty("ids")]
        public List<Int64> Ids
        {
            get;
            set;
        }

    }
}
