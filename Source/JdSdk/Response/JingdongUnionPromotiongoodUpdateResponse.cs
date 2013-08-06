#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.01420 +08:00
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
    /// 获得指定SKU ID的商品的推广数据 Response
    /// </summary>
    public class JingdongUnionPromotiongoodUpdateResponse : JdResponse
    {
        /// <summary>
        /// 商品推广的对象列表
        /// </summary>
        [XmlElement("good_list")]
        [JsonProperty("good_list")]
        public List<GoodSafVo> GoodList
        {
            get;
            set;
        }

        /// <summary>
        /// 总个数
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 返回结果是否是默认的推广数据
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
