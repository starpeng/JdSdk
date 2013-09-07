#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 18:18:09.00021 +08:00
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
    /// 订购关系查询（根据购买用户名和收费项目代码获取订购关系时长） Request
    /// </summary>
    public class JingdongVasSubscribeGetRequest : IJdRequest<JingdongVasSubscribeGetResponse>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        [JsonProperty("user_name")]
        public String UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 应用收费代码
        /// </summary>
        [XmlElement("item_code")]
        [JsonProperty("item_code")]
        public String ItemCode
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.vas.subscribe.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("user_name" ,this.UserName);
            paramters.Add("item_code" ,this.ItemCode);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("user_name", this.UserName);
            RequestValidator.ValidateRequired("item_code", this.ItemCode);
        }

    }
}
