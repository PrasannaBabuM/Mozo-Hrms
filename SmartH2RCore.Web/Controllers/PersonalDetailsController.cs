using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartH2RCore.Models.DTO.Employee;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Services.Interface.Employee;
using SmartH2RCore.Services.Service.Employee;
using System.Threading.Tasks;
using System;

namespace SmartH2RCore.Web.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonalDetailsService _personalDetailsService;

       public PersonalDetailsController(IPersonalDetailsService personalDetailsService,IMapper mapper)
       {
            _personalDetailsService = personalDetailsService;
            _mapper = mapper;
       }
        [Route("PersonalDetails")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("List", new PersonalDetailsDTO());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        

        public async Task<IActionResult> Add(PersonalDetailsDTO model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                  

                    await _personalDetailsService.AddAsync(_mapper.Map<PersonalDetails>(model));

                    TempData["Message"] = "PersonalDetails Added Successfully!";
                    TempData["Success"] = true;
                    return RedirectToAction("Index", "PersonalDetails");
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View("Add", model);
                }
            }
            return View("Add", model);
        }
    }
}
