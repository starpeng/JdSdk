#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.24991 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 推广商品对象
    /// </summary>
    [Serializable]
    public class PromotionGoodsVO : JdObject
    {
        /// <summary>
        /// 推广商品列表
        /// </summary>
        [XmlElement("goods_list")]
        [JsonProperty("goods_list")]
        public JosGoodsVO[] GoodsList
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_count")]
        [JsonProperty("total_count")]
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

    }
}
