#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:46.14721 +08:00
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
    /// 查询图片 Request
    /// </summary>
    public class JingdongImgzonePictureQueryRequest : IJdRequest<JingdongImgzonePictureQueryResponse>
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
        /// 图片名称，支持后模糊查询
        /// </summary>
        [XmlElement("picture_name")]
        [JsonProperty("picture_name")]
        public String PictureName
        {
            get;
            set;
        }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束创建时间
        /// </summary>
        [XmlElement("end_Date")]
        [JsonProperty("end_Date")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 页码值，对应分页结果页数，为空或非正整数时默认为1，超过最大页数返回空
        /// </summary>
        [XmlElement("page_num")]
        [JsonProperty("page_num")]
        public Int64 PageNum
        {
            get;
            set;
        }

        /// <summary>
        /// 每页条数，为空或非正整数时默认为20，最多返回100条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.imgzone.picture.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("picture_id" ,this.PictureId);
            paramters.Add("picture_cate_id" ,this.PictureCateId);
            paramters.Add("picture_name" ,this.PictureName);
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page_num" ,this.PageNum);
            paramters.Add("page_size" ,this.PageSize);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
