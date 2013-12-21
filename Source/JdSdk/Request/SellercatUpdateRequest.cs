#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:11.94158 +08:00
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
    /// 更新商家自定义店内分类 Request
    /// </summary>
    public class SellercatUpdateRequest : JdRequestBase<SellercatUpdateResponse>
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        /// <example>1</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 卖家自定义类目名称
        /// </summary>
        /// <example>店铺类目名称</example>
        [XmlElement("cat_name")]
        [JsonProperty("cat_name")]
        public String CatName
        {
            get;
            set;
        }

        /// <summary>
        /// 是否在首页展示分类（false，前台不展示，true前台展示）
        /// </summary>
        /// <example>false</example>
        [XmlElement("home_show")]
        [JsonProperty("home_show")]
        public String HomeShow
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.sellercat.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid" ,this.Cid);
            paramters.Add("cat_name" ,this.CatName);
            paramters.Add("home_show" ,this.HomeShow);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
