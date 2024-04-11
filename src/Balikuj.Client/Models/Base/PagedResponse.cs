using System.Collections.Generic;

namespace Balikuj.Client.Models.Base
{
    public class PagedResponse<T> where T : class
    {
        public IList<T> Data { get; set; }

        /// <summary>
        /// Total number of records
        /// </summary>
        public int Total { get; set; }
    }
}
