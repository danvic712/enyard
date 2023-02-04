// -----------------------------------------------------------------------
// <copyright file= "IAsyncStorage.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2022-10-29 17:00
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Ingos.SwaggerFinder.Web.Models;

namespace Ingos.SwaggerFinder.Web.Storage
{
    public interface IAsyncStorage
    {
        Task<Tuple<long, IList<Portfolio>>> GetPagedListAsync(string keyword, string orderBy = "", int page = 1,
            int size = 20);

        Task<Portfolio> GetByIdAsync(Guid id);

        Task<Portfolio> InsertAsync(Portfolio portfolio);

        Task<Portfolio> UpdateAsync(Guid id);

        Task<bool> DeleteAsync(Guid id);

        Task<Tuple<long, IList<Module>>> GetEndpointPagedListAsync(Guid portfolioId, string keyword,
            string orderBy = "", int page = 1,
            int size = 20);
    }
}