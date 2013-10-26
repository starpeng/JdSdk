#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:53.83265 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 商品资料修改（此方法中,不修改的字段请保证添入null或者'null'等,请勿填写为'',可能会引起修改错误） Request
    /// </summary>
    public class JingdongLogisticsSkuUpdateRequest : JdRequestBase<JingdongLogisticsSkuUpdateResponse>
    {
        /// <summary>
        /// JOSL商品唯一标识
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public String GoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 条码(外部系统商品唯一标识)
        /// </summary>
        [XmlElement("bar_code")]
        [JsonProperty("bar_code")]
        public String BarCode
        {
            get;
            set;
        }

        /// <summary>
        /// 商品编号(外部数据)
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 商品简称
        /// </summary>
        [XmlElement("goods_abbreviation")]
        [JsonProperty("goods_abbreviation")]
        public String GoodsAbbreviation
        {
            get;
            set;
        }

        /// <summary>
        /// 商品分类编号(外部数据)
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id")]
        public String CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品分类名称
        /// </summary>
        [XmlElement("category_name")]
        [JsonProperty("category_name")]
        public String CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// 品牌编号
        /// </summary>
        [XmlElement("brand_no")]
        [JsonProperty("brand_no")]
        public String BrandNo
        {
            get;
            set;
        }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        [JsonProperty("brand_name")]
        public String BrandName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("format")]
        [JsonProperty("format")]
        public String Format
        {
            get;
            set;
        }

        /// <summary>
        /// 商品颜色
        /// </summary>
        [XmlElement("color")]
        [JsonProperty("color")]
        public String Color
        {
            get;
            set;
        }

        /// <summary>
        /// 商品尺码
        /// </summary>
        [XmlElement("size")]
        [JsonProperty("size")]
        public String Size
        {
            get;
            set;
        }

        /// <summary>
        /// 商品毛重量
        /// </summary>
        [XmlElement("gross_weight")]
        [JsonProperty("gross_weight")]
        public String GrossWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 商品净重量
        /// </summary>
        [XmlElement("net_weight")]
        [JsonProperty("net_weight")]
        public String NetWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 商品件型(分为9种件型用于计费使用请慎重考虑.)
        /// </summary>
        [XmlElement("size_definition")]
        [JsonProperty("size_definition")]
        public String SizeDefinition
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("suppliers_name")]
        [JsonProperty("suppliers_name")]
        public String SuppliersName
        {
            get;
            set;
        }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [XmlElement("manufacturer")]
        [JsonProperty("manufacturer")]
        public String Manufacturer
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商编码
        /// </summary>
        [XmlElement("suppliers_no")]
        [JsonProperty("suppliers_no")]
        public String SuppliersNo
        {
            get;
            set;
        }

        /// <summary>
        /// 产地
        /// </summary>
        [XmlElement("product_area")]
        [JsonProperty("product_area")]
        public String ProductArea
        {
            get;
            set;
        }

        /// <summary>
        /// 长
        /// </summary>
        [XmlElement("length")]
        [JsonProperty("length")]
        public Int64 Length
        {
            get;
            set;
        }

        /// <summary>
        /// 宽
        /// </summary>
        [XmlElement("width")]
        [JsonProperty("width")]
        public Int64 Width
        {
            get;
            set;
        }

        /// <summary>
        /// 高
        /// </summary>
        [XmlElement("height")]
        [JsonProperty("height")]
        public Int64 Height
        {
            get;
            set;
        }

        /// <summary>
        /// 体积
        /// </summary>
        [XmlElement("volume")]
        [JsonProperty("volume")]
        public Int64 Volume
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保质期管理(1为保质期管理,0为非保质期管理,不强制加入.)
        /// </summary>
        [XmlElement("is_safe")]
        [JsonProperty("is_safe")]
        public Int64 IsSafe
        {
            get;
            set;
        }

        /// <summary>
        /// 保质期天数(非保质期可不填写,保质期商品请填写保质期为多少天如30天请填写30.)
        /// </summary>
        [XmlElement("safe_date")]
        [JsonProperty("safe_date")]
        public String SafeDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.sku.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("bar_code", this.BarCode);
            paramters.Add("sku_id", this.SkuId);
            paramters.Add("name", this.Name);
            paramters.Add("goods_abbreviation", this.GoodsAbbreviation);
            paramters.Add("category_id", this.CategoryId);
            paramters.Add("category_name", this.CategoryName);
            paramters.Add("brand_no", this.BrandNo);
            paramters.Add("brand_name", this.BrandName);
            paramters.Add("format", this.Format);
            paramters.Add("color", this.Color);
            paramters.Add("size", this.Size);
            paramters.Add("gross_weight", this.GrossWeight);
            paramters.Add("net_weight", this.NetWeight);
            paramters.Add("size_definition", this.SizeDefinition);
            paramters.Add("suppliers_name", this.SuppliersName);
            paramters.Add("manufacturer", this.Manufacturer);
            paramters.Add("suppliers_no", this.SuppliersNo);
            paramters.Add("product_area", this.ProductArea);
            paramters.Add("length", this.Length);
            paramters.Add("width", this.Width);
            paramters.Add("height", this.Height);
            paramters.Add("volume", this.Volume);
            paramters.Add("is_safe", this.IsSafe);
            paramters.Add("safe_date", this.SafeDate);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("goods_no", this.GoodsNo);
        }

    }
}
