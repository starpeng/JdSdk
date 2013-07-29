#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.12566 +08:00
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
    /// 获取地区信息 Request
    /// </summary>
    public class JingdongRegioninfoGetRequest : IJdRequest<JingdongRegioninfoGetResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.regioninfo.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<String, Object>();
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }
    }
}
