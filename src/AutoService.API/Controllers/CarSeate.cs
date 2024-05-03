﻿using AutoService.Application.UseCases.ServiceCases.ServiceCategoryCases.Commands;
using AutoService.Application.UseCases.ServiceCases.ServiceCategoryCases.Queries;
using AutoService.Domain.Entities.Models.ServiceModels;
using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoService.Application.UseCases.ShopCases.CarSeatCases.Commands;
using AutoService.Application.UseCases.ShopCases.CarSeatCases.Queries;
using AutoService.Domain.Entities.Models.ShopModels.CarSeatModels;

namespace AutoService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarSeatController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarSeatController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponceModel> CreateServiceCategory(CreateCarSeatCommand request)
        {
            var result = await _mediator.Send(request);
            return result;
        }
        [HttpGet]
        public async Task<IEnumerable<CarSeat>> GetAllServiceCategory([FromQuery] GetAllCarSeatsQuery request)
        {
            var result = await _mediator.Send(request);
            return result;
        }

        [HttpPut]
        public async Task<ResponceModel> UpdateServiceCategory(UpdateCarSeatCommand request)
        {
            var result = await _mediator.Send(request);
            return result;
        }

        [HttpDelete]
        public async Task<ResponceModel> DeleteServiceCategory(DeleteCarSeatCommand request)
        {
            var result = await _mediator.Send(request);
            return result;
        }
    }
}
