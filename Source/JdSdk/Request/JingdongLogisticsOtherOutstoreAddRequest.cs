#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:52.01354 +08:00
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
    /// 其他出库订单下传 Request
    /// </summary>
    public class JingdongLogisticsOtherOutstoreAddRequest : IJdRequest<JingdongLogisticsOtherOutstoreAddResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.logistics.otherOutstore.add"; }
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
