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
    public class BlockChainController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlockChainController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<BlockChainDto>>> Get()
        {
            var blockChains = await _unitOfWork.BlockChains.GetAllAsync();
            return _mapper.Map<List<BlockChainDto>>(blockChains);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BlockChainDto>> Get(int id)
        {
            var blockChain = await _unitOfWork.BlockChains.GetByIdAsync(id);
            if (blockChain == null)
            {
                return NotFound();
            }
            return _mapper.Map<BlockChainDto>(blockChain);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<BlockChainDto>> Post(BlockChainDto blockChainDto){
            var blockChain = _mapper.Map<BlockChain>(blockChainDto);
            if (blockChain.FechaCreacion == DateTime.MinValue){
                blockChain.FechaCreacion = DateTime.Now;
            }
            _unitOfWork.BlockChains.Add(blockChain);
            await _unitOfWork.SaveAsync();
            if (blockChain == null){
                return BadRequest();
            }
            blockChainDto.Id=blockChain.Id;
            var dato = CreatedAtAction(nameof(Post), new {id = blockChainDto.Id}, blockChainDto);
            var retorno = await _unitOfWork.BlockChains.GetByIdAsync(blockChain.Id);
            return _mapper.Map<BlockChainDto>(retorno);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<BlockChainDto>> Put(int id, BlockChainDto blockChainDto){
            if (blockChainDto.FechaModificacion == DateTime.MinValue){
                blockChainDto.FechaModificacion = DateTime.Now;
            }
            if (blockChainDto.Id == 0){
                blockChainDto.Id = id;
            }
            if (blockChainDto.Id != id){
                return NotFound();
            }
            if (blockChainDto == null){
                return BadRequest();
            }
            var blockChains = _mapper.Map<BlockChain>(blockChainDto);
            _unitOfWork.BlockChains.Update(blockChains);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<BlockChainDto>(blockChainDto);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var blockChain = await _unitOfWork.BlockChains.GetByIdAsync(id);
            if (blockChain == null)
            {
                return NotFound();
            }
            _unitOfWork.BlockChains.Remove(blockChain);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}