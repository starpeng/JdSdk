#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.74476 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取类目。 Response
    /// </summary>
    public class JingdongWarecategoryGetResponse : JdResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlElement("wareCategories")]
        [JsonProperty("wareCategories")]
        public List<WareCategory> WareCategories
        {
            get;
            set;
        }

    }
}
