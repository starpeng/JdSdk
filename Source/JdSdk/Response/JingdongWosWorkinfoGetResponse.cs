#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.32944 +08:00
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
