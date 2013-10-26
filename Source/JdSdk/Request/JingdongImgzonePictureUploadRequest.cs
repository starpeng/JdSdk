#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.22592 +08:00
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
    /// 上传单张图片 Request
    /// </summary>
    public class JingdongImgzonePictureUploadRequest : JdRequestBase<JingdongImgzonePictureUploadResponse>
    {
        /// <summary>
        /// 图片二进制文件流，允许png、jpg、gif、jpeg、bmp图片格式，1M以内。
        /// </summary>
        [XmlElement("image_data")]
        [JsonProperty("image_data")]
        public List<byte> ImageData
        {
            get;
            set;
        }

        /// <summary>
        /// 上传到的图片分类ID，为空上传至 默认分类
        /// </summary>
        [XmlElement("picture_cate_id")]
        [JsonProperty("picture_cate_id")]
        public Int64 PictureCateId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片名称，不超过64字节，为空默认 未命名
        /// </summary>
        [XmlElement("picture_name")]
        [JsonProperty("picture_name")]
        public String PictureName
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.picture.upload"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("image_data" ,this.ImageData);
            paramters.Add("picture_cate_id" ,this.PictureCateId);
            paramters.Add("picture_name" ,this.PictureName);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("image_data", this.ImageData);
        }

    }
}
