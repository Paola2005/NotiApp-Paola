using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class EstadoNotificacionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EstadoNotificacionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<EstadoNotificacionDto>>> Get()
        {
            var estadoNotificacions = await _unitOfWork.EstadosNotificaciones.GetAllAsync();
            return _mapper.Map<List<EstadoNotificacionDto>>(estadoNotificacions);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EstadoNotificacionDto>> Get(int id)
        {
            var estadoNotificacion = await _unitOfWork.EstadosNotificaciones.GetByIdAsync(id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }
            return _mapper.Map<EstadoNotificacionDto>(estadoNotificacion);
        }

    }
}