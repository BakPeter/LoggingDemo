using Microsoft.Extensions.Logging;
using ServiceTemplateMethod;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CalculatorAddService
{
    public class CalculatorAddServiceImpl : ServiceTemaplateMethodImpl, ICalculatorAddService
    {
        public CalculatorAddServiceImpl(ILogger logger) : base(logger)
        {
        }

        public CalcAddResponse Add(CalcAddDTO dto)
        {
            var retVal = TemplateMethod<CalcAddResponse, CalcAddDTO>(dto, MethodBase.GetCurrentMethod());
            return retVal;
        }

        protected override object Execute(object dto)
        {
            var result = ((dto as CalcAddDTO).N1 + (dto as CalcAddDTO).N2);
            return new CalcAddResponse() { RequestSuccess = true, Result = result };
        }
    }
}
