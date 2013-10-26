#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:04.61118 +08:00
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
    /// 查询相关的活动推广数据 Response
    /// </summary>
    public class JingdongUnionPromotionactivityQueryResponse : JdResponse
    {
        /// <summary>
        /// 联盟活动对象列表
        /// </summary>
        [XmlElement("activity_list")]
        [JsonProperty("activity_list")]
        public List<ActivitySafVo> ActivityList
        {
            get;
            set;
        }

        /// <summary>
        /// 结果总个数,如果为null和设置field时没有设置该属性则在结果中不显示
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
