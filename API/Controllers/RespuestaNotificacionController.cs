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
    public class RespuestaNotificacionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RespuestaNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RespuestaNotificacionDto>>> Get()
        {
            var respuestasNotificaciones = await _unitOfWork.RespuestasNotificaciones.GetAllAsync();
            return _mapper.Map<List<RespuestaNotificacionDto>>(respuestasNotificaciones);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RespuestaNotificacionDto>> Get(int id)
        {
            var respuestasNotificaciones = await _unitOfWork.RespuestasNotificaciones.GetByIdAsync(id);
            if (respuestasNotificaciones == null)
            {
                return NotFound();
            }
            return _mapper.Map<RespuestaNotificacionDto>(respuestasNotificaciones);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<RespuestaNotificacionDto>> Post(RespuestaNotificacionDto respuestaNotificacionDto)
        {
            var respuestaNotificacion = _mapper.Map<RespuestaNotificacion>(respuestaNotificacionDto);
            if (respuestaNotificacion.FechaCreacion == DateTime.MinValue)
            {
                respuestaNotificacion.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.RespuestasNotificaciones.Add(respuestaNotificacion);
            await _unitOfWork.SaveAsync();
            if (respuestaNotificacion == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = respuestaNotificacionDto.Id }, respuestaNotificacionDto);
            var retorno = await _unitOfWork.RespuestasNotificaciones.GetByIdAsync(respuestaNotificacion.Id);
            return _mapper.Map<RespuestaNotificacionDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RespuestaNotificacionDto>> Put(int id, RespuestaNotificacionDto respuestaNotificacionDto)
        {
            if (respuestaNotificacionDto.FechaModificacion == DateTime.MinValue)
            {
                respuestaNotificacionDto.FechaModificacion = DateTime.Now;
            }
            if (respuestaNotificacionDto.Id == 0)
            {
                respuestaNotificacionDto.Id = id;
            }
            if (respuestaNotificacionDto.Id != id)
            {
                return NotFound();
            }
            if (respuestaNotificacionDto == null)
            {
                return BadRequest();
            }
            var respuestaNotificacion = _mapper.Map<RespuestaNotificacion>(respuestaNotificacionDto);
            _unitOfWork.RespuestasNotificaciones.Update(respuestaNotificacion);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<RespuestaNotificacionDto>(respuestaNotificacionDto);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var respuestasNotificaciones = await _unitOfWork.RespuestasNotificaciones.GetByIdAsync(id);
            if (respuestasNotificaciones == null)
            {
                return NotFound();
            }
            _unitOfWork.RespuestasNotificaciones.Remove(respuestasNotificaciones);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}