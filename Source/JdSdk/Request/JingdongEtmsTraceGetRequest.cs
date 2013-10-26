#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:36.76266 +08:00
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
    /// 京东物流全程跟踪查询接口   相关文档下载：ERP对接方案【10月16日更新】   京东快递可配送区域 Request
    /// </summary>
    public class JingdongEtmsTraceGetRequest : JdRequestBase<JingdongEtmsTraceGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.etms.trace.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
