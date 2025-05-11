using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Handlers
{
    public class EmailTokenHandler : PasswordResetHandler
    {
        public override void Handle(PasswordResetRequest request)
        {
            if (request.HasEmailToken)
            {
                Console.WriteLine("[EmailTokenHandler] Contraseña restablecida mediante enlace de correo.");
            }
            else
            {
                Console.WriteLine("[EmailTokenHandler] Sin token de email, pasando al siguiente.");
                Next?.Handle(request);
            }
        }
    }

}