#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.55026 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    ///  Response
    /// </summary>
    public class JingdongWosWorklistGetResponse : JdResponse
    {
        /// <summary>
        /// 商家工单列表分页返回结果
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public SafWorkPage Page
        {
            get;
            set;
        }

    }
}
