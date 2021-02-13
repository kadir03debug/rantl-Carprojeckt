using System;
using System.Collections.Generic;
using System.Text;

namespace core.Utilities.Results
{
   public class SuccesDataResult<T> :DataResult<T>
    {
        public SuccesDataResult(T data,string mg ):base(true,data,mg)
        {

        }
        public SuccesDataResult(T data ):base(true,data)
        {

        }

        public SuccesDataResult():base(default,true)
        {

        }
        public SuccesDataResult(string mg ):base(default,true,mg)
        {

        }

    }
}
