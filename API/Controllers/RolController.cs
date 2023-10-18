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
    public class RolController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RolDto>>> Get()
        {
            var roles = await _unitOfWork.Roles.GetAllAsync();
            return _mapper.Map<List<RolDto>>(roles);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RolDto>> Get(int id)
        {
            var roles = await _unitOfWork.Roles.GetByIdAsync(id);
            if (roles == null)
            {
                return NotFound();
            }
            return _mapper.Map<RolDto>(roles);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<RolDto>> Post(RolDto rolDto)
        {
            var rol = _mapper.Map<Rol>(rolDto);
            if (rol.FechaCreacion == DateTime.MinValue)
            {
                rol.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.Roles.Add(rol);
            await _unitOfWork.SaveAsync();
            if (rol == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = rolDto.Id }, rolDto);
            var retorno = await _unitOfWork.Roles.GetByIdAsync(rol.Id);
            return _mapper.Map<RolDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RolDto>> Put(int id, RolDto rolDto)
        {
            if (rolDto.FechaModificacion == DateTime.MinValue)
            {
                rolDto.FechaModificacion = DateTime.Now;
            }
            if (rolDto.Id == 0)
            {
                rolDto.Id = id;
            }
            if (rolDto.Id != id)
            {
                return NotFound();
            }
            if (rolDto == null)
            {
                return BadRequest();
            }
            var rol = _mapper.Map<Rol>(rolDto);
            _unitOfWork.Roles.Update(rol);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<RolDto>(rolDto);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var roles = await _unitOfWork.Roles.GetByIdAsync(id);
            if (roles == null)
            {
                return NotFound();
            }
            _unitOfWork.Roles.Remove(roles);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}