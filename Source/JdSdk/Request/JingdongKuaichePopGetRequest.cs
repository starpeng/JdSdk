#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.45469 +08:00
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
    /// 经用户授权后，可以获得商家在快车系统的用户信息。 Request
    /// </summary>
    public class JingdongKuaichePopGetRequest : IJdRequest<JingdongKuaichePopGetResponse>
    {

        public String ApiName
        {
            get{ return "jingdong.kuaiche.pop.get"; }
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
