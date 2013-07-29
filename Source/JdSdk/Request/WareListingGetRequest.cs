#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.67985 +08:00
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
    /// 根据商品的一些信息查询商品。 Request
    /// </summary>
    public class WareListingGetRequest : IJdRequest<WareListingGetResponse>
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
        /// 起始的修改时间
        /// </summary>
        /// <example>2011-11-01  00:00:00</example>
        [XmlElement("start_modified")]
        [JsonProperty("start_modified")]
        public String StartModified
        {
            get;
            set;
        }

        /// <summary>
        /// 结束的修改时间
        /// </summary>
        /// <example>2012-11-01  00:00:00</example>
        [XmlElement("end_modified")]
        [JsonProperty("end_modified")]
        public String EndModified
        {
            get;
            set;
        }

        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Decimal Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Decimal PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 需返回的字段列表。可选值：ware结构体中的所有字段；字段之间用","分隔
        /// </summary>
        /// <example>ware_id,spu_idcid,created</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.listing.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            paramters.Add("start_modified" ,this.StartModified);
            paramters.Add("end_modified" ,this.EndModified);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("fields", this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
