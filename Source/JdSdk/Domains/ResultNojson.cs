#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78827 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// result_no  json结构
    /// </summary>
    [Serializable]
    public class ResultNojson : JdObject
    {
        /// <summary>
        /// JOSL商品编码
        /// </summary>
        /// <example>JG00000055</example>
        [XmlElement("joslGoodNo")]
        [JsonProperty("joslGoodNo")]
        public String JoslGoodNo
        {
            get;
            set;
        }

        /// <summary>
        /// ISV商品编码
        /// </summary>
        /// <example>abc005</example>
        [XmlElement("isvGoodNo")]
        [JsonProperty("isvGoodNo")]
        public String IsvGoodNo
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <example>iphonne</example>
        [XmlElement("goodName")]
        [JsonProperty("goodName")]
        public String GoodName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品简称
        /// </summary>
        /// <example>苹果手机</example>
        [XmlElement("goodShortName")]
        [JsonProperty("goodShortName")]
        public String GoodShortName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品类别ID
        /// </summary>
        /// <example>213</example>
        [XmlElement("goodCategoryId")]
        [JsonProperty("goodCategoryId")]
        public String GoodCategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品类别名称
        /// </summary>
        /// <example>手机</example>
        [XmlElement("goodCategoryName")]
        [JsonProperty("goodCategoryName")]
        public String GoodCategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// 品牌编码
        /// </summary>
        /// <example>123</example>
        [XmlElement("brandNo")]
        [JsonProperty("brandNo")]
        public String BrandNo
        {
            get;
            set;
        }

        /// <summary>
        /// 品牌名称
        /// </summary>
        /// <example>apple</example>
        [XmlElement("brandName")]
        [JsonProperty("brandName")]
        public String BrandName
        {
            get;
            set;
        }

        /// <summary>
        /// 规格型号
        /// </summary>
        /// <example>123.33</example>
        [XmlElement("goodStandard")]
        [JsonProperty("goodStandard")]
        public String GoodStandard
        {
            get;
            set;
        }

        /// <summary>
        /// 颜色
        /// </summary>
        /// <example>red</example>
        [XmlElement("color")]
        [JsonProperty("color")]
        public String Color
        {
            get;
            set;
        }

        /// <summary>
        /// 尺寸
        /// </summary>
        /// <example>4556</example>
        [XmlElement("goodSize")]
        [JsonProperty("goodSize")]
        public Int64 GoodSize
        {
            get;
            set;
        }

        /// <summary>
        /// 毛重
        /// </summary>
        /// <example>44.4</example>
        [XmlElement("grossWeight")]
        [JsonProperty("grossWeight")]
        public Int64 GrossWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 净重
        /// </summary>
        /// <example>23.3</example>
        [XmlElement("netWeight")]
        [JsonProperty("netWeight")]
        public Int64 NetWeight
        {
            get;
            set;
        }

        /// <summary>
        /// 件型描述
        /// </summary>
        /// <example>大件</example>
        [XmlElement("sizeDefinition")]
        [JsonProperty("sizeDefinition")]
        public String SizeDefinition
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商编码
        /// </summary>
        /// <example>234567</example>
        [XmlElement("supplierNo")]
        [JsonProperty("supplierNo")]
        public String SupplierNo
        {
            get;
            set;
        }

        /// <summary>
        /// 供应商名称
        /// </summary>
        /// <example>京东</example>
        [XmlElement("supplierName")]
        [JsonProperty("supplierName")]
        public String SupplierName
        {
            get;
            set;
        }

        /// <summary>
        /// 制造商
        /// </summary>
        /// <example>76</example>
        [XmlElement("producer")]
        [JsonProperty("producer")]
        public String Producer
        {
            get;
            set;
        }

        /// <summary>
        /// 制造商地址
        /// </summary>
        /// <example>ABC12345</example>
        [XmlElement("produceAddress")]
        [JsonProperty("produceAddress")]
        public String ProduceAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 长
        /// </summary>
        /// <example>7</example>
        [XmlElement("goodLength")]
        [JsonProperty("goodLength")]
        public Int64 GoodLength
        {
            get;
            set;
        }

        /// <summary>
        /// 宽
        /// </summary>
        /// <example>5</example>
        [XmlElement("goodWidth")]
        [JsonProperty("goodWidth")]
        public Int64 GoodWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 高
        /// </summary>
        /// <example>3</example>
        [XmlElement("goodHeight")]
        [JsonProperty("goodHeight")]
        public Int64 GoodHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 体积
        /// </summary>
        /// <example>105</example>
        [XmlElement("volume")]
        [JsonProperty("volume")]
        public Int64 Volume
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保质期管理
        /// </summary>
        /// <example>1</example>
        [XmlElement("isSafe")]
        [JsonProperty("isSafe")]
        public Int64 IsSafe
        {
            get;
            set;
        }

        /// <summary>
        /// 保质期
        /// </summary>
        /// <example>365</example>
        [XmlElement("safeDate")]
        [JsonProperty("safeDate")]
        public Int64 SafeDate
        {
            get;
            set;
        }

        /// <summary>
        /// 条码
        /// </summary>
        /// <example>111111</example>
        [XmlElement("barCode")]
        [JsonProperty("barCode")]
        public String BarCode
        {
            get;
            set;
        }

    }
}
