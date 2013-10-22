#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.51464 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取用户收支列表，只能获取最近一周，最近一个月，最近三个月的信息 Response
    /// </summary>
    public class JingdongKuaicheAccountIncomeExpenseSearchResponse : JdResponse
    {
        /// <summary>
        /// 分页对象
        /// </summary>
        [XmlElement("page_info")]
        [JsonProperty("page_info")]
        public PageInfo PageInfo
        {
            get;
            set;
        }

    }
}
