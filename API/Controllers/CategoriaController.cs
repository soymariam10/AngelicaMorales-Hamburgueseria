using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Aplicacion.UnitOfWork;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]

    public class CategoriaController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

    public CategoriaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<CategoriaDto>>> Get()
        {
            var categorias = await unitOfWork.Categoria.GetAllAsync();
            return _mapper.Map<List<CategoriaDto>>(categorias);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Categoria>>Post(CategoriaDto categoriaDto){
            var categoria = _mapper.Map<Categoria>(categoriaDto);
            this.unitOfWork.Categoria.Add(categoria);
            await unitOfWork.SaveAsync();
            if (categoria == null)
            {
                return BadRequest();
            }
            categoriaDto.Id = categoria.Id;
            return CreatedAtAction(nameof(Post), new{id = categoriaDto}, categoriaDto);
            
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
