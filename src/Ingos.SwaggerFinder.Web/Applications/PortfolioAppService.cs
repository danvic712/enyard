// -----------------------------------------------------------------------
// <copyright file= "PortfolioAppService.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-02-04 09:00
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Ingos.SwaggerFinder.Web.Applications.Contracts;
using Ingos.SwaggerFinder.Web.Applications.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ingos.SwaggerFinder.Web.Applications;

public class PortfolioAppService: ApplicationService, IPortfolioAppService
{
    public async Task<PagedResultDto<PortfolioDto>> GetPortfoliosAsync(PagedAndSortedResultRequestDto filterDto)
    {
        throw new NotImplementedException();
    }

    public async Task<PortfolioDto> GetPortfolioByIdAsync(Guid portfolioId)
    {
        throw new NotImplementedException();
    }

    public async Task<ResourceOperationDto<PortfolioDto>> CreateAsync(PortfolioDto portfolioDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResourceOperationDto<PortfolioDto>> UpdateAsync(PortfolioDto portfolioDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResourceOperationDto<PortfolioDto>> DeleteAsync(Guid portfolioId)
    {
        throw new NotImplementedException();
    }
}