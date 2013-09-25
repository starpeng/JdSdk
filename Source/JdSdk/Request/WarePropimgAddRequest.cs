#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:12.88086 +08:00
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
    /// 通过api 根据商品Id，销售属性值Id增加图片 Request
    /// </summary>
    public class WarePropimgAddRequest : IJdUploadRequest<WarePropimgAddResponse>
    {
        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值Id(颜色值Id)（如果没有此ID，请输入0000000000）
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
        /// 是否把当前图片设置为主图
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_main_pic")]
        [JsonProperty("is_main_pic")]
        public Nullable<Boolean> IsMainPic
        {
            get;
            set;
        }

        /// <summary>
        /// 图片数据（注意：此参数签名时不需要添加）图片类型只支持：png和jpg的，图片须800x800的   图片不能大于130Kb
        /// </summary>
        [XmlElement("image")]
        [JsonProperty("image")]
        public FileItem Image
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.propimg.add"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<String, Object>();
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("attribute_value_id" ,this.AttributeValueId);
            paramters.Add("is_main_pic" ,this.IsMainPic);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("attribute_value_id", this.AttributeValueId);
            RequestValidator.ValidateRequired("image", this.Image);
        }

        public IDictionary<String, FileItem> GetFileParameters()
        {
            Dictionary<String, FileItem> paramters = new Dictionary<String, FileItem>();
            paramters.Add("image", this.Image);
            return paramters;
        }
    }
}
