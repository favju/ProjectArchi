using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CardsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public CardsController(SchoolContext context)
        {
            _context = context;
        }
    }
}
