using Claro.Application.Interfaces;
using Claro.Domain.Entities;
using Claro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Claro.Application
{
    public class CelularAppService : AppServiceBase<Celular>, ICelularAppService
    {
        private readonly ICelularServices _celularServices;

        public CelularAppService(ICelularServices celularServices) : base(celularServices)
        {
            _celularServices = celularServices;
        }
    }
}