using AutoService.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.UseCases.CarCases.CarCases.Commands
{
    public class CreateCarCommand : IRequest<ResponceModel>
    {
        public string Brand { get; set; }
        public string CarModel { get; set; }
        public DateTimeOffset ProdYear { get; set; }
        public string VINcode { get; set; }
        public string UserId { get; set; }
    }
}
