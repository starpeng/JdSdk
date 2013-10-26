#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:03.79513 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取联盟用户详细信息 Request
    /// <para>此接口无需输入应用级参数，但需要构建空参数360buy_param_json={}</para>
    /// </summary>
    public class JingdongUnionMasterAccountGetRequest : JdRequestBase<JingdongUnionMasterAccountGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.union.master.account.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
