using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrimeNG.TableFilter.Example.Infrastructure;
using PrimeNG.TableFilter.Example.Infrastructure.Entities;
using PrimeNG.TableFilter.Example.ViewModels;
using PrimeNG.TableFilter.Models;

namespace PrimeNG.TableFilter.Example.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IRepository<WebBoardData> _webBoardRepository;

        public HomeController(IRepository<WebBoardData> webBoardRepository)
        {
            _webBoardRepository = webBoardRepository;
        }

        public IActionResult Index([FromBody] TableFilterModel tableFilterPayload)
        {
            var totalRecord = 0;
            var result = _webBoardRepository
                .Gets()
                .Select(o => new WebBoardViewModel
                {
                    No = o.No,
                    Question = o.Question,
                    Email = o.Email,
                    Name = o.Name
                })
                .PrimengTableFilter(tableFilterPayload, ref totalRecord);
            return Ok(new GenericResponseViewModel<List<WebBoardViewModel>>(totalRecord, result.ToList()));
        }
    }
}