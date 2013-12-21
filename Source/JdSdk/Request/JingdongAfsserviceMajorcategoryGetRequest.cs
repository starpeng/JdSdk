#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:27.62725 +08:00
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
    /// 查询大分类 Request
    /// </summary>
    public class JingdongAfsserviceMajorcategoryGetRequest : JdRequestBase<JingdongAfsserviceMajorcategoryGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.majorcategory.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
