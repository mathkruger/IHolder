using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IHolder.Api.Controllers.Base;
using IHolder.Api.ViewModels;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Services;
using IHolder.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHolder.Api.Controllers
{
    [Route("api/[controller]")]
    public class AtivoController : ResponseBaseController
    {
        private readonly IAtivoService _ativoService;
        private readonly IMapper _mapper;

        public AtivoController(IAtivoService ativoService, IMapper mapper, INotifier notifier) : base(notifier, mapper)
        {
            this._ativoService = ativoService;
            this._mapper = mapper;
        }
        [HttpGet()]
        public async Task<ActionResult> GetAll()
        {
            var response = _mapper.Map<IEnumerable<AtivoViewModel>>(await _ativoService.GetAll());

            return ResponseBase(response);
        }
    }
}