#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 18:18:09.00021 +08:00
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
    /// 订购关系查询（根据购买用户名和收费项目代码获取订购关系时长） Request
    /// </summary>
    public class JingdongVasSubscribeGetRequest : JdRequestBase<JingdongVasSubscribeGetResponse>
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

        public override String ApiName
        {
            get { return "jingdong.vas.subscribe.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("user_name", this.UserName);
            paramters.Add("item_code", this.ItemCode);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("user_name", this.UserName);
            RequestValidator.ValidateRequired("item_code", this.ItemCode);
        }

    }
}
