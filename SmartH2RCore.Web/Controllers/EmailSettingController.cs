using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Settings;
using SmartH2RCore.Services.Interface;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Web.Controllers
{
    public class EmailSettingController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IEmailSettingService _emailSettingService;

        public EmailSettingController(IEmailSettingService emailSettingService, IMapper mapper)
        {
            _emailSettingService = emailSettingService;
            _mapper = mapper;
        }

        [Route("email-setting")]
        public IActionResult EmailSetting()
        {
            var email = _emailSettingService.GetAll().FirstOrDefault();
            return View(_mapper.Map<EmailSettingDTO>(email));
        }

        [Route("email-setting"), HttpPost]
        public async Task<IActionResult> EmailSetting(EmailSettingDTO settingDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (settingDTO.Id > 0)
                    {
                        await _emailSettingService.UpdateAsync(_mapper.Map<EmailSetting>(settingDTO));
                        TempData["Message"] = "Email Setting Updated Successfully!";
                    }
                    else
                    {
                        await _emailSettingService.AddAsync(_mapper.Map<EmailSetting>(settingDTO));
                        TempData["Message"] = "Email Setting Added Successfully!";
                    }

                    TempData["Success"] = true;
                    return View(settingDTO);
                }
                catch (Exception ex)
                {
                    TempData["Message"] = ex.Message;
                    TempData["Success"] = false;
                    return View(settingDTO);
                }
            }
            return View(settingDTO);
        }
    }
}
