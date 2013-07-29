#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.01420 +08:00
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
    /// 获得指定SKU ID的商品的推广数据 Request
    /// </summary>
    public class JingdongUnionPromotiongoodUpdateRequest : IJdRequest<JingdongUnionPromotiongoodUpdateResponse>
    {
        /// <summary>
        /// 商品的SKU ID,如果skuId不填或者没有相匹配的店铺信息则返回默认的推广数据
        /// </summary>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public String SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 要求返回的商品推广的内容字段
        /// </summary>
        /// <example>good_pk,good_skuId,good_shopName,good_name,good_price,good_praiseDegree,good_targetUrl,good_shopUrl,good_materialUrl,good_commRatio,good_commision,good_promQuantity,good_startDate,good_endDate,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.promotiongood.update"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("skuid" ,this.SkuId);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
