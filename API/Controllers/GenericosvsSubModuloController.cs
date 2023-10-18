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
    public class GenericosvsSubModuloController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GenericosvsSubModuloController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<GenericosvSubModulosDto>>> Get()
        {
            var genericosSubModulo = await _unitOfWork.GenericossvSubsModulos.GetAllAsync();
            return _mapper.Map<List<GenericosvSubModulosDto>>(genericosSubModulo);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GenericosvSubModulosDto>> Get(int id)
        {
            var genericosSubModulo = await _unitOfWork.GenericossvSubsModulos.GetByIdAsync(id);
            if (genericosSubModulo == null)
            {
                return NotFound();
            }
            return _mapper.Map<GenericosvSubModulosDto>(genericosSubModulo);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GenericosvSubModulosDto>> Post(GenericosvSubModulosDto genericosDto)
        {
            var genericosSubModulo = _mapper.Map<GenericosvsSubModulos>(genericosDto);

            if (genericosSubModulo.FechaCreacion == DateTime.MinValue)
            {
                genericosSubModulo.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.GenericossvSubsModulos.Add(genericosSubModulo);
            await _unitOfWork.SaveAsync();
            if (genericosSubModulo == null)
            {
                return BadRequest();
            }
            genericosDto.Id = genericosSubModulo.Id;
            return CreatedAtAction(nameof(Post), new { id = genericosDto.Id }, genericosDto);
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GenericosvSubModulosDto>> Put(int id, [FromBody] GenericosvSubModulosDto genericosDto)
        {
            if (genericosDto == null)
                return NotFound();
            var genericosSubModulo = _mapper.Map<GenericosvsSubModulos>(genericosDto);
            if (genericosSubModulo.FechaModificacion == DateTime.MinValue)
            {
                genericosSubModulo.FechaModificacion = DateTime.Now;
            }
            _unitOfWork.GenericossvSubsModulos.Update(genericosSubModulo);
            await _unitOfWork.SaveAsync();
            return genericosDto;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var genericosSubModulo  = await _unitOfWork.GenericossvSubsModulos.GetByIdAsync(id);
            if (genericosSubModulo == null)
            {
                return NotFound();
            }
            _unitOfWork.GenericossvSubsModulos.Remove(genericosSubModulo);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}