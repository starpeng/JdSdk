#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 18:18:08.77920 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据pin返回供应商简码和三级分类列表 Request
    /// </summary>
    public class JingdongUserCategory3InfoGetRequest : JdRequestBase<JingdongUserCategory3InfoGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.userCategory3.info.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
