#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:41:162 +08:00
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
    /// 通过api 根据sku_id 删除sku Request
    /// </summary>
    public class WareSkuDeleteRequest : IJdRequest<WareSkuDeleteResponse>
    {
        /// <summary>
        /// sku的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public Int64 TradeNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.sku.delete"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("trade_no" ,this.TradeNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
        }

    }
}
