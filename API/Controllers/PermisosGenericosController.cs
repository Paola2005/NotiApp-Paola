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

        public PermisosGenericosController(IUnitOfWork unitOfWork, IMapper mapper)
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
            var permisosGenericos = _mapper.Map<PermisosGenericos>(permisosGenericosDto);
            if (permisosGenericos.FechaCreacion == DateTime.MinValue)
            {
                permisosGenericos.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.PermisoGenerico.Add(permisosGenericos);
            await _unitOfWork.SaveAsync();
            if (permisosGenericos == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = permisosGenericosDto.Id }, permisosGenericosDto);
            var retorno = await _unitOfWork.PermisoGenerico.GetByIdAsync(permisosGenericos.Id);
            return _mapper.Map<PermisosGenericosDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PermisosGenericosDto>> Put(int id, PermisosGenericosDto permisosGenericosDto)
        {
            if (permisosGenericosDto.FechaModificacion == DateTime.MinValue)
            {
                permisosGenericosDto.FechaModificacion = DateTime.Now;
            }
            if (permisosGenericosDto.Id == 0)
            {
                permisosGenericosDto.Id = id;
            }
            if (permisosGenericosDto.Id != id)
            {
                return NotFound();
            }
            if (permisosGenericosDto == null)
            {
                return BadRequest();
            }
            var permisosGenericos = _mapper.Map<PermisosGenericos>(permisosGenericosDto);
            _unitOfWork.PermisoGenerico.Update(permisosGenericos);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<PermisosGenericosDto>(permisosGenericosDto);
        }
        [HttpDelete("{id}")]
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