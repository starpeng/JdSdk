#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.34725 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    ///  Response
    /// </summary>
    public class JingdongWosWorkinfoGetResponse : JdResponse
    {
        /// <summary>
        /// 工单信息列表(只返回近60天的数据)
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result")]
        public List<SafWorkInfoDTO> Result
        {
            get;
            set;
        }

    }
}
