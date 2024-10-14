using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Modules
{
    public class Response<T>
    {
        public string Message { get; set; }
        public bool isSuccess { get; set; }
        public T Data { get; set; }
    }
}