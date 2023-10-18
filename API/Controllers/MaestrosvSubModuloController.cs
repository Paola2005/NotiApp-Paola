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
    public class MaestrosvSubModuloController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MaestrosvSubModuloController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<MaestrosvSubModulosDto>>> Get()
        {
            var maestrosvSubsModulos = await _unitOfWork.MaestrosvSubsModulos.GetAllAsync();
            return _mapper.Map<List<MaestrosvSubModulosDto>>(maestrosvSubsModulos);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MaestrosvSubModulosDto>> Get(int id)
        {
            var maestrosvSubsModulos = await _unitOfWork.MaestrosvSubsModulos.GetByIdAsync(id);
            if (maestrosvSubsModulos == null)
            {
                return NotFound();
            }
            return _mapper.Map<MaestrosvSubModulosDto>(maestrosvSubsModulos);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MaestrosvSubModulosDto>> Post(MaestrosvSubModulosDto maestrosvSubsModulosDto)
        {
            var maestrosvSubsModulos = _mapper.Map<MaestrosvSubModulos>(maestrosvSubsModulosDto);
            if (maestrosvSubsModulos.FechaCreacion == DateTime.MinValue)
            {
                maestrosvSubsModulos.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.MaestrosvSubsModulos.Add(maestrosvSubsModulos);
            await _unitOfWork.SaveAsync();
            if (maestrosvSubsModulos == null)
            {
                return BadRequest();
            }
            maestrosvSubsModulosDto.Id = maestrosvSubsModulos.Id;
            return CreatedAtAction(nameof(Post), new { id = maestrosvSubsModulosDto.Id }, maestrosvSubsModulosDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MaestrosvSubModulosDto>> Put(int id, [FromBody] MaestrosvSubModulosDto maestrosvSubsModulosDto)
        {
            if (maestrosvSubsModulosDto == null)
                return NotFound();
            var maestrosvSubsModulos = _mapper.Map<MaestrosvSubModulos>(maestrosvSubsModulosDto);
            if (maestrosvSubsModulos.FechaModificacion == DateTime.MinValue)
            {
                maestrosvSubsModulos.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.MaestrosvSubsModulos.Update(maestrosvSubsModulos);
            await _unitOfWork.SaveAsync();
            return maestrosvSubsModulosDto;
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var maestrosvSubsModulos = await _unitOfWork.MaestrosvSubsModulos.GetByIdAsync(id);
            if (maestrosvSubsModulos == null)
            {
                return NotFound();
            }
            _unitOfWork.MaestrosvSubsModulos.Remove(maestrosvSubsModulos);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}