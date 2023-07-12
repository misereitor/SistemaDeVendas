using DocumentValidator;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;
using SistemaDeVendas.TratamentoDeErros;

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
            bool existe;
            try
            {
                existe = await _dbContext.Usuarios.AnyAsync(u => u.Usuario == usuario);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return !existe;
        }

        public async Task<bool> EmailExclusivo(string email)
        {
            bool existe;
            try
            {
                existe = await _dbContext.Usuarios.AnyAsync(u => u.Email == email);
            }
            catch (Exception ex)
            {
                throw new ErrosException(500, ex.Message);
            }
            return !existe;
        }

        public bool CNPJValidador(UsuarioModel usuario)
        {
            if (usuario.TipoPessoa == Enums.TipoPessoa.juridica)
            {
                return CnpjValidation.Validate(usuario.CNPJ);
            }
            return true;
        }

        public bool CPFValidador(UsuarioModel usuario)
        {
            if (usuario.TipoPessoa == Enums.TipoPessoa.fisica)
            {
                return CpfValidation.Validate(usuario.CPF);
            }
            return true;
        }

        public bool RGValidador(UsuarioModel usuario)
        {
            if (usuario.TipoPessoa == Enums.TipoPessoa.fisica)
            {
                return RGValidation.Validate(usuario.RG);
            }
            return true;
        }

        public bool PesoaJuridica(UsuarioModel usuario)
        {
            bool validacao = true;
            if (usuario.TipoPessoa == Enums.TipoPessoa.juridica)
            {
                if (usuario.CPF.Length > 0 || usuario.RG.Length > 0)
                {
                    Console.WriteLine("Juridica");
                    Console.WriteLine(!CNPJValidador(usuario));
                    validacao = false;
                }
            }
            return validacao;
        }

        public bool PesoaFisica(UsuarioModel usuario)
        {
            if (usuario.TipoPessoa == Enums.TipoPessoa.fisica)
            {
                if (usuario.CNPJ.Length > 0 || usuario.IE.Length > 0 || usuario.IM.Length > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}