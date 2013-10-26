#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:58.28290 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据商家计划编号查询商家类目及佣金信息（计划编号为“”或null则只返回类目信息) Request
    /// </summary>
    public class JingdongUnionCategoryinfoSearchRequest : JdRequestBase<JingdongUnionCategoryinfoSearchResponse>
    {
        /// <summary>
        /// 计划编号 ，输入null或输入&quot;&quot; f返回商家经营的分类;输入正确的编号返回分类和佣金比例
        /// </summary>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public String PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.categoryinfo.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("planid", this.PlanId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("planId", this.PlanId);
        }

    }
}
