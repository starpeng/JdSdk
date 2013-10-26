#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.84501 +08:00
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
    /// 根据计划信息获取排名信息 Response
    /// </summary>
    public class JingdongKuaicheZnBidRankGetResponse : JdResponse
    {
        /// <summary>
        /// 预测返回信息
        /// </summary>
        [XmlElement("rank_return")]
        [JsonProperty("rank_return")]
        public RankReturnJO RankReturn
        {
            get;
            set;
        }

    }
}
