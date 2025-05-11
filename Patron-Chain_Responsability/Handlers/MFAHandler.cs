using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Handlers
{
    public class MFAHandler : PasswordResetHandler
    {
        public override void Handle(PasswordResetRequest request)
        {
            if (request.PassedMFA)
            {
                Console.WriteLine("[MFAHandler] Contraseña restablecida mediante MFA.");
            }
            else
            {
                Console.WriteLine("[MFAHandler] MFA no disponible o fallido, pasando al siguiente.");
                Next?.Handle(request);
            }
        }
    }

}