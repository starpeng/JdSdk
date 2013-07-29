#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.62023 +08:00
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
    /// 查询相关的店铺名称的店铺推广数据 Request
    /// </summary>
    public class JingdongUnionPromotionshopUpdateRequest : IJdRequest<JingdongUnionPromotionshopUpdateResponse>
    {
        /// <summary>
        /// 店铺名称串,如果shopName不填或者没有相匹配的店铺信息则返回默认的推广数据
        /// </summary>
        [XmlElement("shopName")]
        [JsonProperty("shopName")]
        public String ShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 需返回的字段列表
        /// </summary>
        /// <example>shop_name,shop_promUrl,shop_materialUrl,shop_goodsVolume,shop_praiseDegree,shop_promQuantity,shop_mainCategories,shop_pk,shop_name,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.promotionshop.update"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("shopname" ,this.ShopName);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
