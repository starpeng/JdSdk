#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:03.74121 +08:00
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
    /// 获取商品公开的详细数据 Request
    /// </summary>
    public class JingdongWaresSearchRequest : JdRequestBase<JingdongWaresSearchResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Int64 Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [XmlElement("q")]
        [JsonProperty("q")]
        public Int64 Q
        {
            get;
            set;
        }

        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Int64 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 可选字段wareId,title,price
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.wares.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);
            paramters.Add("q", this.Q);
            paramters.Add("page", this.Page);
            paramters.Add("page_size", this.PageSize);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("q", this.Q);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
