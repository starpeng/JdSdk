#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:40.62088 +08:00
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
    /// 查询图片 Response
    /// </summary>
    public class JingdongImgzonePictureQueryResponse : JdResponse
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
        /// 查询图片的总数
        /// </summary>
        [XmlElement("total_num")]
        [JsonProperty("total_num")]
        public Int64 TotalNum
        {
            get;
            set;
        }

        /// <summary>
        /// 图片List集合
        /// </summary>
        [XmlElement("imgList")]
        [JsonProperty("imgList")]
        public List<ImgzoneImgInfo> ImgList
        {
            get;
            set;
        }

    }
}
