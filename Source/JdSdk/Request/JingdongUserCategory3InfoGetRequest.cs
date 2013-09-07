#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 18:18:08.77920 +08:00
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
    /// 根据pin返回供应商简码和三级分类列表 Request
    /// </summary>
    public class JingdongUserCategory3InfoGetRequest : IJdRequest<JingdongUserCategory3InfoGetResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.userCategory3.info.get"; }
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
