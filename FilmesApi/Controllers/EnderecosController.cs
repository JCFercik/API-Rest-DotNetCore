using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos.Endereco;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecosController : ControllerBase
    {
        // Contexto de banco de dados
        private AppDbContext _context;
        // O Mapper
        private IMapper _mapper;
        // Construtor
        public EnderecosController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto EnderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(EnderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ConsultaEnderecoId), new { Id = endereco.EnderecoId }, endereco);
        }

        [HttpGet]
        public IEnumerable<Endereco> ConsultaEndereco()
        {
            return _context.Enderecos;
        }

        [HttpGet("{id}")]
        private object ConsultaEnderecoId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.EnderecoId == id);
            if (endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

                return Ok(enderecoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.EnderecoId == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.EnderecoId == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
