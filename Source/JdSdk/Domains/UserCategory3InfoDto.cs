#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.18052
   命名空间名称   :    JdSdk.Domains
   文件名         :    UserCategory3InfoDto
   创建时间       :    2013/9/7 18:32:33
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
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    public class UserCategory3InfoDto
    {
        /// <summary>
        /// 供应商简码 
        /// </summary>
        /// <example> </example>
        [XmlElement("providerCode")]
        [JsonProperty("providerCode")]
        public String ProviderCode
        {
            get;
            set;
        }

        /// <summary>
        /// 三级分类列表 
        /// </summary>
        /// <example> </example>
        [XmlElement("userCategory3Dtos")]
        [JsonProperty("userCategory3Dtos")]
        public List<UserCategory3Dto> UserCategory3Dtos
        {
            get;
            set;
        }

    }
}
