#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.54145 +08:00
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
