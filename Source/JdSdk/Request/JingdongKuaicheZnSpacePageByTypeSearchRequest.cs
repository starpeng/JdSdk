#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.27715 +08:00
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
    /// 根据投放类型获取广告位页面信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpacePageByTypeSearchRequest : JdRequestBase<JingdongKuaicheZnSpacePageByTypeSearchResponse>
    {
        /// <summary>
        /// 取值为1和21:频道页;2:搜索结果页
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.space.page.by.type.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("type" ,this.Type);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("type", this.Type);
        }

    }
}
