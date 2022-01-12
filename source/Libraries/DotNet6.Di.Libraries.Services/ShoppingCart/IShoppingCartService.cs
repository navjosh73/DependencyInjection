﻿using DotNet6.Di.Libraries.Services.ShoppingCart.Models;

namespace DotNet6.Di.Libraries.Services.ShoppingCart
{
    /// <summary>
    /// Used for shopping cart methods.
    /// </summary>
    public interface IShoppingCartService
    {
        /// <summary>
        /// Sets the unique id of the shopping cart and adds it to the storage.
        /// </summary>
        /// <param name="id">Unique id of the shopping cart.</param>
        void SetId(Guid id);

        /// <summary>
        /// Gets the shopping cart model.
        /// </summary>
        /// <returns>The shopping cart as a <see cref="ShoppingCartModel"/> type.</returns>
        /// <exception cref="Exception">Returns an exception if the shopping cart cannot be found.</exception>
        public ShoppingCartModel Get();
    }
}