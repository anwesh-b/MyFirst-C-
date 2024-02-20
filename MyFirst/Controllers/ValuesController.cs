﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFirst.Model;

namespace MyFirst.Controllers
{
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this._logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Error")]
        public ErrorResponseHandler Errorhandler() { 
            _logger.LogError("Error aayo");

            return new ErrorResponseHandler
            {
                statusCode = 500,
                statusMessage = "Error aayo sedd."
                // message: "Some message"
            };
        }
    }
}
