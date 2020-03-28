using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IHolder.Business.Interfaces.Notifications;
using IHolder.Business.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IHolder.Api.Controllers.Base
{
    [ApiController]
    public class ResponseBaseController : ControllerBase
    {
        protected readonly INotifier _notifier;
        protected readonly IMapper _mapper;
        public ResponseBaseController(INotifier notifier, IMapper mapper)
        {
            _notifier = notifier;
            _mapper = mapper;
        }

        protected ActionResult ResponseBase(object result = null)
        {
            if (IsValid())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });

            }
            return BadRequest(new
            {
                success = false,
                errors = _notifier.GetNotifications().Select(n => n.Message)
            });

        }

        protected ActionResult ResponseBase(ModelStateDictionary modelState)
        {
            if (!ModelState.IsValid)
                NotifyModelError(modelState);
            return ResponseBase();
        }

        protected bool IsValid()
        {
            return !_notifier.HasNotification();
        }

        protected void NotifyError(string message)
        {
            _notifier.AddNotification(new Notification(message));
        }

        protected void NotifyModelError(ModelStateDictionary modelState)
        {

            IEnumerable<ModelError> errors = ModelState.Values.SelectMany(e => e.Errors);
            foreach (var item in errors)
            {
                var errorMessage = item.Exception == null ? item.ErrorMessage : item.Exception.Message;
                NotifyError(errorMessage);
            }
        }

    }
}