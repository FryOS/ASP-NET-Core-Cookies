using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    interface IRepository
    {
        IEnumerable<cookie> GetAllCookies();
        Cookie GetCookieById(int id);
    }
}
