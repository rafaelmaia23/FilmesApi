using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos.Sessao;
using FilmesApi.Models;
using FilmesApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto createSessaoDto)
        {
            ReadSessaoDto readSessaoDto = _sessaoService.AdicionaSessao(createSessaoDto);
            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = readSessaoDto.Id }, readSessaoDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
            ReadSessaoDto readSessaoDto = _sessaoService.RecuperaSessoesPorId(id);
            if (readSessaoDto != null) return Ok(readSessaoDto);
            return NotFound();
        }
    }
}
