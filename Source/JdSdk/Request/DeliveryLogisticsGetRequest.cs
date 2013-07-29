#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:41:970 +08:00
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
    /// 检索商家物流公司信息 Request
    /// </summary>
    public class DeliveryLogisticsGetRequest : IJdRequest<DeliveryLogisticsGetResponse>
    {
        public String ApiName
        {
            get{ return "360buy.delivery.logistics.get"; }
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
