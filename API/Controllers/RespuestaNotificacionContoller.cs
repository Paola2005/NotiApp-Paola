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
    public class RespuestaNotificacionContoller : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RespuestaNotificacionContoller(IUnitOfWork unitOfWork, IMapper mapper)
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
            var respuestasNotificaciones = _mapper.Map<RespuestaNotificacion>(respuestaNotificacionDto);
            if (respuestasNotificaciones.FechaCreacion == DateTime.MinValue)
            {
                respuestasNotificaciones.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.RespuestasNotificaciones.Add(respuestasNotificaciones);
            await _unitOfWork.SaveAsync();
            if (respuestasNotificaciones == null)
            {
                return BadRequest();
            }
            respuestaNotificacionDto.Id = respuestasNotificaciones.Id;
            return CreatedAtAction(nameof(Post), new { id = respuestaNotificacionDto.Id }, respuestaNotificacionDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RespuestaNotificacionDto>> Put(int id, [FromBody] RespuestaNotificacionDto respuestaNotificacionDto)
        {
            if (respuestaNotificacionDto == null)
                return NotFound();
            var respuestasNotificaciones = _mapper.Map<RespuestaNotificacion>(respuestaNotificacionDto);
            if (respuestasNotificaciones.FechaModificacion == DateTime.MinValue)
            {
                respuestasNotificaciones.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.RespuestasNotificaciones.Update(respuestasNotificaciones);
            await _unitOfWork.SaveAsync();
            return respuestaNotificacionDto;
        }
        [HttpDelete]
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