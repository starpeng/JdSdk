#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:34.94556 +08:00
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
    /// 获取待收货服务单信息 Request
    /// </summary>
    public class JingdongAfsserviceReceivetaskGetRequest : JdRequestBase<JingdongAfsserviceReceivetaskGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.receivetask.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
