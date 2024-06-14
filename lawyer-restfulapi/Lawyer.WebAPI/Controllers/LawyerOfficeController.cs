using Lawyer.DomainEntities;
using Lawyer.Service.LawyerOfficeService;
using Lawyer.WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Lawyer.WebAPI.Controllers
{
    public class LawyerOfficeController : APIControllerBase
    {
        private ILawyerOfficeService _lawyerOfficeService;

        private readonly ILogger<LawyerOfficeController> _log;

        public LawyerOfficeController(ILawyerOfficeService lawyerOfficeService, ILogger<LawyerOfficeController> log)
        {
            _lawyerOfficeService = lawyerOfficeService;
            _log = log;
        }

        [AllowAnonymous]
        [HttpGet("")]
        public IActionResult GetAllLawyerOffices()
        {

            List<LawyerOfficeModel> lawyerOfficeModels = new List<LawyerOfficeModel>();

            _lawyerOfficeService.GetAlls().ToList().ForEach(l =>
            {
                LawyerOfficeModel lawyerOfficeModel = new LawyerOfficeModel
                {
                    ID = l.ID,
                    Name = l.Name,
                    ImgProfile = l.ImgProfile,
                    Address = l.Address,
                    Latitude = l.Latitude,
                    Longtitude = l.Longtitude,
                    Introduction = l.Introduction,
                    Price = l.Price,
                    WorkingTime = l.WorkingTime,
                    Email = l.Email,
                    Phone = l.Phone,
                    HomePage = l.HomePage,
                    Others = l.Others
                };

                lawyerOfficeModels.Add(lawyerOfficeModel);
            });

            return Ok(lawyerOfficeModels);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetLawyerOfficeByID(int? id)
        {

            if (id.HasValue && id != 0)
            {
                var lawyerOffice = _lawyerOfficeService.Get(id.Value);

                if (lawyerOffice != null)
                {
                    LawyerOfficeModel lawyerOfficeModel = new LawyerOfficeModel
                    {
                        ID = lawyerOffice.ID,
                        Name = lawyerOffice.Name,
                        ImgProfile = lawyerOffice.ImgProfile,
                        Address = lawyerOffice.Address,
                        Latitude = lawyerOffice.Latitude,
                        Longtitude = lawyerOffice.Longtitude,
                        Introduction = lawyerOffice.Introduction,
                        Price = lawyerOffice.Price,
                        WorkingTime = lawyerOffice.WorkingTime,
                        Email = lawyerOffice.Email,
                        Phone = lawyerOffice.Phone,
                        HomePage = lawyerOffice.HomePage,
                        Others = lawyerOffice.Others
                    };
                    return Ok(lawyerOfficeModel);
                }

                return NotFound(new { message = "Not found Lawyer Office" });

            }

            return BadRequest(new { message = "ID of lawyer office is invalid" });

        }

        [HttpPost]
        public IActionResult AddLawyerOficce([FromBody] LawyerOfficeModel model)
        {
            var userId = GetUserIdLogin();
            LawyerOffice lawyerOffice = new LawyerOffice
            {
                Name = model.Name,
                ImgProfile = model.ImgProfile,
                Address = model.Address,
                Latitude = model.Latitude,
                Longtitude = model.Longtitude,
                Introduction = model.Introduction,
                Price = model.Price,
                WorkingTime = model.WorkingTime,
                Email = model.Email,
                Phone = model.Phone,
                HomePage = model.HomePage,
                CreatedUser = userId,
                UpdatedUser = userId
            };

            _lawyerOfficeService.Insert(lawyerOffice);
            return Ok(lawyerOffice);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LawyerOfficeModel model)
        {
            var userId = GetUserIdLogin();

            LawyerOffice lawyerOffice = _lawyerOfficeService.Get(id);

            lawyerOffice.Name = model.Name;
            lawyerOffice.ImgProfile = model.ImgProfile;
            lawyerOffice.Address = model.Address;
            lawyerOffice.Latitude = model.Latitude;
            lawyerOffice.Longtitude = model.Longtitude;
            lawyerOffice.Introduction = model.Introduction;
            lawyerOffice.Price = model.Price;
            lawyerOffice.WorkingTime = model.WorkingTime;
            lawyerOffice.Email = model.Email;
            lawyerOffice.Phone = model.Phone;
            lawyerOffice.HomePage = model.HomePage;
            lawyerOffice.UpdatedUser = userId;

            _lawyerOfficeService.Update(lawyerOffice);

            return Ok(lawyerOffice);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _lawyerOfficeService.Delete(id);
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("nearest")]
        public IActionResult GetNearestLawyerOffices()
        {

            List<LawyerOfficeModel> lawyerOfficeModels = new List<LawyerOfficeModel>();

            _lawyerOfficeService.GetAlls().ToList().ForEach(l =>
            {
                LawyerOfficeModel lawyerOfficeModel = new LawyerOfficeModel
                {
                    ID = l.ID,
                    Name = l.Name,
                    ImgProfile = l.ImgProfile,
                    Address = l.Address,
                    Latitude = l.Latitude,
                    Longtitude = l.Longtitude,
                    Introduction = l.Introduction,
                    Price = l.Price,
                    WorkingTime = l.WorkingTime,
                    Email = l.Email,
                    Phone = l.Phone,
                    HomePage = l.HomePage,
                    Others = l.Others
                };

                lawyerOfficeModels.Add(lawyerOfficeModel);
            });

            return Ok(lawyerOfficeModels);
        }
    }
}
