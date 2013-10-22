#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:820 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取类目下的属性信息。 Response
    /// </summary>
    public class WareGetAttributeResponse : JdResponse
    {
        /// <summary>
        /// 类目属性信息
        /// </summary>
        [XmlElement("attributes")]
        [JsonProperty("attributes")]
        public List<JdSdk.Domain.Attribute> Attributes
        {
            get;
            set;
        }

    }
}
