using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IHolder.Api.Controllers.Base;
using IHolder.Api.ViewModels;
using IHolder.Business.Entities;
using IHolder.Business.Interfaces;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IHolder.Api.Controllers.V1
{
    //[Authorize]
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    //public class SituacaoController : ResponseBaseController
    //{
    //    //private readonly ISituacaoService _SituacaoService;
    //    //public SituacaoController(INotifier notifier,
    //    //    IMapper mapper,
    //    //    ISituacaoService SituacaoService, IUser user)
    //    //    : base(notifier, mapper, user)
    //    //{
    //    //    _SituacaoService = SituacaoService;
    //    //}

    //    //[HttpGet]
    //    //[AllowAnonymous]
    //    //public async Task<ActionResult<IEnumerable<SituacaoViewModel>>> GetAll()
    //    //{
    //    //    IEnumerable<Situacao> response = await _SituacaoService.GetAll();
    //    //    return ResponseBase(response);
    //    //}

    //}
}