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
    public class SubModulosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubModulosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<SubModulosDto>>> Get()
        {
            var subsModulos = await _unitOfWork.SubsModulos.GetAllAsync();
            return _mapper.Map<List<SubModulosDto>>(subsModulos);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SubModulosDto>> Get(int id)
        {
            var subsModulos = await _unitOfWork.SubsModulos.GetByIdAsync(id);
            if (subsModulos == null)
            {
                return NotFound();
            }
            return _mapper.Map<SubModulosDto>(subsModulos);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SubModulosDto>> Post(SubModulosDto subModulosDto)
        {
            var subsModulos = _mapper.Map<SubModulos>(subModulosDto);
            if (subsModulos.FechaCreacion == DateTime.MinValue)
            {
                subsModulos.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.SubsModulos.Add(subsModulos);
            await _unitOfWork.SaveAsync();
            if (subsModulos == null)
            {
                return BadRequest();
            }
            subModulosDto.Id = subsModulos.Id;
            return CreatedAtAction(nameof(Post), new { id = subModulosDto.Id }, subModulosDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SubModulosDto>> Put(int id, [FromBody] SubModulosDto subModulosDto)
        {
            if (subModulosDto == null)
                return NotFound();
            var subsModulos = _mapper.Map<SubModulos>(subModulosDto);
            if (subsModulos.FechaModificacion == DateTime.MinValue)
            {
                subsModulos.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.SubsModulos.Update(subsModulos);
            await _unitOfWork.SaveAsync();
            return subModulosDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var subsModulos = await _unitOfWork.SubsModulos.GetByIdAsync(id);
            if (subsModulos == null)
            {
                return NotFound();
            }
            _unitOfWork.SubsModulos.Remove(subsModulos);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}