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
    public class PermisosGenericosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PermisosGenericosController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PermisosGenericosDto>>> Get()
        {
            var permisoGenerico = await _unitOfWork.PermisoGenerico.GetAllAsync();
            return _mapper.Map<List<PermisosGenericosDto>>(permisoGenerico);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PermisosGenericosDto>> Get(int id)
        {
            var permisoGenerico = await _unitOfWork.PermisoGenerico.GetByIdAsync(id);
            if (permisoGenerico == null)
            {
                return NotFound();
            }
            return _mapper.Map<PermisosGenericosDto>(permisoGenerico);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PermisosGenericosDto>> Post(PermisosGenericosDto permisosGenericosDto)
        {
            var permisoGenerico = _mapper.Map<PermisosGenericos>(permisosGenericosDto);
            if (permisoGenerico.FechaCreacion == DateTime.MinValue)
            {
                permisoGenerico.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.PermisoGenerico.Add(permisoGenerico);
            await _unitOfWork.SaveAsync();
            if (permisoGenerico == null)
            {
                return BadRequest();
            }
            permisosGenericosDto.Id = permisoGenerico.Id;
            return CreatedAtAction(nameof(Post), new { id = permisosGenericosDto.Id }, permisosGenericosDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PermisosGenericosDto>> Put(int id, [FromBody] PermisosGenericosDto permisosGenericosDto)
        {
            if (permisosGenericosDto == null)
                return NotFound();
            var permisoGenerico = _mapper.Map<PermisosGenericos>(permisosGenericosDto);
            if (permisoGenerico.FechaModificacion == DateTime.MinValue)
            {
                permisoGenerico.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.PermisoGenerico.Update(permisoGenerico);
            await _unitOfWork.SaveAsync();
            return permisosGenericosDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var permisoGenerico = await _unitOfWork.PermisoGenerico.GetByIdAsync(id);
            if (permisoGenerico == null)
            {
                return NotFound();
            }
            _unitOfWork.PermisoGenerico.Remove(permisoGenerico);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}