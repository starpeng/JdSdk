#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:27.83030 +08:00
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
    /// 获取消息系统信息 Request
    /// </summary>
    public class JingdongAfsserviceMessagesystemGetRequest : JdRequestBase<JingdongAfsserviceMessagesystemGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.messagesystem.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
