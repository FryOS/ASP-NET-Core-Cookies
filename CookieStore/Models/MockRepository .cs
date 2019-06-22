using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public class MockRepository
    {
        private List<cookie> _cookies;
        public MockRepository()
        {
            if (_cookies == null) {
                InitializeRepository();
            }

        }

        private void InitializeRepository()
        {
            _cookies = new List<cookie>
            {
                new Cookie {
                    Id=1,Name="Raspberry", Price=110,
                    TinyDescription="Dark chocolate overloaded",
                    FullDescription = "This is one of the best ever soft and chewy cookie and also been awarded as the best cookie several times.",
                    IsCookieOfTheDay = false,  
                    ImageUrl = "\\Images\\1.png"
                }
            }
        }

        public Cookie GetCookie(int id)
        {
            return _cookies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<cookie> GetCookies()
        {
            return _cookies;
        }

    }
}
