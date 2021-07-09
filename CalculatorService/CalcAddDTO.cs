using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAddService
{
    public class CalcAddDTO
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public override string ToString()
        {
            var retVal = Newtonsoft.Json.JsonConvert.SerializeObject(this);

            return retVal;
        }
    }
}
