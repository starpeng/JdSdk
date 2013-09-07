#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:56.66581 +08:00
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
    /// 根据促销编号获取促销的道具列表 Request
    /// </summary>
    public class JingdongSellerPromotionPropListRequest : IJdRequest<JingdongSellerPromotionPropListResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.seller.promotion.prop.list"; }
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
