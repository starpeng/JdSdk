#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.26378 +08:00
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
    /// 分页查询促销列表，目前可以根据类型、状态进行查询，也支持组合查询 Response
    /// </summary>
    public class JingdongSellerPromotionListResponse : JdResponse
    {
        /// <summary>
        /// 促销总数量
        /// </summary>
        /// <example>15</example>
        [XmlElement("total_count")]
        [JsonProperty("total_count")]
        public Int64 TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 促销列表，促销列表信息比较简单，目前包含促销编号、名称、时间、类型、状态字段。
        /// </summary>
        [XmlElement("promotion_v_o_s")]
        [JsonProperty("promotion_v_o_s")]
        public List<PromotionVO> PromotionVOS
        {
            get;
            set;
        }

    }
}
