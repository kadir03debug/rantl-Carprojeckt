using System;
using System.Collections.Generic;
using System.Text;
using core.Utilities.Results;
namespace core.Utilities.Results
{
   public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(string mg,T data ):base(false,data,mg)
        {

        }
        public ErrorDataResult(T data ):base(false,data)
        {

        }
        public ErrorDataResult(string mg ):
           base (default,false,mg)
        {

        }
        public ErrorDataResult( ):base(default,false)
        {

        }

    }
}
