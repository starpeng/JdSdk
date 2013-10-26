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
    /// plan_info  JSON结构
    /// </summary>
    [Serializable]
    public class PlanInfoJSON : JdObject
    {
        /// <summary>
        /// 推广名称（最多输入25个字符，建议由日期、广告位、投放内容组成，便于管理）
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
        /// 广告位id（可以由jingdong.kuaiche.zn.space.info.search接口获得）
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
        /// 出价（表示每天出价，精度保留两位小数）
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
        /// 推广计划所选择的排期（格式8位的字符型日期，可以选择的排期可以通过jingdong.kuaiche.zn.schedule.available.search接口获得）
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
        /// 出现竞价失败的情况，是否放弃之后的排期，以便释放被冻结的资金，该字段取值为1和2。（1表示放弃，2表示不放弃，默认为2）
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
        /// 取值为0和1。（1表示提交，0表示保存草稿，默认为1）
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
        /// 播放展示方式，取值为1和2。1：轮播：表示在排期内，您添加的商品每天都会轮流播放和展示。2：自定义：表示在排期内按天设置需要播放的素材
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
        /// 推广计划的素材信息。要求：1.素材必须属于同一个3级分类，比如都是属于：服饰鞋帽-男装-衬衫。2.最多只能添加5个素材3.素材所属的3级分类必须与所选择的广告位3级分类一致4.素材所属商家必须属于投放广告的商家，只能投放自己的商品。5.添加多个素材必须是不同的商品。6.添加的素材中不能包含无效的商品。如果素材播放方式为自定义，即showType等于2，则所添加的所有素材的showDays属性的并集要与所选择的排期showDay集合相等。轮播方式为轮播，即showType等于1，showDays属性可不用设置。
        /// </summary>
        [XmlElement("materialList")]
        [JsonProperty("materialList")]
        public MaterialVO MaterialList
        {
            get;
            set;
        }

        /// <summary>
        /// 投放计划id
        /// </summary>
        /// <example>123456</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
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
