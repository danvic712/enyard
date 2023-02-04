// -----------------------------------------------------------------------
// <copyright file= "ModulesController.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-02-03 22:28
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace Ingos.AspNetCore.Swagger.Controllers
{
    [ApiController]
    [Route("api/portfolios/{portfolioId}")]
    public class ModulesController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping() => "Pong";
    }
}