#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:14.71196 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Ware结构
    /// </summary>
    [Serializable]
    public class Ware : JdObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Decimal> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// spu ID
        /// </summary>
        /// <example>275333</example>
        [XmlElement("spu_id")]
        [JsonProperty("spu_id")]
        public String SpuId
        {
            get;
            set;
        }

        /// <summary>
        /// 分类ID 三级类目ID
        /// </summary>
        /// <example>1589</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Decimal> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <example>20032</example>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public Nullable<Decimal> VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>12314</example>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Nullable<Decimal> ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品状态: NEVER_UP:从未上架,CUSTORMER_DOWN:自主下架SYSTEM_DOWN:系统下架ON_SALE:在售AUDIT_AWAIT: 待审核AUDIT_FAIL: 审核不通过
        /// </summary>
        /// <example>NEVER_UP</example>
        [XmlElement("ware_status")]
        [JsonProperty("ware_status")]
        public String WareStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 商品标题
        /// </summary>
        /// <example>京东sop衬衫1</example>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 货号
        /// </summary>
        /// <example>23424</example>
        [XmlElement("item_num")]
        [JsonProperty("item_num")]
        public String ItemNum
        {
            get;
            set;
        }

        /// <summary>
        /// UPC编码
        /// </summary>
        /// <example>6948807910044</example>
        [XmlElement("upc_code")]
        [JsonProperty("upc_code")]
        public String UpcCode
        {
            get;
            set;
        }

        /// <summary>
        /// 运费模板
        /// </summary>
        /// <example>333</example>
        [XmlElement("transport_id")]
        [JsonProperty("transport_id")]
        public Nullable<Decimal> TransportId
        {
            get;
            set;
        }

        /// <summary>
        /// 最后上架时间
        /// </summary>
        /// <example>2011-12-26 16:09:29</example>
        [XmlElement("online_time")]
        [JsonProperty("online_time")]
        public String OnlineTime
        {
            get;
            set;
        }

        /// <summary>
        /// 最后下架时间
        /// </summary>
        /// <example>2011-12-26 16:14:20</example>
        [XmlElement("offline_time")]
        [JsonProperty("offline_time")]
        public String OfflineTime
        {
            get;
            set;
        }

        /// <summary>
        /// 可选属性
        /// </summary>
        /// <example>1001:1501^1006:1504</example>
        [XmlElement("attributes")]
        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        /// <summary>
        /// 进货价, 精确到2位小数，单位:元
        /// </summary>
        /// <example>123.13</example>
        [XmlElement("cost_price")]
        [JsonProperty("cost_price")]
        public String CostPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 市场价, 精确到2位小数，单位:元
        /// </summary>
        /// <example>123.13</example>
        [XmlElement("market_price")]
        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价,精确到2位小数，单位:元
        /// </summary>
        /// <example>12.13</example>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 库存
        /// </summary>
        /// <example>10</example>
        [XmlElement("stock_num")]
        [JsonProperty("stock_num")]
        public Nullable<Decimal> StockNum
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的主图
        /// </summary>
        /// <example>1650/29f0f691-30bd-4d52-9041-285d341422ca.jpg</example>
        [XmlElement("logo")]
        [JsonProperty("logo")]
        public String Logo
        {
            get;
            set;
        }

        /// <summary>
        /// 录入人
        /// </summary>
        /// <example>路由器</example>
        [XmlElement("creator")]
        [JsonProperty("creator")]
        public String Creator
        {
            get;
            set;
        }

        /// <summary>
        /// 状态：Delete:删除Invalid:无效Valid :有效
        /// </summary>
        /// <example>Delete</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Decimal> Status
        {
            get;
            set;
        }

        /// <summary>
        /// 重量,单位:公斤
        /// </summary>
        /// <example>10</example>
        [XmlElement("weight")]
        [JsonProperty("weight")]
        public String Weight
        {
            get;
            set;
        }

        /// <summary>
        /// WARE_WARE创建时间时间格式：yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2011-11-04 15:24:43</example>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// WARE_WARE修改时间时间格式：yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2011-11-04 15:34:43</example>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

        /// <summary>
        /// 外部id,商家设置的外部id（保留字段）
        /// </summary>
        /// <example>Af1315</example>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否先款后货 支付方式 false：非  true：是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_pay_first")]
        [JsonProperty("is_pay_first")]
        public Nullable<Boolean> IsPayFirst
        {
            get;
            set;
        }

        /// <summary>
        /// 发票限制： true为限制，false为不限制开增值税发票
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_can_vat")]
        [JsonProperty("is_can_vat")]
        public Nullable<Boolean> IsCanVat
        {
            get;
            set;
        }

        /// <summary>
        /// 是否进口商品： false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_imported")]
        [JsonProperty("is_imported")]
        public Nullable<Boolean> IsImported
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保健品： false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_health_product")]
        [JsonProperty("is_health_product")]
        public Nullable<Boolean> IsHealthProduct
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保质期管理商品, false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("Is_shelf_life")]
        [JsonProperty("Is_shelf_life")]
        public Nullable<Boolean> IsShelfLife
        {
            get;
            set;
        }

        /// <summary>
        /// 保质期： 0-99999范围区间
        /// </summary>
        /// <example>999</example>
        [XmlElement("shelf_life_days")]
        [JsonProperty("shelf_life_days")]
        public Int32 ShelfLifeDays
        {
            get;
            set;
        }

        /// <summary>
        /// 是否序列号管理： false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_serial_no")]
        [JsonProperty("is_serial_no")]
        public Nullable<Boolean> IsSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// 大家电购物卡： false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_appliances_card")]
        [JsonProperty("is_appliances_card")]
        public Nullable<Boolean> IsAppliancesCard
        {
            get;
            set;
        }

        /// <summary>
        /// 是否特殊液体： false为否，true为是
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_special_wet")]
        [JsonProperty("is_special_wet")]
        public Nullable<Boolean> IsSpecialWet
        {
            get;
            set;
        }

        /// <summary>
        /// 商品件型： 0免费、1超大件、2超大件半件、3大件、4大件半件、5中件、6中件半件、7小件、8超小件
        /// </summary>
        /// <example>2</example>
        [XmlElement("ware_big_small_model")]
        [JsonProperty("ware_big_small_model")]
        public Int32 WareBigSmallModel
        {
            get;
            set;
        }

        /// <summary>
        /// 商品包装： 1普通商品、2易碎品、3裸瓶液体、4带包装液体、5按原包装出库
        /// </summary>
        /// <example>2</example>
        [XmlElement("ware_pack_type")]
        [JsonProperty("ware_pack_type")]
        public Int32 WarePackType
        {
            get;
            set;
        }

        /// <summary>
        /// Sku对象信息, Sku对象信息,参见获取sku信息中的sku对象
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("skus")]
        [JsonProperty("skus")]
        public Sku Skus
        {
            get;
            set;
        }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <example>商品</example>
        [XmlElement("desc")]
        [JsonProperty("desc")]
        public String Desc
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
        /// 11:21:31
        /// </summary>
        /// <example>长:宽:高</example>
        [XmlElement("cubage")]
        [JsonProperty("cubage")]
        public String Cubage
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
        /// 店内分类
        /// </summary>
        [XmlElement("shop_categorys")]
        [JsonProperty("shop_categorys")]
        public String ShopCategorys 
        {
            get;
            set;
        }

    }
}
