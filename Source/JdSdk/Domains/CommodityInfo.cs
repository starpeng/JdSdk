#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76947 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// CommodityInfo属性
    /// </summary>
    [Serializable]
    public class CommodityInfo : JdObject
    {
        /// <summary>
        /// 素材SKUID
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 素材标题
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 原标题
        /// </summary>
        [XmlElement("original_title")]
        [JsonProperty("original_title")]
        public String OriginalTitle
        {
            get;
            set;
        }

        /// <summary>
        /// URL第一张是主图
        /// </summary>
        [XmlElement("material_url")]
        [JsonProperty("material_url")]
        public List<String> MaterialUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 目标页
        /// </summary>
        [XmlElement("target_url")]
        [JsonProperty("target_url")]
        public String TargetUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain")]
        [JsonProperty("domain")]
        public String Domain
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的价格
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Int64 Price
        {
            get;
            set;
        }

        /// <summary>
        /// 三级菜单名称
        /// </summary>
        [XmlElement("menu_name")]
        [JsonProperty("menu_name")]
        public String MenuName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品路径
        /// </summary>
        [XmlElement("goods_path")]
        [JsonProperty("goods_path")]
        public List<String> GoodsPath
        {
            get;
            set;
        }

        /// <summary>
        /// 所属终极栏目分类
        /// </summary>
        [XmlElement("page_category_id")]
        [JsonProperty("page_category_id")]
        public Int64 PageCategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 所属栏目分类 格式 一级Id_二级Id_三级Id
        /// </summary>
        [XmlElement("page_category_id_all")]
        [JsonProperty("page_category_id_all")]
        public String PageCategoryIdAll
        {
            get;
            set;
        }

        /// <summary>
        /// 同组素材信息
        /// </summary>
        [XmlElement("material_spu")]
        [JsonProperty("material_spu")]
        public List<CommoditySpu> MaterialSpu
        {
            get;
            set;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

        /// <summary>
        /// 计划ID
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Int64 PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 广告位ID
        /// </summary>
        [XmlElement("space_id")]
        [JsonProperty("space_id")]
        public Int64 SpaceId
        {
            get;
            set;
        }

        /// <summary>
        /// 审核状态 1.未审核2.未通过3.通过'
        /// </summary>
        [XmlElement("review_status")]
        [JsonProperty("review_status")]
        public Int64 ReviewStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 审核备注
        /// </summary>
        [XmlElement("review_mark")]
        [JsonProperty("review_mark")]
        public String ReviewMark
        {
            get;
            set;
        }

        /// <summary>
        /// 素材对应的播放日期
        /// </summary>
        [XmlElement("show_days")]
        [JsonProperty("show_days")]
        public List<Int32> ShowDays
        {
            get;
            set;
        }

    }
}
