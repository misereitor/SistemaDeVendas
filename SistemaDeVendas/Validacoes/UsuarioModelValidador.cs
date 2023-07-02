using FluentValidation;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;

namespace SistemaDeVendas.Validacoes
{
    public class UsuarioModelValidador : AbstractValidator<UsuarioModel>
    {
        private readonly IUsuarioValidadorRepositorio _usuarioValidadorRepositorio;

        public UsuarioModelValidador(IUsuarioValidadorRepositorio usuarioValidadorRepositorio)
        {
            _usuarioValidadorRepositorio = usuarioValidadorRepositorio;

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("O campo Email é obrigatório.")
                .MaximumLength(150).WithMessage("O campo Email deve ter no máximo 150 caracteres.")
                .EmailAddress().WithMessage("O campo Email deve ser um endereço de email válido.")
                .MustAsync(EmailExclusivo).WithMessage("Este email já está em uso.");

            RuleFor(u => u.Usuario)
                .NotEmpty().WithMessage("O campo Usuário é obrigatório.")
                .MaximumLength(30).WithMessage("O campo Usuário deve ter no máximo 30 caracteres.")
                .MustAsync(UsuarioExclusivo).WithMessage("Este usuário já está em uso.");

            RuleFor(u => u)
                .Must(CPFValidador).WithMessage("CPF inválido.");

            RuleFor(u => u)
                .Must(CNPJValidador).WithMessage("CNPJ inválido.");

            RuleFor(u => u)
                .Must(RGValidador).WithMessage("RG inválido.");

            RuleFor(u => u)
                .Must(PesoaFisica).WithMessage("Pessoa fisica não pode conter um CNPJ/IE/IM");

            RuleFor(u => u)
                .Must(PesoaJuridica).WithMessage("Pessoa juridica não pode conter um CPF/RG");
        }

        private async Task<bool> EmailExclusivo(string email, CancellationToken cancellationToken)
        {
            return await _usuarioValidadorRepositorio.EmailExclusivo(email);
        }

        private async Task<bool> UsuarioExclusivo(string usuario, CancellationToken cancellationToken)
        {
            return await _usuarioValidadorRepositorio.UsuarioExclusivo(usuario);
        }

        private bool CPFValidador(UsuarioModel usuario)
        {
            return _usuarioValidadorRepositorio.CPFValidador(usuario);
        }

        private bool CNPJValidador(UsuarioModel usuario)
        {
            return _usuarioValidadorRepositorio.CNPJValidador(usuario);
        }

        private bool RGValidador(UsuarioModel usuario)
        {
            return _usuarioValidadorRepositorio.RGValidador(usuario);
        }

        private bool PesoaJuridica(UsuarioModel usuario)
        {
            return _usuarioValidadorRepositorio.PesoaJuridica(usuario);
        }
        private bool PesoaFisica(UsuarioModel usuario)
        {
            return _usuarioValidadorRepositorio.PesoaFisica(usuario);
        }
    }
}