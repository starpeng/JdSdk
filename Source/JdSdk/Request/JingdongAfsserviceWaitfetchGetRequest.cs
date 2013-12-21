#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:29.86079 +08:00
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
    /// 获取待领取列表 Request
    /// </summary>
    public class JingdongAfsserviceWaitfetchGetRequest : JdRequestBase<JingdongAfsserviceWaitfetchGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.waitfetch.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
