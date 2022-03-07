using MenuItem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MenuItemController : ControllerBase
    {
        List<MenuItemDB> menuitems;
        [HttpGet("id")]
        public IActionResult GetMenuItems(int id)
        {
            menuitems = new List<MenuItemDB>()
            {
                new MenuItemDB()
                {
                    Id=1,
                    Name="Pizza",
                    freeDelivery=true,
                    Price=250,
                    dateOfLaunch=Convert.ToDateTime("2022-03-07"),
                    Active=true
                },

                new MenuItemDB()
                {
                    Id=2,
                    Name="Burger",
                    freeDelivery=false,
                    Price=155,
                    dateOfLaunch=Convert.ToDateTime("2022-03-07"),
                    Active=true
                }
            };
            var menuitem = menuitems.FirstOrDefault(mi => mi.Id == id);
            return Ok(menuitem);
        }

    }
}
