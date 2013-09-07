#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:02.32513 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWareCombineListGetRequest : IJdRequest<JingdongWareCombineListGetResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.ware.combine.list.get"; }
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
