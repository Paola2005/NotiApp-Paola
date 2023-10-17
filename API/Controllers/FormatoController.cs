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
            var formatos = _mapper.Map<Formato>(formatoDto);
            _unitOfWork.Formatos.Add(formatos);
            await _unitOfWork.SaveAsync();
            if (formatos == null)
            {
                return BadRequest();
            }
            formatoDto.Id = formatos.Id;
            return CreatedAtAction(nameof(Post), new { id = formatoDto.Id }, formatoDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FormatoDto>> Put(int id, [FromBody] FormatoDto formatoDto)
        {
            if (formatoDto == null)
                return NotFound();
            var formatos = _mapper.Map<Formato>(formatoDto);
            _unitOfWork.Formatos.Update(formatos);
            await _unitOfWork.SaveAsync();
            return formatoDto;
        }

    }
}