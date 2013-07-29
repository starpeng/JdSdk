#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.41822 +08:00
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
    /// 搜索相关的店铺推广数据 Response
    /// </summary>
    public class JingdongUnionPromotionshopQueryResponse : JdResponse
    {
        /// <summary>
        /// 店铺推广对象列表
        /// </summary>
        [XmlElement("shop_list")]
        [JsonProperty("shop_list")]
        public List<ShopSafVo> ShopList
        {
            get;
            set;
        }

        /// <summary>
        /// 结果总个数,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Decimal> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 返回的结果是否是默认推广数据
        /// </summary>
        [XmlElement("isDefault")]
        [JsonProperty("isDefault")]
        public Nullable<Boolean> IsDefault
        {
            get;
            set;
        }

    }
}
