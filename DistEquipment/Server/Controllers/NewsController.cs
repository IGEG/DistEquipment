﻿using DistEquipment.Client.Services;
using DistEquipment.Server.Data;
using DistEquipment.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDataNews = DistEquipment.Server.Data.IDataNews;

namespace DistEquipment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IDataNews _dataNews;

        public NewsController(IDataNews dataNews)
        {
            _dataNews = dataNews;
        }


        [HttpGet]
        public async Task<ActionResult<List<News>>> GetNews()
        { 
           return Ok(await _dataNews.GetNews());
        }

        [HttpGet("{Url}")]
        public async Task<ActionResult<News>> GetNewsByUrl(string Url)
        {
            return Ok(await _dataNews.GetNewsByURL(Url));
        }
    }
}
