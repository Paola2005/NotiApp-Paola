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
            var tipoRequerimiento = _mapper.Map<TipoRequerimiento>(tipoRequerimientoDto);
            if (tipoRequerimiento.FechaCreacion == DateTime.MinValue)
            {
                tipoRequerimiento.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.TiposRequerimientos.Add(tipoRequerimiento);
            await _unitOfWork.SaveAsync();
            if (tipoRequerimiento == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = tipoRequerimientoDto.Id }, tipoRequerimientoDto);
            var retorno = await _unitOfWork.TiposRequerimientos.GetByIdAsync(tipoRequerimiento.Id);
            return _mapper.Map<TipoRequerimientoDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<FormatoDto>> Put(int id, FormatoDto formatoDto)
        {
            if (formatoDto.FechaModificacion == DateTime.MinValue)
            {
                formatoDto.FechaModificacion = DateTime.Now;
            }
            if (formatoDto.Id == 0)
            {
                formatoDto.Id = id;
            }
            if (formatoDto.Id != id)
            {
                return NotFound();
            }
            if (formatoDto == null)
            {
                return BadRequest();
            }
            var formato = _mapper.Map<Formato>(formatoDto);
            _unitOfWork.Formatos.Update(formato);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<FormatoDto>(formatoDto);
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