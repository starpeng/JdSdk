#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.73677 +08:00
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
    /// 根据页面id查询该页面下的广告位信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpaceInfoSearchRequest : JdRequestBase<JingdongKuaicheZnSpaceInfoSearchResponse>
    {
        /// <summary>
        /// 页面id
        /// </summary>
        [XmlElement("page_id")]
        [JsonProperty("page_id")]
        public Nullable<Int64> PageId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.space.info.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("page_id", this.PageId);

        }

        public override void Validate()
        {
        }

    }
}
