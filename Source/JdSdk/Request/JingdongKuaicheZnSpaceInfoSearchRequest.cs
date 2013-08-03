#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.73677 +08:00
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
    /// 根据页面id查询该页面下的广告位信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpaceInfoSearchRequest : IJdRequest<JingdongKuaicheZnSpaceInfoSearchResponse>
    {
        /// <summary>
        /// 页面id
        /// </summary>
        [XmlElement("page_id")]
        [JsonProperty("page_id")]
        public Nullable<Decimal> PageId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.space.info.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("page_id" ,this.PageId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
