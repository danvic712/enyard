// -----------------------------------------------------------------------
// <copyright file= "PortfoliosController.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2022-10-29 16:27
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Enyard.Web.Applications.Contracts;
using Enyard.Web.Applications.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;

namespace Enyard.Web.Controllers
{
    /// <summary>
    /// Service Portfolios Endpoints
    /// </summary>
    [ApiController]
    [Route("api/portfolios")]
    public class PortfoliosController : ControllerBase
    {
        #region Initializes

        private readonly IPortfolioAppService _portfolioAppService;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="portfolioAppService"></param>
        public PortfoliosController(IPortfolioAppService portfolioAppService)
        {
            _portfolioAppService = portfolioAppService;
        }

        #endregion

        #region APIs

        /// <summary>
        /// Get service portfolios
        /// </summary>
        /// <param name="filterDto">Filter conditions</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResultDto<PortfolioDto>> GetAsync([FromQuery] PagedAndSortedResultRequestDto filterDto) =>
            await _portfolioAppService.GetPortfoliosAsync(filterDto);

        /// <summary>
        /// Get service portfolio by id
        /// </summary>
        /// <param name="portfolioId">The primary key of the portfolio</param>
        /// <returns></returns>
        [HttpGet("{portfolioId}")]
        public async Task<PortfolioDto> GetByIdAsync([FromRoute] Guid portfolioId) =>
            await _portfolioAppService.GetPortfolioByIdAsync(portfolioId);

        /// <summary>
        /// Create a new service portfolio
        /// </summary>
        /// <param name="portfolioDto">Portfolio Operation Object</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResourceOperationDto<PortfolioDto>> Create([FromBody] PortfolioDto portfolioDto)
            => await _portfolioAppService.CreateAsync(portfolioDto);
        
        /// <summary>
        /// Update a exist service portfolio
        /// </summary>
        /// <param name="portfolioDto">Portfolio Operation Object</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ResourceOperationDto<PortfolioDto>> UpdateAsync([FromBody] PortfolioDto portfolioDto)
            => await _portfolioAppService.UpdateAsync(portfolioDto);

        /// <summary>
        /// Delete a exist service portfolio
        /// </summary>
        /// <param name="portfolioId"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ResourceOperationDto<PortfolioDto>> DeleteAsync([FromRoute] Guid portfolioId) =>
            await _portfolioAppService.DeleteAsync(portfolioId);
        
        #endregion
    }
}