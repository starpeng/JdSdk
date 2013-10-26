#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75846 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ImgzoneImgInfo[]属性
    /// </summary>
    [Serializable]
    public class ImgzoneImgInfo : JdObject
    {
        /// <summary>
        /// 图片ID
        /// </summary>
        [XmlElement("picture_id")]
        [JsonProperty("picture_id")]
        public String PictureId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片所属分类ID
        /// </summary>
        [XmlElement("picture_cate_id")]
        [JsonProperty("picture_cate_id")]
        public Int64 PictureCateId
        {
            get;
            set;
        }

        /// <summary>
        /// 图片url，以业务名开头，如g0/M0/00/00/xx.jpg，使用时需加上前缀：http://域名/imgzone/，其中域名可为：   img10/img11/img12/img13/img14/img20/img30.360buyimg.com 等。   如需要引用不同大小的图片，只需在类似 http://img10.360buyimg.com/imgzone/   之后加上规定的尺寸大小即可，图片空间支持的尺寸有：800x800, 160x160, 130x130, 100x100, 50x50,   800x600, 347x260, 150x113, 130x98, 50x38, 350x350, 100x75, 0x0, 350x450,   220x283, 50x64，引入示例：   正常：http://img10.360buyimg.com/imgzone/g0/M0/00/00/xx.jpg   指定尺寸：http://img10.360buyimg.com/imgzone/s800x800_g0/M0/00/00/xx.jpg
        /// </summary>
        [XmlElement("picture_url")]
        [JsonProperty("picture_url")]
        public String PictureUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("picture_name")]
        [JsonProperty("picture_name")]
        public String PictureName
        {
            get;
            set;
        }

        /// <summary>
        /// 图片后缀
        /// </summary>
        [XmlElement("picture_type")]
        [JsonProperty("picture_type")]
        public String PictureType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否被引用：1，是；0，否
        /// </summary>
        [XmlElement("referenced")]
        [JsonProperty("referenced")]
        public Int64 Referenced
        {
            get;
            set;
        }

        /// <summary>
        /// 图片大小，单位b
        /// </summary>
        [XmlElement("picture_size")]
        [JsonProperty("picture_size")]
        public Int64 PictureSize
        {
            get;
            set;
        }

        /// <summary>
        /// 图片宽度，单位px
        /// </summary>
        [XmlElement("picture_width")]
        [JsonProperty("picture_width")]
        public Int64 PictureWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 图片高度，单位px
        /// </summary>
        [XmlElement("picture_height")]
        [JsonProperty("picture_height")]
        public Int64 PictureHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 图片创建时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public Nullable<DateTime> Created
        {
            get;
            set;
        }

        /// <summary>
        /// 图片修改时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public Nullable<DateTime> Modified
        {
            get;
            set;
        }

    }
}
