// -----------------------------------------------------------------------
// <copyright file= "IPortfolioAppService.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-02-04 08:56
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Ingos.SwaggerFinder.Web.Applications.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ingos.SwaggerFinder.Web.Applications.Contracts;

public interface IPortfolioAppService : IApplicationService
{
    Task<PagedResultDto<PortfolioDto>> GetPortfoliosAsync(PagedAndSortedResultRequestDto filterDto);

    Task<PortfolioDto> GetPortfolioByIdAsync(Guid portfolioId);

    Task<ResourceOperationDto<PortfolioDto>> CreateAsync(PortfolioDto portfolioDto);
        
    Task<ResourceOperationDto<PortfolioDto>> UpdateAsync(PortfolioDto portfolioDto);

    Task<ResourceOperationDto<PortfolioDto>> DeleteAsync(Guid portfolioId);
}