#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:55.25073 +08:00
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
    /// 创建促销，支持单品促销、套装促销、赠品促销，添加促销信息如名称、时间、类型等。 Request
    /// </summary>
    public class JingdongSellerPromotionAddRequest : JdRequestBase<JingdongSellerPromotionAddResponse>
    {
        /// <summary>
        /// 促销名称，字符串长度小于等于10
        /// </summary>
        /// <example>优惠促销</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 促销类型，可选值：单品促销（1），赠品促销（4），套装促销（6）
        /// </summary>
        /// <example>1</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 促销开始时间，格式为yyyy-MM-dd HH:mm:ss，精确到分钟，最长可设置为180天之后
        /// </summary>
        /// <example>2013-05-21    13:30:59</example>
        [XmlElement("begin_time")]
        [JsonProperty("begin_time")]
        public String BeginTime
        {
            get;
            set;
        }

        /// <summary>
        /// 促销结束时间，格式为yyyy-MM-dd HH:mm:ss，精确到分钟，必须大于开始时间至少一分钟，且晚于当前时间，建议至少晚10分钟，且和开始时间最大间隔不能超过180天
        /// </summary>
        /// <example>2013-05-21    13:40:59</example>
        [XmlElement("end_time")]
        [JsonProperty("end_time")]
        public String EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 优惠模型，暂不支持
        /// </summary>
        [XmlElement("favor_mode")]
        [JsonProperty("favor_mode")]
        public Int64 FavorMode
        {
            get;
            set;
        }

        /// <summary>
        /// 促销范围，暂不支持
        /// </summary>
        [XmlElement("bound")]
        [JsonProperty("bound")]
        public Int64 Bound
        {
            get;
            set;
        }

        /// <summary>
        /// 会员限制，可选值：-1、不限，56、铁牌，60、铜牌，61、银牌，62、金牌，63、钻石，88、双钻，103、三钻，104、四钻，105、五钻，90、企业会员
        /// </summary>
        /// <example>-1</example>
        [XmlElement("member")]
        [JsonProperty("member")]
        public Int64 Member
        {
            get;
            set;
        }

        /// <summary>
        /// 广告语，字符串长度小于等于50
        /// </summary>
        [XmlElement("slogan")]
        [JsonProperty("slogan")]
        public String Slogan
        {
            get;
            set;
        }

        /// <summary>
        /// 活动备注，不超过200字节
        /// </summary>
        [XmlElement("comment")]
        [JsonProperty("comment")]
        public String Comment
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("name", this.Name);
            paramters.Add("type", this.Type);
            paramters.Add("begin_time", this.BeginTime);
            paramters.Add("end_time", this.EndTime);
            paramters.Add("favor_mode", this.FavorMode);
            paramters.Add("bound", this.Bound);
            paramters.Add("member", this.Member);
            paramters.Add("slogan", this.Slogan);
            paramters.Add("comment", this.Comment);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("begin_time", this.BeginTime);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
        }

    }
}
