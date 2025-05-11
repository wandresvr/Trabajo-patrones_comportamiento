using patron_chain_responsability.Interfaces;
using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Handlers
{
   public class SupportDeskHandler : PasswordResetHandler
    {
        public override void Handle(PasswordResetRequest request)
        {
            if (request.NeedsHumanSupport)
            {
                Console.WriteLine("[SupportDeskHandler] Derivando al soporte técnico.");
            }
            else
            {
                Console.WriteLine("[SupportDeskHandler] No es necesario escalar.");
            }
        }
    }
}