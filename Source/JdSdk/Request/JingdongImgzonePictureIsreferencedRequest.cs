#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.94419 +08:00
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
    public class JingdongImgzonePictureIsreferencedRequest : IJdRequest<JingdongImgzonePictureIsreferencedResponse>
    {
        public String ApiName
        {
            get{ return "jingdong.imgzone.picture.isreferenced"; }
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
