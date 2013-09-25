#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.13772 +08:00
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
    /// 搜索商品信息。 Request
    /// </summary>
    public class JingdongWareGetRequest : IJdRequest<JingdongWareGetResponse>
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [XmlElement("region_id")]
        [JsonProperty("region_id")]
        public Int64 RegionId
        {
            get;
            set;
        }

        /// <summary>
        /// 返回字段信息。支持的值：ware_id, title, jd_price,  ware_imgs, skus
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
            get{ return "jingdong.ware.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("region_id" ,this.RegionId);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("region_id", this.RegionId);
        }

    }
}
