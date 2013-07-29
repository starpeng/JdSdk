#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.25191 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 推广活动对象
    /// </summary>
    [Serializable]
    public class PromotionActivityVO : JdObject
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlElement("activity_list")]
        [JsonProperty("activity_list")]
        public JosActivityImgVO[] ActivityList
        {
            get;
            set;
        }

        /// <summary>
        /// 查询出的总条数
        /// </summary>
        [XmlElement("total_count")]
        [JsonProperty("total_count")]
        public Nullable<Decimal> TotalCount
        {
            get;
            set;
        }

    }
}
