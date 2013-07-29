#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:13.08487 +08:00
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
    /// 通过api 根据商品Id，销售属性值Id删除图片 Request
    /// </summary>
    public class WarePropimgDeleteRequest : IJdRequest<WarePropimgDeleteResponse>
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值Id(颜色值Id)
        /// </summary>
        /// <example>12345</example>
        [XmlElement("attribute_value_id")]
        [JsonProperty("attribute_value_id")]
        public String AttributeValueId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片Id
        /// </summary>
        /// <example>100</example>
        [XmlElement("image_id")]
        [JsonProperty("image_id")]
        public String ImageId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.propimg.delete"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("attribute_value_id" ,this.AttributeValueId);
            paramters.Add("image_id" ,this.ImageId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("attribute_value_id", this.AttributeValueId);
            RequestValidator.ValidateRequired("image_id", this.ImageId);
        }

    }
}
