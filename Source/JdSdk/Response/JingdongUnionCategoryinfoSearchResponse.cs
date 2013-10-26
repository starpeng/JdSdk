#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:58.28390 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据商家计划编号查询商家类目及佣金信息（计划编号为“”或null则只返回类目信息) Response
    /// </summary>
    public class JingdongUnionCategoryinfoSearchResponse : JdResponse
    {
        /// <summary>
        /// 类目查询结果
        /// </summary>
        [XmlElement("resultVO")]
        [JsonProperty("resultVO")]
        public ResultVO ResultVO
        {
            get;
            set;
        }

    }
}
