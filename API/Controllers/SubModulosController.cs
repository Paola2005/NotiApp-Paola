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
            var subModulos = _mapper.Map<SubModulos>(subModulosDto);
            if (subModulos.FechaCreacion == DateTime.MinValue)
            {
                subModulos.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.SubsModulos.Add(subModulos);
            await _unitOfWork.SaveAsync();
            if (subModulos == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = subModulosDto.Id }, subModulosDto);
            var retorno = await _unitOfWork.SubsModulos.GetByIdAsync(subModulos.Id);
            return _mapper.Map<SubModulosDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<SubModulosDto>> Put(int id, SubModulosDto subModulosDto)
        {
            if (subModulosDto.FechaModificacion == DateTime.MinValue)
            {
                subModulosDto.FechaModificacion = DateTime.Now;
            }
            if (subModulosDto.Id == 0)
            {
                subModulosDto.Id = id;
            }
            if (subModulosDto.Id != id)
            {
                return NotFound();
            }
            if (subModulosDto == null)
            {
                return BadRequest();
            }
            var subModulos = _mapper.Map<SubModulos>(subModulosDto);
            _unitOfWork.SubsModulos.Update(subModulos);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<SubModulosDto>(subModulosDto);
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