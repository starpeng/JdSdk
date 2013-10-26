#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:33.53248 +08:00
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
    /// 查询 关联版式id以及名称。 Response
    /// </summary>
    public class WareTemplateIdsNamesGetResponse : JdResponse
    {
        /// <summary>
        /// 关联版式集合
        /// </summary>
        [XmlElement("ware_templates")]
        [JsonProperty("ware_templates")]
        public List<WareTemplate> WareTemplates
        {
            get;
            set;
        }

    }
}
