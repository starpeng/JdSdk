#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.73918 +08:00
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
    /// 删除图片 Request
    /// </summary>
    public class JingdongImgzonePictureDeleteRequest : IJdRequest<JingdongImgzonePictureDeleteResponse>
    {
        /// <summary>
        /// 图片ID，批量删除时ID间以半角逗号分隔，已被引用的图片不能删除
        /// </summary>
        [XmlElement("picture_ids")]
        [JsonProperty("picture_ids")]
        public String PictureIds
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.imgzone.picture.delete"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("picture_ids" ,this.PictureIds);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("picture_ids", this.PictureIds);
        }

    }
}
