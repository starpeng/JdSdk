#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.25004 +08:00
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
    /// 获取标签信息 Request
    /// </summary>
    public class JingdongKuaicheZnMaterialLabelsSearchRequest : JdRequestBase<JingdongKuaicheZnMaterialLabelsSearchResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.material.labels.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
