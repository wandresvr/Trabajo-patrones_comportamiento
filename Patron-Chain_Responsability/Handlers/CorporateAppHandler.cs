using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Handlers
{
    public class CorporateAppHandler : PasswordResetHandler
    {
        public override void Handle(PasswordResetRequest request)
        {
            if (request.VerifiedViaCorporateApp)
            {
                Console.WriteLine("[CorporateAppHandler] Contraseña restablecida mediante app corporativa.");
            }
            else
            {
                Console.WriteLine("[CorporateAppHandler] App corporativa no verificada, pasando al siguiente.");
                Next?.Handle(request);
            }
        }
    }

}