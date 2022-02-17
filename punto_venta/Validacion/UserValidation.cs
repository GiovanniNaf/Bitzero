using FluentValidation;
using punto_venta.Models;

namespace punto_venta.Validacion
{
    public class UserValidation : AbstractValidator <sp_InsertUser>
    {
        public UserValidation()
        {
            RuleFor(x => x.Fldname).NotEmpty().WithMessage("El nombre no puede ir vacio");
        }
    }
}
