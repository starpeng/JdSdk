#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:48.77436 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取标签信息 Request
    /// </summary>
    public class JingdongKuaicheZnMaterialLabelsSearchRequest : JdRequestBase<JingdongKuaicheZnMaterialLabelsSearchResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.material.labels.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
