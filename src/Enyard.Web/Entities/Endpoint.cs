// -----------------------------------------------------------------------
// <copyright file= "Endpoint.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-01-29 21:42
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Volo.Abp.Domain.Entities;

namespace Enyard.Web.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Endpoint : Entity<Guid>
    {
        /// <summary>
        /// Service module name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Endpoint of swagger
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// Creation Time
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}