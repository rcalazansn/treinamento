using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RCN.Api.ViewModel;
using RCN.Business.Interfaces;
using RCN.Business.Interfaces.Services;
using RCN.Business.Model;
using RCN.Business.Notificacoes;
using RCN.Data.Context;

namespace RCN.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FornecedoresController
        (
            IFornecedorRepository fornecedorRepository,
            IFornecedorService fornecedorService,
            IMapper mapper,
            INotificador notificador,
            ILogger<FornecedoresController> logger
        ) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        //[ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> GetFornecedores()
        {
           // throw new Exception("Gerando erro!");

            _logger.LogError("Obtendo todos os forncedores");
            return Ok(await _fornecedorRepository.Obter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorViewModel>> Get(Guid id)
        {

            _logger.LogDebug($">>>>>>>>>>>>>>>>>>>>Fornecedor ID:{id}");
            _logger.LogInformation($">>>>>>>>>>>>>>>>>>>>Fornecedor ID:{id}");
            _logger.LogWarning($">>>>>>>>>>>>>>>>>>>>Fornecedor ID:{id}");
            _logger.LogError($">>>>>>>>>>>>>>>>>>>>Fornecedor ID:{id}");
            _logger.LogCritical($">>>>>>>>>>>>>>>>>>>>Fornecedor ID:{id}");

            var fornecedor = await _fornecedorRepository.Obter(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, FornecedorEditarViewModel fornecedorVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != fornecedorVM.Id)
            {
                return BadRequest();
            }

            await _fornecedorService.Editar(_mapper.Map<Fornecedor>(fornecedorVM));

            return Result("Registro alterado com sucesso");
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor>> Post(FornecedorAdicionarViewModel fornecedorVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            await _fornecedorService.Inserir(_mapper.Map<Fornecedor>(fornecedorVM));

            return Result("Regitro incluido com sucesso");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> Delete(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null) return NotFound();

            await _fornecedorService.Apagar(fornecedor);

            return Result(fornecedor);
        }
    }
}
