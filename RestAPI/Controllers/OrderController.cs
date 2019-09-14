using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class OrderController : ApiController
    {
        [HttpGet]
        public string GetNomalOrder()
        {
            return "Get订单号测试";
        }

        [HttpGet]
        public string GetNomalOrder(string id)
        {
            return "Get订单号测试" + id;
        }
        [HttpGet]
        [Route("order/{type}/{id}")]
        public string GetNomalOrder(string type, string id)
        {
            return "Get订单号测试" + type + " id:" + id;
        }
        [HttpPost]
        public string PostNomalOrder()
        {
            return "Post订单号测试";
        }

        [HttpDelete]
        public string DeleteNomalOrder(string orderno)
        {
            return "Delete订单号测试";
        }
        //[HttpGet]
        //public string GetTest()
        //{
        //    return "测试";
        //}

        [HttpPost]
        public string PostTest()
        {
            return "PostTest";
        }

        [HttpPost]
        public string Test1()
        {
            return "Test1";
        }
    }
}
