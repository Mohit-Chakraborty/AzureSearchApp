using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSearchApp
{
    internal static class Extensions
    {
        /// <summary>
        /// Convert an AsyncPageable into a List.
        /// </summary>
        /// <typeparam name="T">Type of elements.</typeparam>
        /// <param name="pageable">The AsyncPageable.</param>
        /// <returns>A list of the elements.</returns>
        public static async Task<List<T>> ToListAsync<T>(this AsyncPageable<T> pageable)
        {
            List<T> values = new();
            await foreach (T value in pageable)
            {
                values.Add(value);
            }
            return values;
        }
    }
}
