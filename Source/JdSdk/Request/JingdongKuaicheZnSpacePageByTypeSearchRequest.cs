#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.94478 +08:00
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
    /// 根据投放类型获取广告位页面信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpacePageByTypeSearchRequest : IJdRequest<JingdongKuaicheZnSpacePageByTypeSearchResponse>
    {
        /// <summary>
        /// 参数描述
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.space.page.by.type.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("type" ,this.Type);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
