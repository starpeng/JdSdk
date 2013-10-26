#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.92444 +08:00
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
    /// 添加商品关联版式。 Request
    /// </summary>
    public class WareTemplateAddRequest : JdRequestBase<WareTemplateAddResponse>
    {
        /// <summary>
        /// 关联版式名称，最大10个字符,必选
        /// </summary>
        /// <example>“版式1”</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 顶部模板与底部模板分别最大字符是10000个字符, 格式:{&quot;顶部内容所需要输入的内容，例如：&lt;br/&gt;&lt;H3&gt;花好月圆&lt;/H3&gt;&quot;,&quot;底部所需要输入的内容,例如：&lt;br/&gt;&lt;H3&gt;阴晴圆缺&lt;/H3&gt;&quot;},如果只添加顶部内容,格式:{&quot;顶部内容所需要输入的内容，例如：&lt;br/&gt;&lt;H3&gt;花好月圆&lt;/H3&gt;&quot;,null};如果只添加底部内容，格式:{null,&quot;底部所需要输入的内容,例如：&lt;br/&gt;&lt;H3&gt;阴晴圆缺&lt;/H3&gt;&quot;};
        /// </summary>
        /// <example>[&quot;顶部内容所需要输入的内容，例如：&lt;br/&gt;&lt;H3&gt;花好月圆&lt;/H3&gt;&quot;,null]</example>
        [XmlElement("contents")]
        [JsonProperty("contents")]
        public List<String> Contents
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("name" ,this.Name);
            paramters.Add("contents" ,this.Contents);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("contents", this.Contents);
        }

    }
}
