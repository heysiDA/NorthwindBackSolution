using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.UnitOfWork;

namespace Northwind_WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetPaginatedOrders/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedOrders(int page, int rows)
        {
            return Ok(_unitOfWork.Order.getPaginateOrder(page, rows));
        }

        [HttpGet]
        [Route("GetOrderById/{orderId:int}/")]
        public IActionResult GetOrderById(int orderId)
        {
            return Ok(_unitOfWork.Order.getOrderById(orderId));
        }
    }
}