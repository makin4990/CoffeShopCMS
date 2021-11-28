using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, bool isSuccess, string message) : base(data, isSuccess, message)
        {
        }

        public ErrorDataResult(T data, bool isSuccess) : base(data, isSuccess)
        {
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
