#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:49.98943 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据广告位id获取可以投放的日期 Request
    /// </summary>
    public class JingdongKuaicheZnScheduleFindScheduleCanUseRequest : IJdRequest<JingdongKuaicheZnScheduleFindScheduleCanUseResponse>
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

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.schedule.findScheduleCanUse"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("space_id" ,this.SpaceId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("space_id", this.SpaceId);
        }

    }
}
