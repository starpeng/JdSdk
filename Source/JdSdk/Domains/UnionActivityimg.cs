#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.18052
   命名空间名称   :    JdSdk.Domains
   文件名         :    UnionActivityimg
   创建时间       :    2013/7/29 22:47:52
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
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    public class UnionActivityImg
    {
        /// <summary>
        /// 图片URL
        /// </summary>
        [XmlElement("imgUrl")]
        [JsonProperty("imgUrl")]
        public String ImgUrl
        {
            get;
            set;
        }

    }
}
