#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.32767 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获得频道页的推广链接信息 Request
    /// </summary>
    public class JingdongTuiguangCatGetRequest : IJdRequest<JingdongTuiguangCatGetResponse>
    {
        /// <summary>
        /// 需要返回的字段，  有以下可选字段：ware_id,title,price,pic_url,commission_fee,click_url,shop_click_url
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 一级类目id ，类目id从面向用户服务的类目服务jingdong.warecategory.get接口获得
        /// </summary>
        [XmlElement("a_cid")]
        [JsonProperty("a_cid")]
        public String ACid
        {
            get;
            set;
        }

        /// <summary>
        /// 二级类目id，通过面向用户服务中的类目服务jingdong.warecategory.get接口获得类目id
        /// </summary>
        [XmlElement("b_cid")]
        [JsonProperty("b_cid")]
        public String BCid
        {
            get;
            set;
        }

        /// <summary>
        /// 三级类目id，通过面向用户服务中的类目服务jingdong.warecategory.get接口获得类目id
        /// </summary>
        [XmlElement("c_cid")]
        [JsonProperty("c_cid")]
        public String CCid
        {
            get;
            set;
        }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.如果不传递值,则默认是false.为保留字段
        /// </summary>
        [XmlElement("is_mobile")]
        [JsonProperty("is_mobile")]
        public String IsMobile
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public String Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页的记录条数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public String PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 类目的级别 1,2,3分别和一级，二级，三级类目相对应，若level=1,那么一级类目id不可以为空，若level=2,那么一级，和二级类目id不可以为空，若level=3，那么一级类目id，二级类目id，三级类目id都不可为空。
        /// </summary>
        [XmlElement("level")]
        [JsonProperty("level")]
        public String Level
        {
            get;
            set;
        }

        /// <summary>
        /// 是否需要推广的图片  ，true表示需要，false表示不需要。默认是false
        /// </summary>
        [XmlElement("is_need_img")]
        [JsonProperty("is_need_img")]
        public Nullable<Boolean> IsNeedImg
        {
            get;
            set;
        }

        /// <summary>
        /// 序列分为1,2,3,4 四个值，分别表示序列一，序列二，序列三，序列四 ，默认值为1 即序列一
        /// </summary>
        [XmlElement("serial_number")]
        [JsonProperty("serial_number")]
        public String SerialNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 如果img_size_type不为空，那么serial_number也不能为空，取值分为8种，格式为：A:B，其中A为图片的尺寸，B,为此种图片尺寸，对应的编号。输入编号即可。示例值 1,2,3,4,16,17,18,19760*90：1，468*60 ：2，120*600：3 300*250：4  760*80  ：16，728*90 ：17，160*600：18，300*300：19 ， 默认值为1
        /// </summary>
        [XmlElement("img_size_type")]
        [JsonProperty("img_size_type")]
        public String ImgSizeType
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.tuiguang.cat.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            paramters.Add("a_cid" ,this.ACid);
            paramters.Add("b_cid" ,this.BCid);
            paramters.Add("c_cid" ,this.CCid);
            paramters.Add("is_mobile" ,this.IsMobile);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("level" ,this.Level);
            paramters.Add("is_need_img" ,this.IsNeedImg);
            paramters.Add("serial_number" ,this.SerialNumber);
            paramters.Add("img_size_type" ,this.ImgSizeType);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("a_cid", this.ACid);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("level", this.Level);
        }

    }
}
