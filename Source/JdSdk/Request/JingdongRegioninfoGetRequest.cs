#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-04-03 12:45:23.12566 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取地区信息 Request
    /// </summary>
    public class JingdongRegioninfoGetRequest : JdRequestBase<JingdongRegioninfoGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.regioninfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }
    }
}
