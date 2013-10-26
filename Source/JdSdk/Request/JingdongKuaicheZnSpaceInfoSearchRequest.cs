#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.07514 +08:00
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
    /// 根据页面id查询该页面下的广告位信息 Request
    /// </summary>
    public class JingdongKuaicheZnSpaceInfoSearchRequest : JdRequestBase<JingdongKuaicheZnSpaceInfoSearchResponse>
    {
        /// <summary>
        /// 频道页输入三级类目page_id，所有page_id均通过jingdong.kuaiche.zn.space.page.by.type.search获得
        /// </summary>
        [XmlElement("page_id")]
        [JsonProperty("page_id")]
        public Int64 PageId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.space.info.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("page_id" ,this.PageId);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_id", this.PageId);
        }

    }
}
