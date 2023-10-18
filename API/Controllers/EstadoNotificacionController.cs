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
    public class EstadoNotificacionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EstadoNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<EstadoNotificacionDto>>> Get()
        {
            var estadoNotificacions = await _unitOfWork.EstadosNotificaciones.GetAllAsync();
            return _mapper.Map<List<EstadoNotificacionDto>>(estadoNotificacions);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EstadoNotificacionDto>> Get(int id)
        {
            var estadoNotificacion = await _unitOfWork.EstadosNotificaciones.GetByIdAsync(id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }
            return _mapper.Map<EstadoNotificacionDto>(estadoNotificacion);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EstadoNotificacion>> Post(EstadoNotificacionDto estadoNotificacionDto)
        {
            var estadoNotificacion = _mapper.Map<EstadoNotificacion>(estadoNotificacionDto);
            if (estadoNotificacion.FechaCreacion == DateTime.MinValue)
            {
                estadoNotificacion.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.EstadosNotificaciones.Add(estadoNotificacion);
            await _unitOfWork.SaveAsync();
            if (estadoNotificacion == null)
            {
                return BadRequest();
            }
            estadoNotificacionDto.Id = estadoNotificacion.Id;
            return CreatedAtAction(nameof(Post), new { id = estadoNotificacionDto.Id }, estadoNotificacionDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EstadoNotificacionDto>> Put(int id, [FromBody] EstadoNotificacionDto estadoNotificacionDto)
        {
            if (estadoNotificacionDto == null)
                return NotFound();
            var estadoNotificacion = _mapper.Map<EstadoNotificacion>(estadoNotificacionDto);
            if (estadoNotificacion.FechaModificacion == DateTime.MinValue)
            {
                estadoNotificacion.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.EstadosNotificaciones.Update(estadoNotificacion);
            await _unitOfWork.SaveAsync();
            return estadoNotificacionDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var estadoNotificacion = await _unitOfWork.EstadosNotificaciones.GetByIdAsync(id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }
            _unitOfWork.EstadosNotificaciones.Remove(estadoNotificacion);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}