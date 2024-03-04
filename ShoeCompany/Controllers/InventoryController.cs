﻿using Microsoft.AspNetCore.Mvc;
using ShoeCompany.Models;
using System;
using System.Collections.Generic;

namespace ShoeCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        /// <summary> 
        /// Retrieve the entire product inventory for the company.
        /// </summary>
        /// <returns></returns>
        // GET: api/inventory
        [HttpGet(Name = "GetInventory")]
        public IEnumerable<Inventory> Get()
        {
            Inventory[] data = new Inventory[100];

            // Return dummy data
            for (int i = 0; i < 100; i++)
            {
                data[i] = new Inventory
                {
                    ProductId = i,
                    Number_in_Stock = new Random().Next(500),
                };
            }
            return data;
        }

        /// <summary>
        /// Retrieve the number in stock for the specified product 
        /// </summary>
        // GET: api/inventory/productid
        [HttpGet("{productid}", Name = "GetInventoryItem")]
        public Inventory Get(int productid)
        {
            // Return dummy data
            return new Inventory
            {
                ProductId = productid,
                Number_in_Stock = new Random().Next(500),
            };
        }
    }
}