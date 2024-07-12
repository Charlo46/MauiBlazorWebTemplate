using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Models.DTOs
{
    public class APIResponse<T>
    {
        public T? Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public APIResponse()
        {
            Data = default(T);
            StatusCode = 200;
            Message = string.Empty;
        }

        public APIResponse(T data, int statusCode, string message)
        {
            Data = data;
            StatusCode = statusCode;
            Message = message;
        }
    }
}
