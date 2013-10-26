#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:33.32847 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询关联版式详情。 Response
    /// </summary>
    public class WareTemplateGetResponse : JdResponse
    {
        /// <summary>
        /// 关联版式信息
        /// </summary>
        [XmlElement("ware_template")]
        [JsonProperty("ware_template")]
        public WareTemplate WareTemplate
        {
            get;
            set;
        }

    }
}
