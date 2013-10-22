#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.94478 +08:00
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
    /// 根据投放类型获取广告位页面信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpacePageByTypeSearchRequest : JdRequestBase<JingdongKuaicheZnSpacePageByTypeSearchResponse>
    {
        /// <summary>
        /// 参数描述
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.space.page.by.type.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("type", this.Type);

        }

        public override void Validate()
        {
        }

    }
}
