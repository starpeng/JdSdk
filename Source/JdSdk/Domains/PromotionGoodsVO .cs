#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.24991 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        public List<JosGoodsVO> GoodsList
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
