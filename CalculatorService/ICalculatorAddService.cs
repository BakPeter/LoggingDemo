using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAddService
{
    public interface ICalculatorAddService
    {
        public CalcAddResponse Add(CalcAddDTO dto);
    }
}
