#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-04-03 12:45:24.94677 +08:00
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
    /// 根据三级分类id，搜索商品数据 Request
    /// </summary>
    public class JingdongWaresSearchbycidRequest : JdRequestBase<JingdongWaresSearchbycidResponse>
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
        /// 分页
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Nullable<Int64> Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 可选字段
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
            get { return "jingdong.wares.searchbycid"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);
            paramters.Add("page", this.Page);
            paramters.Add("page_size", this.PageSize);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
