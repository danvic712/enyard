// -----------------------------------------------------------------------
// <copyright file= "IAsyncStorage.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2022-10-29 17:00
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Enyard.Web.Entities;
using Endpoint = Enyard.Web.Entities.Endpoint;

namespace Enyard.Web.Storage
{
    public interface IAsyncStorage
    {
        Task<Tuple<long, IList<Group>>> GetPagedListAsync(string keyword, string orderBy = "", int page = 1,
            int size = 20);

        Task<Group> GetByIdAsync(Guid id);

        Task<Group> InsertAsync(Group portfolio);

        Task<Group> UpdateAsync(Guid id);

        Task<bool> DeleteAsync(Guid id);

        Task<Tuple<long, IList<Entities.Endpoint>>> GetEndpointPagedListAsync(Guid portfolioId, string keyword,
            string orderBy = "", int page = 1,
            int size = 20);
    }
}