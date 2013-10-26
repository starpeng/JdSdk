#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.22692 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 上传单张图片 Response
    /// </summary>
    public class JingdongImgzonePictureUploadResponse : JdResponse
    {
        /// <summary>
        /// 返回码：1，操作成功；0，操作失败
        /// </summary>
        [XmlElement("return_code")]
        [JsonProperty("return_code")]
        public Int64 ReturnCode
        {
            get;
            set;
        }

        /// <summary>
        /// 返回码为1时为操作成功，返回码为0时为操作失败原因
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        /// <summary>
        /// 上传成功的图片url以业务名开头，如g0/M0/00/00/xx.jpg，使用时需加上前缀：http://域名/imgzone/，其中域名可为： img10/img11/img12/img13/img14/img20/img30.360buyimg.com 等。 如需要引用不同大小的图片，只需在类似 http://img10.360buyimg.com/imgzone/之后加上规定的尺寸大小即可。图片空间支持的尺寸有：800x800, 160x160, 130x130, 100x100, 50x50, 800x600, 347x260, 150x113, 130x98, 50x38, 350x350, 100x75, 0x0, 350x450, 220x283, 50x64引入示例（正常）： http://img10.360buyimg.com/imgzone/g0/M0/00/00/xx.jpg 指定尺寸：http://img10.360buyimg.com/imgzone/s800x800_g0/M0/00/00/xx.jpg
        /// </summary>
        [XmlElement("picture_url")]
        [JsonProperty("picture_url")]
        public String PictureUrl
        {
            get;
            set;
        }

    }
}
