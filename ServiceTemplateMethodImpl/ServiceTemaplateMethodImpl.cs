using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceTemplateMethod
{
    abstract public class ServiceTemaplateMethodImpl
    {
        protected readonly ILogger _logger;

        protected ServiceTemaplateMethodImpl(ILogger logger)
        {
            _logger = logger;
        }

        protected TResponse TemplateMethod<TResponse, TDTO>(TDTO dto, MethodBase? invokeMethod) where TResponse : class
        {
            TResponse retVal = default(TResponse);

            try
            {
                if (invokeMethod != null)
                    _logger.LogInformation("Begin Method : {0} => {1}", invokeMethod.Name, MethodBase.GetCurrentMethod().Name);
                else
                    _logger.LogInformation("Begin Method : {0}", MethodBase.GetCurrentMethod().Name);

                _logger.LogInformation("Paramter:{0}", dto.ToString());
                #region ConcreteImplementation
                retVal = Execute(dto) as TResponse;
                _logger.LogInformation("RetVal:{0}", retVal.ToString());
                return retVal;
                #endregion
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: {0}, Stack Trace : {1}", ex.Message, ex.StackTrace);
                throw (ex);
            }
        }

        abstract protected object Execute(object dto);
    }
}
