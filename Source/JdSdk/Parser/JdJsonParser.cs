using System;
using Newtonsoft.Json.Linq;

namespace JdSdk.Parser
{
    /// <summary>
    /// Jd JSON响应通用解释器。
    /// </summary>
    public class JdJsonParser<T> : IJdParser<T> where T : JdResponse
    {
        public T Parse(string body)
        {
            T rsp = null;
            JObject json = JObject.Parse(body);
            if (json != null && json.First != null)
            {
                JObject data = (JObject)json.First.First;
                if (data != null)
                {
                    rsp = data.ToObject<T>();
                }
            }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }
    }
}
