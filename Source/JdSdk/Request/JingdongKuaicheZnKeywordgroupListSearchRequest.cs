#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.86372 +08:00
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
    /// 根据分类id查询该分类下的关键词组信息 Request
    /// </summary>
    public class JingdongKuaicheZnKeywordgroupListSearchRequest : JdRequestBase<JingdongKuaicheZnKeywordgroupListSearchResponse>
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

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.keywordgroup.list.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("category_id", this.CategoryId);

        }

        public override void Validate()
        {
        }

    }
}
