// -----------------------------------------------------------------------
// <copyright file= "Portfolio.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2023-01-29 21:20
// Modified by:
// Description:
// -----------------------------------------------------------------------

using Volo.Abp.Domain.Entities;

namespace Enyard.Web.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Group : AggregateRoot<Guid>
    {
        #region Initializes

        /// <summary>
        /// ctor
        /// </summary>
        protected Group()
        {
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="id">Portfolio id</param>
        /// <param name="name">Portfolio name</param>
        /// <param name="description"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Group(Guid id, string name, string description)
            : base(id)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            Id = id;
            Name = name;
            Description = description;

            CreationTime = DateTime.UtcNow;
            LastUpdateTime = CreationTime;

            Endpoints = new List<Endpoint>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Portfolio id
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Portfolio name
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Portfolio description
        /// </summary>
        public virtual string Description { get; protected set; }

        /// <summary>
        /// Creation time
        /// </summary>
        public virtual DateTime CreationTime { get; protected set; }

        /// <summary>
        /// Last update time
        /// </summary>
        public virtual DateTime LastUpdateTime { get; protected set; }

        /// <summary>
        /// Endpoints
        /// </summary>
        public IList<Endpoint> Endpoints { get; protected set; }

        #endregion
    }
}