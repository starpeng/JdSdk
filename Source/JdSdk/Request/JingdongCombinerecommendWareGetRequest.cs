#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:22.92365 +08:00
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
    /// 商品推荐组合 Request
    /// </summary>
    public class JingdongCombinerecommendWareGetRequest : IJdRequest<JingdongCombinerecommendWareGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 
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
            get{ return "jingdong.combinerecommend.ware.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
