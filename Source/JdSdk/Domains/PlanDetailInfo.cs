#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76847 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PlanDetailInfo 属性
    /// </summary>
    [Serializable]
    public class PlanDetailInfo : JdObject
    {
        /// <summary>
        /// 计划Id
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

        /// <summary>
        /// 推广计划名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 所在的广告位Id
        /// </summary>
        [XmlElement("space_id")]
        [JsonProperty("space_id")]
        public Int64 SpaceId
        {
            get;
            set;
        }

        /// <summary>
        /// 计划类型:1:频道页投放,2:搜索页投放
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 日预算
        /// </summary>
        [XmlElement("budget")]
        [JsonProperty("budget")]
        public Int64 Budget
        {
            get;
            set;
        }

        /// <summary>
        /// 计划预算总价
        /// </summary>
        [XmlElement("total_budget")]
        [JsonProperty("total_budget")]
        public Int64 TotalBudget
        {
            get;
            set;
        }

        /// <summary>
        /// 投放模式:1：cpd 按日买断，2:cpc 按点击
        /// </summary>
        [XmlElement("mode")]
        [JsonProperty("mode")]
        public Int64 Mode
        {
            get;
            set;
        }

        /// <summary>
        /// 状态:1:未提交 2:待审核    3:未通 4:申请失败 5:审核通过6:竞投中    7:暂停 8:终止 9:已结束
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 状态的名称
        /// </summary>
        [XmlElement("status_name")]
        [JsonProperty("status_name")]
        public String StatusName
        {
            get;
            set;
        }

        /// <summary>
        /// 出现竞价失败的情况，是否放弃之后排期的所有竞价，以便释放被冻结的资金，1代表同意
        /// </summary>
        [XmlElement("allow_split")]
        [JsonProperty("allow_split")]
        public Int64 AllowSplit
        {
            get;
            set;
        }

        /// <summary>
        /// 排期开始时间
        /// </summary>
        [XmlElement("schedule_start")]
        [JsonProperty("schedule_start")]
        public String ScheduleStart
        {
            get;
            set;
        }

        /// <summary>
        /// 排期结束时间
        /// </summary>
        [XmlElement("schedule_end")]
        [JsonProperty("schedule_end")]
        public String ScheduleEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 计划创建时间
        /// </summary>
        [XmlElement("insert_time")]
        [JsonProperty("insert_time")]
        public String InsertTime
        {
            get;
            set;
        }

        /// <summary>
        /// 计划更新时间
        /// </summary>
        [XmlElement("update_time")]
        [JsonProperty("update_time")]
        public String UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 计划提交时间
        /// </summary>
        [XmlElement("submit_time")]
        [JsonProperty("submit_time")]
        public String SubmitTime
        {
            get;
            set;
        }

        /// <summary>
        /// 排期
        /// </summary>
        [XmlElement("show_day")]
        [JsonProperty("show_day")]
        public List<String> ShowDay
        {
            get;
            set;
        }

        /// <summary>
        /// 播放展示方式:1:轮播,2:自定义
        /// </summary>
        [XmlElement("show_type")]
        [JsonProperty("show_type")]
        public Int64 ShowType
        {
            get;
            set;
        }

        /// <summary>
        /// 计划素材信息
        /// </summary>
        [XmlElement("material_list")]
        [JsonProperty("material_list")]
        public List<CommodityInfo> MaterialList
        {
            get;
            set;
        }

        /// <summary>
        /// 计划选择的关键词组
        /// </summary>
        [XmlElement("keyword_list")]
        [JsonProperty("keyword_list")]
        public List<SelectedKeywordInfo> KeywordList
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位页面信息
        /// </summary>
        [XmlElement("space_page_vo")]
        [JsonProperty("space_page_vo")]
        public SpacePageInfo SpacePageVo
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位信息
        /// </summary>
        [XmlElement("space_vo")]
        [JsonProperty("space_vo")]
        public SpaceInfo SpaceVo
        {
            get;
            set;
        }

        /// <summary>
        /// 当天的竞价状态：1竞价成功，2:竞价失败,3:未排期 只有&quot;status&quot;为6时，才会有bid_status_字段
        /// </summary>
        [XmlElement("bid_status")]
        [JsonProperty("bid_status")]
        public Int64 BidStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 投放广告位名称
        /// </summary>
        [XmlElement("ad_space_name")]
        [JsonProperty("ad_space_name")]
        public String AdSpaceName
        {
            get;
            set;
        }

    }
}
