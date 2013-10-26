#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76647 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// KeywordGroup属性
    /// </summary>
    [Serializable]
    public class KeywordGroup : JdObject
    {
        /// <summary>
        /// 词组id
        /// </summary>
        [XmlElement("wgroup_id")]
        [JsonProperty("wgroup_id")]
        public Int64 WgroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 词组名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 分类id
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id")]
        public String CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 搜索量
        /// </summary>
        [XmlElement("search_num")]
        [JsonProperty("search_num")]
        public Int64 SearchNum
        {
            get;
            set;
        }

        /// <summary>
        /// 基准价格
        /// </summary>
        [XmlElement("base_price")]
        [JsonProperty("base_price")]
        public Int64 BasePrice
        {
            get;
            set;
        }

        /// <summary>
        /// 历史平均出价 暂时无法获取，预计两周后上线
        /// </summary>
        [XmlElement("avg_price")]
        [JsonProperty("avg_price")]
        public Int64 AvgPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 历史成交价格  暂时无法获取，预计两周后上线
        /// </summary>
        [XmlElement("avg_deal_price")]
        [JsonProperty("avg_deal_price")]
        public Int64 AvgDealPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 词组类型 品牌关键词组、品类
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

    }
}
