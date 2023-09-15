using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Dtos;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controller;
[ApiVersion("1.0")]
[ApiVersion("1.1")]

    public class ChefController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public ChefController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ChefDto>>> Get()
        {
            var Chef = await unitOfWork.Chef.GetAllAsync();
            return _mapper.Map<List<ChefDto>>(Chef);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Chef>>Post(ChefDto ChefDto){
            var chef = _mapper.Map<Chef>(ChefDto);
            this.unitOfWork.Chef.Add(chef);
            await unitOfWork.SaveAsync();
            if (chef == null)
            {
                return BadRequest();
            }
            
            return CreatedAtAction(nameof(Post), new{id = ChefDto}, ChefDto);
            
        }

        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriaDto>> Put(string id, [FromBody]CategoriaDto CategoriaDto){
            if(CategoriaDto == null)
                return NotFound();
            var categoria = _mapper.Map<Categoria>(CategoriaDto);
            unitOfWork.Categoria.Update(categoria);
            await unitOfWork.SaveAsync();
            return CategoriaDto;
        }
    }
