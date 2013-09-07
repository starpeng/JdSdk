#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.14523 +08:00
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
    ///  Response
    /// </summary>
    public class JingdongWosSubbiztypelistGetResponse : JdResponse
    {
        /// <summary>
        /// 二级业务类型列表
        /// </summary>
        [XmlElement("saf_biztype_Dtos")]
        [JsonProperty("saf_biztype_Dtos")]
        public List<SafBiztypeDTO> SafBiztypeDtos
        {
            get;
            set;
        }

    }
}
