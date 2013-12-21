#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:26.81605 +08:00
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
    /// 根据大分类查询售后分类 Request
    /// </summary>
    public class JingdongAfsserviceCategoryGetRequest : JdRequestBase<JingdongAfsserviceCategoryGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.afsservice.category.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
