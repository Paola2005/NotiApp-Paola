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
    public class TipoRequerimientoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoRequerimientoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoRequerimientoDto>>> Get()
        {
            var paises = await _unitOfWork.TiposRequerimientos.GetAllAsync();
            return _mapper.Map<List<TipoRequerimientoDto>>(paises);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoRequerimientoDto>> Get(int id)
        {
            var pais = await _unitOfWork.TiposRequerimientos.GetByIdAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoRequerimientoDto>(pais);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoRequerimientoDto>> Post(TipoRequerimientoDto tipoRequerimientoDto)
        {
            var tiposRequerimientos = _mapper.Map<TipoRequerimiento>(tipoRequerimientoDto);
            if (tiposRequerimientos.FechaCreacion == DateTime.MinValue)
            {
                tiposRequerimientos.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.TiposRequerimientos.Add(tiposRequerimientos);
            await _unitOfWork.SaveAsync();
            if (tiposRequerimientos == null)
            {
                return BadRequest();
            }
            tipoRequerimientoDto.Id = tiposRequerimientos.Id;
            return CreatedAtAction(nameof(Post), new { id = tipoRequerimientoDto.Id }, tipoRequerimientoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoRequerimientoDto>> Put(int id, [FromBody] TipoRequerimientoDto tipoRequerimientoDto)
        {
            if (tipoRequerimientoDto == null)
                return NotFound();
            var tiposRequerimientos = _mapper.Map<TipoRequerimiento>(tipoRequerimientoDto);
            if (tiposRequerimientos.FechaModificacion == DateTime.MinValue)
            {
                tiposRequerimientos.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.TiposRequerimientos.Update(tiposRequerimientos);
            await _unitOfWork.SaveAsync();
            return tipoRequerimientoDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tiposRequerimientos = await _unitOfWork.TiposRequerimientos.GetByIdAsync(id);
            if (tiposRequerimientos == null)
            {
                return NotFound();
            }
            _unitOfWork.TiposRequerimientos.Remove(tiposRequerimientos);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}