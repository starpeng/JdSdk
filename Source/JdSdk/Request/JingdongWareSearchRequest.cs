#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.34073 +08:00
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
    /// 获取商品公开的详细数据 Request
    /// </summary>
    public class JingdongWareSearchRequest : IJdRequest<JingdongWareSearchResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Decimal> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [XmlElement("q")]
        [JsonProperty("q")]
        public Decimal Q
        {
            get;
            set;
        }

        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Nullable<Decimal> Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Decimal> PageSize
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

        public String ApiName
        {
            get{ return "jingdong.ware.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            paramters.Add("q" ,this.Q);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("q", this.Q);
        }

    }
}
