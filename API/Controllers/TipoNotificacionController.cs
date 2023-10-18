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
    public class TipoNotificacionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoNotificacionDto>>> Get()
        {
            var tiposNotificaciones = await _unitOfWork.TiposNotificaciones.GetAllAsync();
            return _mapper.Map<List<TipoNotificacionDto>>(tiposNotificaciones);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoNotificacionDto>> Get(int id)
        {
            var tiposNotificaciones = await _unitOfWork.TiposNotificaciones.GetByIdAsync(id);
            if (tiposNotificaciones == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoNotificacionDto>(tiposNotificaciones);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<TipoNotificacionDto>> Post(TipoNotificacionDto tipoNotificacionDto)
        {
            var tipoNotificacion = _mapper.Map<TipoNotificacion>(tipoNotificacionDto);
            if (tipoNotificacion.FechaCreacion == DateTime.MinValue)
            {
                tipoNotificacion.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.TiposNotificaciones.Add(tipoNotificacion);
            await _unitOfWork.SaveAsync();
            if (tipoNotificacion == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = tipoNotificacionDto.Id }, tipoNotificacionDto);
            var retorno = await _unitOfWork.TiposNotificaciones.GetByIdAsync(tipoNotificacion.Id);
            return _mapper.Map<TipoNotificacionDto>(retorno);
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
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var tiposNotificaciones = await _unitOfWork.TiposNotificaciones.GetByIdAsync(id);
            if (tiposNotificaciones == null)
            {
                return NotFound();
            }
            _unitOfWork.TiposNotificaciones.Remove(tiposNotificaciones);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}