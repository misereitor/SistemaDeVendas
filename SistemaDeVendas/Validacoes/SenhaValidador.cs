using FluentValidation;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Validacoes
{
    public class SenhaValidador : AbstractValidator<UsuarioModel>
    {
        public SenhaValidador()
        {
            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(8).WithMessage("A senha deve ter no mínimo 8 caracteres.")
                .MaximumLength(20).WithMessage("A senha deve ter no máximo 20 caracteres.")
                .Must(ContemCaracteresEspeciais).WithMessage("A senha deve conter pelo menos um caractere especial.")
                .Must(ContemLetrasMaiusculas).WithMessage("A senha deve conter pelo menos uma letra maiúscula.")
                .Must(ContemLetrasMinusculas).WithMessage("A senha deve conter pelo menos uma letra minúscula.")
                .Must(ContemDigitos).WithMessage("A senha deve conter pelo menos um dígito.");
        }

        private bool ContemCaracteresEspeciais(string senha)
        {
            return !string.IsNullOrEmpty(senha) && senha.Any(c => !char.IsLetterOrDigit(c));
        }

        private bool ContemLetrasMaiusculas(string senha)
        {
            return !string.IsNullOrEmpty(senha) && senha.Any(c => char.IsUpper(c));
        }

        private bool ContemLetrasMinusculas(string senha)
        {
            return !string.IsNullOrEmpty(senha) && senha.Any(c => char.IsLower(c));
        }

        private bool ContemDigitos(string senha)
        {
            return !string.IsNullOrEmpty(senha) && senha.Any(c => char.IsDigit(c));
        }
    }
}
