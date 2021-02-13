using System;
using System.Collections.Generic;
using System.Text;
using core.Utilities;
namespace core.Utilities.Results
{
    public class Result : IResults
    {
        public bool SUCCESS ;

        public string Message ;
        public Result(bool sc,string mg )
        {
            SUCCESS = sc;Message = mg;
        }
        //herduruma uygun constructor.
        public Result()
        {
            SUCCESS = SUCCESS;Message = Message;
        }

    }
}
