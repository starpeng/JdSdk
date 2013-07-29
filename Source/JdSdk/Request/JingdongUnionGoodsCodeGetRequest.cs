#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:03.59312 +08:00
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
    /// 根据商品ID查询商品推广代码 Request
    /// </summary>
    public class JingdongUnionGoodsCodeGetRequest : IJdRequest<JingdongUnionGoodsCodeGetResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        /// <example>30442010</example>
        [XmlElement("good_id")]
        [JsonProperty("good_id")]
        public Decimal GoodId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.goods.code.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("good_id" ,this.GoodId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("good_id", this.GoodId);
        }

    }
}
