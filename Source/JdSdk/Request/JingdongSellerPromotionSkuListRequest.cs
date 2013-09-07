#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:57.27284 +08:00
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
    /// 分页查询指定促销下符合条件的促销SKU，最多返回10个 Request
    /// </summary>
    public class JingdongSellerPromotionSkuListRequest : IJdRequest<JingdongSellerPromotionSkuListResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.seller.promotion.sku.list"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
