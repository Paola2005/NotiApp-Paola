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
    public class FormatoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FormatoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<FormatoDto>>> Get()
        {
            var formatos = await _unitOfWork.Formatos.GetAllAsync();
            return _mapper.Map<List<FormatoDto>>(formatos);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FormatoDto>> Get(int id)
        {
            var formatos = await _unitOfWork.Formatos.GetAllAsync();
            if (formatos == null)
            {
                return NotFound();
            }
            return _mapper.Map<FormatoDto>(formatos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<FormatoDto>> Post(FormatoDto formatoDto)
        {
            var formato = _mapper.Map<Formato>(formatoDto);
            if (formato.FechaCreacion == DateTime.MinValue)
            {
                formato.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.Formatos.Add(formato);
            await _unitOfWork.SaveAsync();
            if (formato == null)
            {
                return BadRequest();
            }
            var dato = CreatedAtAction(nameof(Post), new { id = formatoDto.Id }, formatoDto);
            var retorno = await _unitOfWork.Formatos.GetByIdAsync(formato.Id);
            return _mapper.Map<FormatoDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<FormatoDto>> Put(int id, FormatoDto formatoDto)
        {
            if (formatoDto.FechaModificacion == DateTime.MinValue)
            {
                formatoDto.FechaModificacion = DateTime.Now;
            }
            if (formatoDto.Id == 0)
            {
                formatoDto.Id = id;
            }
            if (formatoDto.Id != id)
            {
                return NotFound();
            }
            if (formatoDto == null)
            {
                return BadRequest();
            }
            var formato = _mapper.Map<Formato>(formatoDto);
            _unitOfWork.Formatos.Update(formato);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<FormatoDto>(formatoDto);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var formatos = await _unitOfWork.Formatos.GetByIdAsync(id);
            if (formatos == null)
            {
                return NotFound();
            }
            _unitOfWork.Formatos.Remove(formatos);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

    }
}