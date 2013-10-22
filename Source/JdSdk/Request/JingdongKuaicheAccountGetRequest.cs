#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.28363 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
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
            get { return "jingdong.kuaiche.account.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
