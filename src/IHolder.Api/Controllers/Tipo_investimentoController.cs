using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IHolder.Api.Controllers.Base;
using IHolder.Api.ViewModels;
using IHolder.Business.Entities;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Services;
using IHolder.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHolder.Api.Controllers
{
    [Route("api/[controller]")]
    public class Tipo_investimentoController : ResponseBaseController
    {
        private readonly ITipo_investimentoService _tipo_InvestimentoService;
        public Tipo_investimentoController(INotifier notifier, IMapper mapper, ITipo_investimentoService tipo_InvestimentoService) : base(notifier, mapper)
        {
            _tipo_InvestimentoService = tipo_InvestimentoService;
        }

        [HttpPost()]
        public async Task<ActionResult> Insert (Tipo_investimentoViewModel model)
        {
            if (!ModelState.IsValid)
                return ResponseBase(ModelState);

            var response = await _tipo_InvestimentoService.Insert(_mapper.Map<Tipo_investimento>(model));
            return ResponseBase(response);
        }

    }
}