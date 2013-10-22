#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.81319 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询相关的商品推广数据（查询若无结果或者没输入查询条件则返回默认商品推广数据） Response
    /// </summary>
    public class JingdongUnionPromotiongoodQueryResponse : JdResponse
    {
        /// <summary>
        /// 商品推广对象列表
        /// </summary>
        [XmlElement("good_list")]
        [JsonProperty("good_list")]
        public List<GoodSafVo> GoodList
        {
            get;
            set;
        }

        /// <summary>
        /// 总个数,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 返回的结果是否是默认的推广数据
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
