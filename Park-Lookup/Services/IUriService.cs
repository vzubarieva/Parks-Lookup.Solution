using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Park_Lookup.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}