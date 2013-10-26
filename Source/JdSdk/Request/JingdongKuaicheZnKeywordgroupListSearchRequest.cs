#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.04702 +08:00
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
            get{ return "jingdong.kuaiche.zn.keywordgroup.list.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("category_id" ,this.CategoryId);
        }

        public override void Validate()
        {
        }

    }
}
