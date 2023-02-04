// -----------------------------------------------------------------------
// <copyright file= "Endpoint.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-01-29 21:42
// Modified by:
// Description:
// -----------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ingos.SwaggerFinder.Web.Models
{
    public class Module
    {
        protected Module()
        {
        }

        public Module(Guid id, string name, bool healthCheck, string path)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("You can not add empty path! ", nameof(path));

            Id = id;
            Name = name;
            HealthCheck = healthCheck;
            
            Paths.Add(path);
        }

        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public virtual string ServiceId => JsonNamingPolicy.CamelCase.ConvertName(Name)
            .Replace(" ", string.Empty);

        /// <summary>
        /// 
        /// </summary>
        public bool HealthCheck { get; protected set; } = false;

        /// <summary>
        /// Swagger file path
        /// </summary>
        public IList<string> Paths { get; protected set; }
    }
}