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
    public class ModuloNotificacionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ModuloNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ModuloNotificacionDto>>> Get()
        {
            var modulosNotificaciones = await _unitOfWork.ModulosNotificaciones.GetAllAsync();
            return _mapper.Map<List<ModuloNotificacionDto>>(modulosNotificaciones);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ModuloNotificacionDto>> Get(int id)
        {
            var modulosNotificaciones = await _unitOfWork.ModulosNotificaciones.GetByIdAsync(id);
            if (modulosNotificaciones == null)
            {
                return NotFound();
            }
            return _mapper.Map<ModuloNotificacionDto>(modulosNotificaciones);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ModuloNotificacionDto>> Post(ModuloNotificacionDto moduloNotificacionDto)
        {
            var moduloNotificacion = _mapper.Map<ModuloNotificacion>(moduloNotificacionDto);
            if (moduloNotificacion.FechaCreacion == DateTime.MinValue)
            {
                moduloNotificacion.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.ModulosNotificaciones.Add(moduloNotificacion);
            await _unitOfWork.SaveAsync();
            if (moduloNotificacion == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = moduloNotificacionDto.Id }, moduloNotificacionDto);
            var retorno = await _unitOfWork.ModulosNotificaciones.GetByIdAsync(moduloNotificacion.Id);
            return _mapper.Map<ModuloNotificacionDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ModuloNotificacionDto>> Put(int id, ModuloNotificacionDto moduloNotificacionDto)
        {
            if (moduloNotificacionDto.FechaModificacion == DateTime.MinValue)
            {
                moduloNotificacionDto.FechaModificacion = DateTime.Now;
            }
            if (moduloNotificacionDto.Id == 0)
            {
                moduloNotificacionDto.Id = id;
            }
            if (moduloNotificacionDto.Id != id)
            {
                return NotFound();
            }
            if (moduloNotificacionDto == null)
            {
                return BadRequest();
            }
            var moduloNotificacion = _mapper.Map<ModuloNotificacion>(moduloNotificacionDto);
            _unitOfWork.ModulosNotificaciones.Update(moduloNotificacion);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<ModuloNotificacionDto>(moduloNotificacionDto);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var modulosNotificaciones = await _unitOfWork.ModulosNotificaciones.GetByIdAsync(id);
            if (modulosNotificaciones == null)
            {
                return NotFound();
            }
            _unitOfWork.ModulosNotificaciones.Remove(modulosNotificaciones);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}