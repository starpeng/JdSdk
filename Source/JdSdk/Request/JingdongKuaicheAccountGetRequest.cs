#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.62994 +08:00
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
    /// 获得商家账户余额，可用余额，冻结金额信息 Request
    /// </summary>
    public class JingdongKuaicheAccountGetRequest : JdRequestBase<JingdongKuaicheAccountGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.kuaiche.account.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
