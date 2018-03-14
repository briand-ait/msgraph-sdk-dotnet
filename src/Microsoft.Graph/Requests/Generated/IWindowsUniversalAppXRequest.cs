// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsUniversalAppXRequest.
    /// </summary>
    public partial interface IWindowsUniversalAppXRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsUniversalAppX using PUT.
        /// </summary>
        /// <param name="windowsUniversalAppXToCreate">The WindowsUniversalAppX to create.</param>
        /// <returns>The created WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> CreateAsync(WindowsUniversalAppX windowsUniversalAppXToCreate);        /// <summary>
        /// Creates the specified WindowsUniversalAppX using PUT.
        /// </summary>
        /// <param name="windowsUniversalAppXToCreate">The WindowsUniversalAppX to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> CreateAsync(WindowsUniversalAppX windowsUniversalAppXToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsUniversalAppX.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsUniversalAppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsUniversalAppX.
        /// </summary>
        /// <returns>The WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> GetAsync();

        /// <summary>
        /// Gets the specified WindowsUniversalAppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsUniversalAppX using PATCH.
        /// </summary>
        /// <param name="windowsUniversalAppXToUpdate">The WindowsUniversalAppX to update.</param>
        /// <returns>The updated WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> UpdateAsync(WindowsUniversalAppX windowsUniversalAppXToUpdate);

        /// <summary>
        /// Updates the specified WindowsUniversalAppX using PATCH.
        /// </summary>
        /// <param name="windowsUniversalAppXToUpdate">The WindowsUniversalAppX to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsUniversalAppX.</returns>
        System.Threading.Tasks.Task<WindowsUniversalAppX> UpdateAsync(WindowsUniversalAppX windowsUniversalAppXToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUniversalAppXRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUniversalAppXRequest Expand(Expression<Func<WindowsUniversalAppX, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUniversalAppXRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUniversalAppXRequest Select(Expression<Func<WindowsUniversalAppX, object>> selectExpression);

    }
}