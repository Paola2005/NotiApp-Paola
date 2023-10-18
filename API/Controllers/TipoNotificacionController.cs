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
    public class TipoNotificacionController:BaseController
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
            var tiposNotificaciones = _mapper.Map<TipoNotificacion>(tipoNotificacionDto);
            if (tiposNotificaciones.FechaCreacion == DateTime.MinValue)
            {
                tiposNotificaciones.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.TiposNotificaciones.Add(tiposNotificaciones);
            await _unitOfWork.SaveAsync();
            if (tiposNotificaciones == null)
            {
                return BadRequest();
            }
            tipoNotificacionDto.Id = tiposNotificaciones.Id;
            return CreatedAtAction(nameof(Post), new { id = tipoNotificacionDto.Id }, tipoNotificacionDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoNotificacionDto>> Put(int id, [FromBody] TipoNotificacionDto tipoNotificacionDto)
        {
            if (tipoNotificacionDto == null)
                return NotFound();
            var tiposNotificaciones = _mapper.Map<TipoNotificacion>(tipoNotificacionDto);
            if (tiposNotificaciones.FechaModificacion == DateTime.MinValue)
            {
                tiposNotificaciones.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.TiposNotificaciones.Update(tiposNotificaciones);
            await _unitOfWork.SaveAsync();
            return tipoNotificacionDto;
        }
        [HttpDelete]
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