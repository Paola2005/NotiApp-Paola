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

        public ModulosMaestrosController(IUnitOfWork unitOfWork, IMapper mapper)
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

        public async Task<ActionResult<ModulosMaestrosDto>> Post(ModulosMaestrosDto modulosMaestrosDto)
        {
            var modulosMaestros = _mapper.Map<ModulosMaestros>(modulosMaestrosDto);
            if (modulosMaestros.FechaCreacion == DateTime.MinValue)
            {
                modulosMaestros.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.ModuloMaestros.Add(modulosMaestros);
            await _unitOfWork.SaveAsync();
            if (modulosMaestros == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = modulosMaestrosDto.Id }, modulosMaestrosDto);
            var retorno = await _unitOfWork.ModuloMaestros.GetByIdAsync(modulosMaestros.Id);
            return _mapper.Map<ModulosMaestrosDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ModulosMaestrosDto>> Put(int id, ModulosMaestrosDto modulosMaestrosDto)
        {
            if (modulosMaestrosDto.FechaModificacion == DateTime.MinValue)
            {
                modulosMaestrosDto.FechaModificacion = DateTime.Now;
            }
            if (modulosMaestrosDto.Id == 0)
            {
                modulosMaestrosDto.Id = id;
            }
            if (modulosMaestrosDto.Id != id)
            {
                return NotFound();
            }
            if (modulosMaestrosDto == null)
            {
                return BadRequest();
            }
            var modulosMaestros = _mapper.Map<ModulosMaestros>(modulosMaestrosDto);
            _unitOfWork.ModuloMaestros.Update(modulosMaestros);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<ModulosMaestrosDto>(modulosMaestrosDto);
        }
        [HttpDelete("{id}")]
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