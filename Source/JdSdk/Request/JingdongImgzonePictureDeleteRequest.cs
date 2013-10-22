#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.73918 +08:00
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
    /// 删除图片 Request
    /// </summary>
    public class JingdongImgzonePictureDeleteRequest : JdRequestBase<JingdongImgzonePictureDeleteResponse>
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

        public override String ApiName
        {
            get { return "jingdong.imgzone.picture.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("picture_ids", this.PictureIds);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("picture_ids", this.PictureIds);
        }

    }
}
