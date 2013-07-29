#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:16.80330 +08:00
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
    /// 添加卖家自定义类目。 Request
    /// </summary>
    public class SellercatAddRequest : IJdRequest<SellercatAddResponse>
    {
        /// <summary>
        /// 父类目编号，如果类目为店铺下的一级类目：值等于0，如果类目为子类目，调用获取360buy.warecats.get父类目编号
        /// </summary>
        /// <example>12</example>
        [XmlElement("parent_id")]
        [JsonProperty("parent_id")]
        public String ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// 卖家自定义类目名称。
        /// </summary>
        /// <example>店铺类目</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 是否展开（false，不展开；true，展开）
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_open")]
        [JsonProperty("is_open")]
        public String IsOpen
        {
            get;
            set;
        }

        /// <summary>
        /// 是否在首页展示商品（false，前台不展示，true前台展示）
        /// </summary>
        /// <example>false</example>
        [XmlElement("is_home_show")]
        [JsonProperty("is_home_show")]
        public String IsHomeShow
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.sellercat.add"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("parent_id" ,this.ParentId);
            paramters.Add("name" ,this.Name);
            paramters.Add("is_open" ,this.IsOpen);
            paramters.Add("is_home_show" ,this.IsHomeShow);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("parent_id", this.ParentId);
            RequestValidator.ValidateRequired("name", this.Name);
        }

    }
}
