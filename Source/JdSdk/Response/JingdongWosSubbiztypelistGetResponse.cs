#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.12643 +08:00
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
