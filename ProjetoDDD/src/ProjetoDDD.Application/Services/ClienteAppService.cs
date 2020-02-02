using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Models;

namespace ProjetoDDD.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }
    }
}
