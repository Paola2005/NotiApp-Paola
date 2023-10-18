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
    public class RolvsMaestroController:BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolvsMaestroController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RolvsMaestrosDto>>> Get()
        {
            var rolsvsMaestros = await _unitOfWork.RolsvsMaestros.GetAllAsync();
            return _mapper.Map<List<RolvsMaestrosDto>>(rolsvsMaestros);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RolvsMaestrosDto>> Get(int id)
        {
            var rolsvsMaestros = await _unitOfWork.RolsvsMaestros.GetByIdAsync(id);
            if (rolsvsMaestros == null)
            {
                return NotFound();
            }
            return _mapper.Map<RolvsMaestrosDto>(rolsvsMaestros);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RolvsMaestrosDto>> Post(RolvsMaestrosDto rolvsMaestrosDto)
        {
            var rolsvsMaestros = _mapper.Map<RolvsMaestro>(rolvsMaestrosDto);
            if (rolsvsMaestros.FechaCreacion == DateTime.MinValue)
            {
                rolsvsMaestros.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.RolsvsMaestros.Add(rolsvsMaestros);
            await _unitOfWork.SaveAsync();
            if (rolsvsMaestros == null)
            {
                return BadRequest();
            }
            rolvsMaestrosDto.Id = rolsvsMaestros.Id;
            return CreatedAtAction(nameof(Post), new { id = rolvsMaestrosDto.Id }, rolvsMaestrosDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RolvsMaestrosDto>> Put(int id, [FromBody] RolvsMaestrosDto rolvsMaestrosDto)
        {
            if (rolvsMaestrosDto == null)
                return NotFound();
            var rolsvsMaestros = _mapper.Map<RolvsMaestro>(rolvsMaestrosDto);
            if (rolsvsMaestros.FechaModificacion == DateTime.MinValue)
            {
                rolsvsMaestros.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.RolsvsMaestros.Update(rolsvsMaestros);
            await _unitOfWork.SaveAsync();
            return rolvsMaestrosDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var rolsvsMaestros = await _unitOfWork.RolsvsMaestros.GetByIdAsync(id);
            if (rolsvsMaestros == null)
            {
                return NotFound();
            }
            _unitOfWork.RolsvsMaestros.Remove(rolsvsMaestros);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}