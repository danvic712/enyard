// -----------------------------------------------------------------------
// <copyright file= "PortfolioDto.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2022-10-29 16:53
// Modified by:
// Description:
// -----------------------------------------------------------------------

namespace Ingos.SwaggerFinder.Web.Applications.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class PortfolioDto
    {
        /// <summary>
        /// Portfolio name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Portfolio description.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Number of swaggers.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        public DateTime CreationTime { get; set; }
        
        /// <summary>
        /// Last update time.
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IList<string> Tags { get; set; } = new List<string>();
    }
}