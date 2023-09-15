using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]

    public class IngredienteController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;

        public IngredienteController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

    }
