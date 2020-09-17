using Claro.Domain.Entities;
using Claro.Domain.Interfaces.Repositories;
using Claro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Claro.Domain.Services
{
    public class CelularService : ServiceBase<Celular>, ICelularServices
    {
        private readonly ICelularRepository _celularRepository;

        public CelularService(ICelularRepository celularRepository) : base(celularRepository)
        {
            _celularRepository = celularRepository;
        }
    }
}