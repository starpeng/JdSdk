#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:38.38976 +08:00
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
    /// 查询客服组信息 Request
    /// </summary>
    public class JingdongImPopGroupinfoGetRequest : JdRequestBase<JingdongImPopGroupinfoGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.im.pop.groupinfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
