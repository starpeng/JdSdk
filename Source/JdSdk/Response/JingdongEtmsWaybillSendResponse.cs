#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:35.14708 +08:00
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
    /// 向京东物流系统提交运单信息   相关文档下载：ERP对接方案【11月4日更新】   京东快递可配送区域 Response
    /// </summary>
    public class JingdongEtmsWaybillSendResponse : JdResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("resultInfo")]
        [JsonProperty("resultInfo")]
        public ResultInfoDTO ResultInfo
        {
            get;
            set;
        }

    }
}
