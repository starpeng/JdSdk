#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.13315 +08:00
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
    /// 添加图片分类 Request
    /// </summary>
    public class JingdongImgzoneCategoryAddRequest : IJdRequest<JingdongImgzoneCategoryAddResponse>
    {
        /// <summary>
        /// 分类名称，自动过滤特殊字符
        /// </summary>
        [XmlElement("cate_name")]
        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        /// <summary>
        /// 父分类ID，为空默认添加顶级分类
        /// </summary>
        [XmlElement("parent_cate_id")]
        [JsonProperty("parent_cate_id")]
        public Int64 ParentCateId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.imgzone.category.add"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cate_name" ,this.CateName);
            paramters.Add("parent_cate_id" ,this.ParentCateId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
