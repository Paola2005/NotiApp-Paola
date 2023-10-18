using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RadicadoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RadicadoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RadicadoDto>>> Get()
        {
            var radicados = await _unitOfWork.Radicados.GetAllAsync();
            return _mapper.Map<List<RadicadoDto>>(radicados);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RadicadoDto>> Get(int id)
        {
            var radicados = await _unitOfWork.Radicados.GetByIdAsync(id);
            if (radicados == null)
            {
                return NotFound();
            }
            return _mapper.Map<RadicadoDto>(radicados);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<RadicadoDto>> Post(RadicadoDto radicadoDto)
        {
            var radicado = _mapper.Map<Radicado>(radicadoDto);
            if (radicado.FechaCreacion == DateTime.MinValue)
            {
                radicado.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.Radicados.Add(radicado);
            await _unitOfWork.SaveAsync();
            if (radicado == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = radicadoDto.Id }, radicadoDto);
            var retorno = await _unitOfWork.Radicados.GetByIdAsync(radicado.Id);
            return _mapper.Map<RadicadoDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RadicadoDto>> Put(int id, RadicadoDto radicadoDto)
        {
            if (radicadoDto.FechaModificacion == DateTime.MinValue)
            {
                radicadoDto.FechaModificacion = DateTime.Now;
            }
            if (radicadoDto.Id == 0)
            {
                radicadoDto.Id = id;
            }
            if (radicadoDto.Id != id)
            {
                return NotFound();
            }
            if (radicadoDto == null)
            {
                return BadRequest();
            }
            var radicado = _mapper.Map<Radicado>(radicadoDto);
            _unitOfWork.Radicados.Update(radicado);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<RadicadoDto>(radicadoDto);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var radicados = await _unitOfWork.Radicados.GetByIdAsync(id);
            if (radicados == null)
            {
                return NotFound();
            }
            _unitOfWork.Radicados.Remove(radicados);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}