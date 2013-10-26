#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.26278 +08:00
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
    /// 分页查询促销列表，目前可以根据类型、状态进行查询，也支持组合查询 Request
    /// </summary>
    public class JingdongSellerPromotionListRequest : JdRequestBase<JingdongSellerPromotionListResponse>
    {
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
        /// 促销状态，可选值：驳回（1），未审核（2），人工审（3），审核通过（4），已生效（5）
        /// </summary>
        /// <example>4</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 页码，默认1 w
        /// </summary>
        /// <example>1</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Int64 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录个数，最大为10，默认10
        /// </summary>
        /// <example>10</example>
        [XmlElement("size")]
        [JsonProperty("size")]
        public Int64 Size
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("type", this.Type);
            paramters.Add("status", this.Status);
            paramters.Add("page", this.Page);
            paramters.Add("size", this.Size);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("type", this.Type);
        }

    }
}
