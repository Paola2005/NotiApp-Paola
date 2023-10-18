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
    public class RolController:BaseController
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
            var roles = _mapper.Map<Rol>(rolDto);
            if (roles.FechaCreacion == DateTime.MinValue)
            {
                roles.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.Roles.Add(roles);
            await _unitOfWork.SaveAsync();
            if (roles == null)
            {
                return BadRequest();
            }
            rolDto.Id = roles.Id;
            return CreatedAtAction(nameof(Post), new { id = rolDto.Id }, rolDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RolDto>> Put(int id, [FromBody] RolDto rolDto)
        {
            if (rolDto == null)
                return NotFound();
            var roles = _mapper.Map<Rol>(rolDto);
            if (roles.FechaModificacion == DateTime.MinValue)
            {
                roles.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.Roles.Update(roles);
            await _unitOfWork.SaveAsync();
            return rolDto;
        }
        [HttpDelete]
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