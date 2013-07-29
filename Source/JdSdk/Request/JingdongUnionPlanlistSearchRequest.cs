#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.40816 +08:00
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
    /// 根据商家账号查询商家计划列表 Request
    /// </summary>
    public class JingdongUnionPlanlistSearchRequest : IJdRequest<JingdongUnionPlanlistSearchResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("pageIndex")]
        [JsonProperty("pageIndex")]
        public Decimal PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页行数
        /// </summary>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Decimal PageSize
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.planlist.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("pageindex" ,this.PageIndex);
            paramters.Add("pagesize" ,this.PageSize);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pageIndex", this.PageIndex);
            RequestValidator.ValidateRequired("pageSize", this.PageSize);
        }

    }
}
