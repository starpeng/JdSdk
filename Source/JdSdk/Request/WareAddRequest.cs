#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:11.84880 +08:00
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
    /// 新增一个商品 Request
    /// </summary>
    public class WareAddRequest : JdRequestBase<WareAddResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        /// <example>1354</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 店内分类
        /// </summary>
        /// <example>206-208;207-208206(一级)-208(二级);207(一级)-207(一级)</example>
        [XmlElement("shop_category")]
        [JsonProperty("shop_category")]
        public String ShopCategory
        {
            get;
            set;
        }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// upc编码
        /// </summary>
        [XmlElement("upc_code")]
        [JsonProperty("upc_code")]
        public String UpcCode
        {
            get;
            set;
        }

        /// <summary>
        /// 操作类型，现只支持：offsale 或onsale下架类型请传入：offsale上架类型请传入：onsale如果不传默认为下架状态
        /// </summary>
        /// <example>如下架传入：offsale</example>
        [XmlElement("option_type")]
        [JsonProperty("option_type")]
        public String OptionType
        {
            get;
            set;
        }

        /// <summary>
        /// 货号
        /// </summary>
        [XmlElement("item_num")]
        [JsonProperty("item_num")]
        public String ItemNum
        {
            get;
            set;
        }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [XmlElement("producter")]
        [JsonProperty("producter")]
        public String Producter
        {
            get;
            set;
        }

        /// <summary>
        /// 包装规格
        /// </summary>
        [XmlElement("wrap")]
        [JsonProperty("wrap")]
        public String Wrap
        {
            get;
            set;
        }

        /// <summary>
        /// 长(单位:mm)
        /// </summary>
        [XmlElement("length")]
        [JsonProperty("length")]
        public String Length
        {
            get;
            set;
        }

        /// <summary>
        /// 宽(单位:mm)
        /// </summary>
        [XmlElement("wide")]
        [JsonProperty("wide")]
        public String Wide
        {
            get;
            set;
        }

        /// <summary>
        /// 高(单位:mm)
        /// </summary>
        [XmlElement("high")]
        [JsonProperty("high")]
        public String High
        {
            get;
            set;
        }

        /// <summary>
        /// 重量(单位:kg)
        /// </summary>
        [XmlElement("weight")]
        [JsonProperty("weight")]
        public String Weight
        {
            get;
            set;
        }

        /// <summary>
        /// 进货价
        /// </summary>
        [XmlElement("cost_price")]
        [JsonProperty("cost_price")]
        public String CostPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("market_price")]
        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价
        /// </summary>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("notes")]
        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

        /// <summary>
        /// 图片信息，通过程序对图片进行Byte[] 格式的处理后，生成参数信息（&lt;span style="color:#000000;font-family:"Segoe UI";font-size:10pt;"&gt;第一 读取图片；第二 将图片通过base64转化成字符串，然后赋值给ware_image属性）&lt;span style="font-family:"Segoe UI";font-size:10pt;"&gt;根据URL换码协议，会将POST发送的数据里面是"+"全部被替换成空格，所以ware_image参数经过MD5加密完毕后，需要将ware_image对应的值中的"+"转换成%2B
        /// </summary>
        [XmlElement("ware_image")]
        [JsonProperty("ware_image")]
        public Byte[] WareImage
        {
            get;
            set;
        }

        /// <summary>
        /// 包装清单
        /// </summary>
        [XmlElement("pack_listing")]
        [JsonProperty("pack_listing")]
        public String PackListing
        {
            get;
            set;
        }

        /// <summary>
        /// 售后服务
        /// </summary>
        [XmlElement("service")]
        [JsonProperty("service")]
        public String Service
        {
            get;
            set;
        }

        /// <summary>
        /// 库存数
        /// </summary>
        [XmlElement("stock_num")]
        [JsonProperty("stock_num")]
        public String StockNum
        {
            get;
            set;
        }

        /// <summary>
        /// 自定义属性别名：  属性ID:属性值ID:别名  ，多组之间用^分开，如aid:vid:别名^aid1:vid1:别名1
        /// </summary>
        /// <example>1000000041:1500368001:淡蓝色</example>
        [XmlElement("property_alias")]
        [JsonProperty("property_alias")]
        public String PropertyAlias
        {
            get;
            set;
        }

        /// <summary>
        /// 商品属性列表,多组之间用"|"分隔，格式:aid:vid  或 aid:vid|aid1:vid1 或 aid1:vid1  （需要从类目服务接口获取）
        /// </summary>
        /// <example>3205:22101|3205:22102</example>
        [XmlElement("attributes")]
        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        /// <summary>
        /// sku 价格,多组之间用"|"分隔，格式:p1|p2
        /// </summary>
        /// <example>12|13</example>
        [XmlElement("sku_prices")]
        [JsonProperty("sku_prices")]
        public String SkuPrices
        {
            get;
            set;
        }

        /// <summary>
        /// sku 属性,一组sku 属性之间用"^"分隔，多组用"|"分隔格式:aid:vid^aid1:vid2|aid3:vid3^aid4:vid4（需要从类目服务接口获取）
        /// </summary>
        /// <example>100041:150041^1000046:15844|1001:1501^10006:1504</example>
        [XmlElement("sku_properties")]
        [JsonProperty("sku_properties")]
        public String SkuProperties
        {
            get;
            set;
        }

        /// <summary>
        /// sku 库存,多组之间用"|"分隔， 格式:s1|s2
        /// </summary>
        [XmlElement("sku_stocks")]
        [JsonProperty("sku_stocks")]
        public String SkuStocks
        {
            get;
            set;
        }

        /// <summary>
        /// SKU外部ID，对个之间用"|"分隔格，比如：sdf|sds
        /// </summary>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public String TradeNo
        {
            get;
            set;
        }

        /// <summary>
        /// 是否先款后货 , false为否，true为是
        /// </summary>
        /// <example>"true"</example>
        [XmlElement("is_pay_first")]
        [JsonProperty("is_pay_first")]
        public String IsPayFirst
        {
            get;
            set;
        }

        /// <summary>
        /// 发票限制：非必须输入，true为限制，false为不限制开增值税发票，FBP、LBP、SOPL、SOP类型商品均可输入；
        /// </summary>
        /// <example>"true"</example>
        [XmlElement("is_can_vat")]
        [JsonProperty("is_can_vat")]
        public String IsCanVat
        {
            get;
            set;
        }

        /// <summary>
        /// 是否进口商品：非必须输入，false为否，true为是，FBP类型商品可输入；
        /// </summary>
        /// <example>"true"</example>
        [XmlElement("is_imported")]
        [JsonProperty("is_imported")]
        public String IsImported
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保健品：非必须输入，false为否，true为是，FBP类型商品可输入；
        /// </summary>
        /// <example>"false"</example>
        [XmlElement("is_health_product")]
        [JsonProperty("is_health_product")]
        public String IsHealthProduct
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保质期管理商品, false为否，true为是
        /// </summary>
        /// <example>false</example>
        [XmlElement("is_shelf_life")]
        [JsonProperty("is_shelf_life")]
        public String IsShelfLife
        {
            get;
            set;
        }

        /// <summary>
        /// 保质期：非必须输入，0-99999范围区间，FBP类型商品可输入；
        /// </summary>
        /// <example>"999"</example>
        [XmlElement("shelf_life_days")]
        [JsonProperty("shelf_life_days")]
        public String ShelfLifeDays
        {
            get;
            set;
        }

        /// <summary>
        /// 是否序列号管理：非必须输入，false为否，true为是，FBP类型商品可输入；
        /// </summary>
        /// <example>"true"</example>
        [XmlElement("is_serial_no")]
        [JsonProperty("is_serial_no")]
        public String IsSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// 大家电购物卡：非必须输入，false为否，true为是，FBP类型商品可输入；
        /// </summary>
        /// <example>"true"</example>
        [XmlElement("is_appliances_card")]
        [JsonProperty("is_appliances_card")]
        public String IsAppliancesCard
        {
            get;
            set;
        }

        /// <summary>
        /// 是否特殊液体：非必须输入，false为否，true为是，FBP、LBP、SOPL类型商品可输入；
        /// </summary>
        /// <example>"false"</example>
        [XmlElement("is_special_wet")]
        [JsonProperty("is_special_wet")]
        public String IsSpecialWet
        {
            get;
            set;
        }

        /// <summary>
        /// 商品件型：必须输入，0免费、1超大件、2超大件半件、3大件、4大件半件、5中件、6中件半件、7小件、8超小件，FBP类型商品必须输入；
        /// </summary>
        /// <example>"2"</example>
        [XmlElement("ware_big_small_model")]
        [JsonProperty("ware_big_small_model")]
        public String WareBigSmallModel
        {
            get;
            set;
        }

        /// <summary>
        /// 商品包装：必须输入，1普通商品、2易碎品、3裸瓶液体、4带包装液体、5按原包装出库，FBP类型商品必须输入；
        /// </summary>
        /// <example>"2"</example>
        [XmlElement("ware_pack_type")]
        [JsonProperty("ware_pack_type")]
        public String WarePackType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);
            paramters.Add("shop_category", this.ShopCategory);
            paramters.Add("title", this.Title);
            paramters.Add("upc_code", this.UpcCode);
            paramters.Add("option_type", this.OptionType);
            paramters.Add("item_num", this.ItemNum);
            paramters.Add("producter", this.Producter);
            paramters.Add("wrap", this.Wrap);
            paramters.Add("length", this.Length);
            paramters.Add("wide", this.Wide);
            paramters.Add("high", this.High);
            paramters.Add("weight", this.Weight);
            paramters.Add("cost_price", this.CostPrice);
            paramters.Add("market_price", this.MarketPrice);
            paramters.Add("jd_price", this.JdPrice);
            paramters.Add("notes", this.Notes);
            paramters.Add("ware_image", this.WareImage);
            paramters.Add("pack_listing", this.PackListing);
            paramters.Add("service", this.Service);
            paramters.Add("stock_num", this.StockNum);
            paramters.Add("property_alias", this.PropertyAlias);
            paramters.Add("attributes", this.Attributes);
            paramters.Add("sku_prices", this.SkuPrices);
            paramters.Add("sku_properties", this.SkuProperties);
            paramters.Add("sku_stocks", this.SkuStocks);
            paramters.Add("outer_id", this.OuterId);
            paramters.Add("trade_no", this.TradeNo);
            paramters.Add("is_pay_first", this.IsPayFirst);
            paramters.Add("is_can_vat", this.IsCanVat);
            paramters.Add("is_imported", this.IsImported);
            paramters.Add("is_health_product", this.IsHealthProduct);
            paramters.Add("is_shelf_life", this.IsShelfLife);
            paramters.Add("shelf_life_days", this.ShelfLifeDays);
            paramters.Add("is_serial_no", this.IsSerialNo);
            paramters.Add("is_appliances_card", this.IsAppliancesCard);
            paramters.Add("is_special_wet", this.IsSpecialWet);
            paramters.Add("ware_big_small_model", this.WareBigSmallModel);
            paramters.Add("ware_pack_type", this.WarePackType);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateRequired("length", this.Length);
            RequestValidator.ValidateRequired("wide", this.Wide);
            RequestValidator.ValidateRequired("high", this.High);
            RequestValidator.ValidateRequired("weight", this.Weight);
            RequestValidator.ValidateRequired("market_price", this.MarketPrice);
            RequestValidator.ValidateRequired("jd_price", this.JdPrice);
            RequestValidator.ValidateRequired("notes", this.Notes);
            RequestValidator.ValidateRequired("ware_image", this.WareImage);
            RequestValidator.ValidateRequired("stock_num", this.StockNum);
            RequestValidator.ValidateRequired("attributes", this.Attributes);
        }

    }
}
