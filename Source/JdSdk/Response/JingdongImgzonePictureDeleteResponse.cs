#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:40.21486 +08:00
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
    /// 删除图片 Response
    /// </summary>
    public class JingdongImgzonePictureDeleteResponse : JdResponse
    {
        /// <summary>
        /// 返回码：1，操作成功；0，操作失败；2，部分操作成功
        /// </summary>
        [XmlElement("return_code")]
        [JsonProperty("return_code")]
        public Int64 ReturnCode
        {
            get;
            set;
        }

        /// <summary>
        /// 返回码为1时为操作成功，返回码为0时为全部删除失败，返回码为2时为部分删除成功
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        /// <summary>
        /// 成功删除数
        /// </summary>
        [XmlElement("success_num")]
        [JsonProperty("success_num")]
        public Int64 SuccessNum
        {
            get;
            set;
        }

        /// <summary>
        /// 删除失败的图片中，非法的图片ID（图片ID不存在，或者此ID对应的图片已被删除）集合
        /// </summary>
        [XmlElement("illegal")]
        [JsonProperty("illegal")]
        public List<Int64> Illegal
        {
            get;
            set;
        }

        /// <summary>
        /// 删除失败的图片中，已被引用的图片ID集合
        /// </summary>
        [XmlElement("referenced")]
        [JsonProperty("referenced")]
        public List<Int64> Referenced
        {
            get;
            set;
        }

        /// <summary>
        /// 删除过程中，出现系统异常的图片ID集合，可重试
        /// </summary>
        [XmlElement("fail")]
        [JsonProperty("fail")]
        public List<Int64> Fail
        {
            get;
            set;
        }

    }
}
