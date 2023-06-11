using FluentValidation;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces;

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

            RuleFor(usuario => usuario.CPF)
                .Length(11).WithMessage("O CPF deve conter 11 caracteres.")
                .Must(CPFValidador).WithMessage("CPF inválido.");

            RuleFor(usuario => usuario.CNPJ)
                .Length(14).WithMessage("O CNPJ deve conter 14 caracteres.")
                .Must(CNPJValidador).WithMessage("CNPJ inválido.");

            RuleFor(usuario => usuario.RG)
                .Length(9).WithMessage("O RG deve conter 9 caracteres.")
                .Must(RGValidador).WithMessage("RG inválido.");
        }

        private async Task<bool> EmailExclusivo(string email, CancellationToken cancellationToken)
        {
            return await _usuarioValidadorRepositorio.EmailExclusivo(email);
        }

        private async Task<bool> UsuarioExclusivo(string usuario, CancellationToken cancellationToken)
        {
            return await _usuarioValidadorRepositorio.UsuarioExclusivo(usuario);
        }

        private bool CPFValidador(string cpf)
        {
            return _usuarioValidadorRepositorio.CPFValidador(cpf);
        }

        private bool CNPJValidador(string cnpj)
        {
            return _usuarioValidadorRepositorio.CNPJValidador(cnpj);
        }

        private bool RGValidador(string rg)
        {
            return _usuarioValidadorRepositorio.RGValidador(rg);
        }
    }
}