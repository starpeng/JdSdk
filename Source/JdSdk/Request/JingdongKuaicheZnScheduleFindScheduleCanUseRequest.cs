#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:49.98943 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据广告位id获取可以投放的日期 Request
    /// </summary>
    public class JingdongKuaicheZnScheduleFindScheduleCanUseRequest : JdRequestBase<JingdongKuaicheZnScheduleFindScheduleCanUseResponse>
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("space_id")]
        [JsonProperty("space_id")]
        public Int64 SpaceId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.schedule.findScheduleCanUse"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("space_id", this.SpaceId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("space_id", this.SpaceId);
        }

    }
}
