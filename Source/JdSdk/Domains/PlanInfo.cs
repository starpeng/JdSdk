#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.77727 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// plan_info  JSON结构
    /// </summary>
    [Serializable]
    public class PlanInfo : JdObject
    {
        /// <summary>
        /// 投放计划名称
        /// </summary>
        /// <example>“我的投放”</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位id
        /// </summary>
        /// <example>200</example>
        [XmlElement("spaceId")]
        [JsonProperty("spaceId")]
        public Int64 SpaceId
        {
            get;
            set;
        }

        /// <summary>
        /// 日预算
        /// </summary>
        /// <example>120.50</example>
        [XmlElement("budget")]
        [JsonProperty("budget")]
        public Int64 Budget
        {
            get;
            set;
        }

        /// <summary>
        /// 计划排期（格式为8位的字符型日期）
        /// </summary>
        /// <example>[“20130803”,”20130809”]</example>
        [XmlElement("showDay")]
        [JsonProperty("showDay")]
        public List<String> ShowDay
        {
            get;
            set;
        }

        /// <summary>
        /// 出现竞价失败的情况，是否放弃之后排期的所有竞价，以便释放被冻结的资金（1表示放弃，2表示不放弃，默认为2）
        /// </summary>
        /// <example>2</example>
        [XmlElement("allowSplit")]
        [JsonProperty("allowSplit")]
        public Int64 AllowSplit
        {
            get;
            set;
        }

        /// <summary>
        /// 1表示提交，0表示保存草稿，默认为1
        /// </summary>
        /// <example>1</example>
        [XmlElement("save")]
        [JsonProperty("save")]
        public Int64 Save
        {
            get;
            set;
        }

        /// <summary>
        /// '播放展示方式,1:轮播（选择的所有素材轮流播放），2：自定义'（按日期设置选择的素材播放）
        /// </summary>
        /// <example>1</example>
        [XmlElement("showType")]
        [JsonProperty("showType")]
        public Int64 ShowType
        {
            get;
            set;
        }

        /// <summary>
        /// 投放计划的素材信息
        /// </summary>
        [XmlElement("materialList")]
        [JsonProperty("materialList")]
        public List<MaterialVO> MaterialList
        {
            get;
            set;
        }

        /// <summary>
        /// 投放计划选择的关键词组信息
        /// </summary>
        [XmlElement("keywordList")]
        [JsonProperty("keywordList")]
        public List<String> KeywordList
        {
            get;
            set;
        }

    }
}
