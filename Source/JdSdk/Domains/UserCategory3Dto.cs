#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.18052
   命名空间名称   :    JdSdk.Domains
   文件名         :    UserCategory3Dto
   创建时间       :    2013/9/7 18:32:48
   用户所在的域   :    XPC
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    public class UserCategory3Dto
    {
        /// <summary>
        /// 三级分类编码 
        /// </summary>
        /// <example> </example>
        [XmlElement("code")]
        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }

        /// <summary>
        /// 三级分类名称 
        /// </summary>
        /// <example> </example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

    }
}
