#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.86372 +08:00
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
    /// 根据分类id查询该分类下的关键词组信息 Request
    /// </summary>
    public class JingdongKuaicheZnKeywordgroupListSearchRequest : IJdRequest<JingdongKuaicheZnKeywordgroupListSearchResponse>
    {
        /// <summary>
        /// 分类id
        /// </summary>
        [XmlElement("category_id")]
        [JsonProperty("category_id")]
        public String CategoryId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.keywordgroup.list.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("category_id" ,this.CategoryId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
