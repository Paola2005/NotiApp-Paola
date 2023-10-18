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
    public class ModulosMaestrosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ModulosMaestrosController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ModulosMaestrosDto>>> Get()
        {
            var moduloMaestros = await _unitOfWork.ModuloMaestros.GetAllAsync();
            return _mapper.Map<List<ModulosMaestrosDto>>(moduloMaestros);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ModulosMaestrosDto>> Get(int id)
        {
            var moduloMaestros = await _unitOfWork.ModuloMaestros.GetByIdAsync(id);
            if (moduloMaestros == null)
            {
                return NotFound();
            }
            return _mapper.Map<ModulosMaestrosDto>(moduloMaestros);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ModulosMaestrosDto>> Post(ModulosMaestrosDto moduloMaestrosDto)
        {
            var moduloMaestros = _mapper.Map<ModulosMaestros>(moduloMaestrosDto);
            if (moduloMaestros.FechaCreacion == DateTime.MinValue)
            {
                moduloMaestros.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.ModuloMaestros.Add(moduloMaestros);
            await _unitOfWork.SaveAsync();
            if (moduloMaestros == null)
            {
                return BadRequest();
            }
            moduloMaestrosDto.Id = moduloMaestros.Id;
            return CreatedAtAction(nameof(Post), new { id = moduloMaestrosDto.Id }, moduloMaestrosDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ModulosMaestrosDto>> Put(int id, [FromBody] ModulosMaestrosDto moduloMaestrosDto)
        {
            if (moduloMaestrosDto == null)
                return NotFound();
            var moduloMaestros = _mapper.Map<ModulosMaestros>(moduloMaestrosDto);
            if (moduloMaestros.FechaModificacion == DateTime.MinValue)
            {
                moduloMaestros.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.ModuloMaestros.Update(moduloMaestros);
            await _unitOfWork.SaveAsync();
            return moduloMaestrosDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var moduloMaestros = await _unitOfWork.ModuloMaestros.GetByIdAsync(id);
            if (moduloMaestros == null)
            {
                return NotFound();
            }
            _unitOfWork.ModuloMaestros.Remove(moduloMaestros);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}