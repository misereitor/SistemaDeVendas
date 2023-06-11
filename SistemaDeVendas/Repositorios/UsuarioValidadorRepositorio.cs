using DocumentValidator;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Repositorios.Interfaces;

namespace SistemaDeVendas.Repositorios
{
    public class UsuarioValidadorRepositorio : IUsuarioValidadorRepositorio
    {
        private readonly ConexaoDBContext _dbContext;

        public UsuarioValidadorRepositorio(ConexaoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> UsuarioExclusivo(string usuario)
        {
            bool existe = await _dbContext.Usuarios.AnyAsync(u => u.Usuario == usuario);
            return !existe;
        }

        public async Task<bool> EmailExclusivo(string email)
        {
            bool existe = await _dbContext.Usuarios.AnyAsync(u => u.Email == email);
            return !existe;
        }

        public bool CNPJValidador(string cnpj)
        {
            return CnpjValidation.Validate(cnpj);
        }

        public bool CPFValidador(string cpf)
        {
            return CpfValidation.Validate(cpf);
        }

        public bool RGValidador(string rg)
        {
            return RGValidation.Validate(rg);
        }
    }
}