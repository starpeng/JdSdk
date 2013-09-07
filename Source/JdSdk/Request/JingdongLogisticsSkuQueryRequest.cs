#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:53.63063 +08:00
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
    /// 查询商品信息接口 Request
    /// </summary>
    public class JingdongLogisticsSkuQueryRequest : IJdRequest<JingdongLogisticsSkuQueryResponse>
    {
        /// <summary>
        /// josl商品编号
        /// </summary>
        [XmlElement("josl_good_no")]
        [JsonProperty("josl_good_no")]
        public String JoslGoodNo
        {
            get;
            set;
        }

        /// <summary>
        /// isv商品编号
        /// </summary>
        [XmlElement("isv_good_no")]
        [JsonProperty("isv_good_no")]
        public String IsvGoodNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.sku.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("josl_good_no" ,this.JoslGoodNo);
            paramters.Add("isv_good_no" ,this.IsvGoodNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
