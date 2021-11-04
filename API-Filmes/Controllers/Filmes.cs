using API_Filmes.Data;
using API_Filmes.Data.Dtos;
using API_Filmes.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Filmes : Controller
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public Filmes(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFilmes()
        {
            return Ok(_context.Filmes);
        }

        [HttpGet("{id}")]
        public IActionResult GetFilmeById(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
                return Ok(filme);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult PostFilme([FromBody]CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);

            _context.Filmes.Add(filme);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetFilmeById), new { Id = filme.Id }, filme);
        }

        [HttpPut("{id}")]
        public IActionResult PutFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            
            if (filme == null)
            {
                return NotFound();
            }
            
            _mapper.Map(filmeDto, filme);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilme (int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            
            if(filme != null)
            {
                _context.Remove(filme);
                _context.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }




    }
}
