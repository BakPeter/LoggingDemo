using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAddService
{
    public class CalcAddResponse
    {
        public bool RequestSuccess { get; set; }
        public int Result { get; set; }

        public override string ToString()
        {
            var retVal = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            return retVal;
        }
    }
}
