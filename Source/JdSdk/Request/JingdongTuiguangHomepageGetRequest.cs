#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.52869 +08:00
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
    /// 获得首页的推广链接信息 Request
    /// </summary>
    public class JingdongTuiguangHomepageGetRequest : JdRequestBase<JingdongTuiguangHomepageGetResponse>
    {
        /// <summary>
        /// 需要返回的字段，
        ///<parp>  有以下可选字段</parp>
        ///<parp>  title,pic_url,commission_fee,click_url</parp>
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.如果不传值,则默认是false，为保留字段
        /// </summary>
        [XmlElement("is_mobile")]
        [JsonProperty("is_mobile")]
        public String IsMobile
        {
            get;
            set;
        }

        /// <summary>
        /// 是否需要推广的图片
        ///<parp>  ，true表示需要，false表示不需要。默认是false</parp>
        /// </summary>
        [XmlElement("is_need_img")]
        [JsonProperty("is_need_img")]
        public Nullable<Boolean> IsNeedImg
        {
            get;
            set;
        }

        /// <summary>
        /// 如果img_size_type不为空，那么serial_number也不能为空，取值分为8种：格式为：A:B，其中A为图片的尺寸，B,为此种图片尺寸，对应的编号。输入对应的编号即可，示例值：1,2,3,4,16,17,18,19
        ///<parp>  760*90：1，468*60 ：2，120*600：3 300*250：4  760*80  ：16，728*90 ：17，160*600：18，300*300：19 ，默认值为 1</parp>
        /// </summary>
        [XmlElement("img_size_type")]
        [JsonProperty("img_size_type")]
        public String ImgSizeType
        {
            get;
            set;
        }

        /// <summary>
        /// 序列分为1,2,3,4 四个值，分别表示序列一，序列二，序列三，序列四 默认值为1 即序列一
        /// </summary>
        [XmlElement("serial_number")]
        [JsonProperty("serial_number")]
        public String SerialNumber
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.tuiguang.homepage.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("is_mobile", this.IsMobile);
            paramters.Add("is_need_img", this.IsNeedImg);
            paramters.Add("img_size_type", this.ImgSizeType);
            paramters.Add("serial_number", this.SerialNumber);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

    }
}
