using System;
using System.Collections.Generic;
using System.Text;

namespace core.Utilities.Results
{
   public class succesresult:Result
    {
        public succesresult():base(true)
        {

        }
        public succesresult(string message ):base(true,message)
        {

        }

    }
}
