#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.28363 +08:00
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
    /// 获得商家账户余额，可用余额，冻结金额信息 Request
    /// </summary>
    public class JingdongKuaicheAccountGetRequest : IJdRequest<JingdongKuaicheAccountGetResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.kuaiche.account.get"; }
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
