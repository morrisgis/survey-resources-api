using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PagedDataRequest
    {
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 25;

        [Optional]
        public List<DataFilter> filter { get; set; }

        [Optional]
        public List<DataSort> order { get; set; }
    }
}
