#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:35.55159 +08:00
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
    /// 获取服务单日志 Request
    /// </summary>
    public class JingdongAfsserviceServicelogGetRequest : JdRequestBase<JingdongAfsserviceServicelogGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.servicelog.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
