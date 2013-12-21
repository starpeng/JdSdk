#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:27.42520 +08:00
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
    /// 同订单历史售后服务单查询 Request
    /// </summary>
    public class JingdongAfsserviceHistoryGetRequest : JdRequestBase<JingdongAfsserviceHistoryGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.history.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
