// -----------------------------------------------------------------------
// <copyright file= "ResourceOperationDto.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-01-29 22:51
// Modified by:
// Description:
// -----------------------------------------------------------------------

namespace Enyard.Web.Applications.Dtos
{
    public class ResourceOperationDto<T> where T : class
    {
        /// <summary>
        /// Operation result
        /// </summary>
        public bool Success { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }
    }
}