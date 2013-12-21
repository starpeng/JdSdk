#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:29.65874 +08:00
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
    /// 获取待审核列表 Request
    /// </summary>
    public class JingdongAfsserviceWaitauditGetRequest : JdRequestBase<JingdongAfsserviceWaitauditGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.waitaudit.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
