#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.21721 +08:00
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
    /// 查询站长的推广效果数据 Response
    /// </summary>
    public class JingdongUnionPromotionreportQueryResponse : JdResponse
    {
        /// <summary>
        /// 报表对象列表
        /// </summary>
        [XmlElement("report_list")]
        [JsonProperty("report_list")]
        public List<EffectReportSafVo> ReportList
        {
            get;
            set;
        }

        /// <summary>
        /// 结果总个数,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Decimal> TotalCount
        {
            get;
            set;
        }

    }
}
