#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   Email          :    starpeng@vip.qq.com
   CLR版本        :    4.0.30319.269
   命名空间名称   :    JdSdk
   文件名         :    DateTimeConverter
   创建时间       :    2012/6/25 9:40:10
   用户所在的域   :    SWKEJIT410
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
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace JdSdk
{
    public class DateTimeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime)
            {
                DateTime dateTime = (DateTime)value;
                String dateTimeStr = JdUtils.FormatDateTime(dateTime);
                writer.WriteValue(dateTimeStr);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(DateTime) || objectType == typeof(DateTime?))
                return true;

            return false;
        }
    }
}




