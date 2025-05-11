
using patron_chain_responsability.Handlers;
using patron_chain_responsability.Interfaces;
using patron_chain_responsability.Validator;    

namespace patron_chain_responsability
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Crear los handlers
            var emailHandler = new EmailTokenHandler();
            var mfaHandler = new MFAHandler();
            var corporateAppHandler = new CorporateAppHandler();
            var supportHandler = new SupportDeskHandler();

            // Construcción del orden de la cadena
            emailHandler.SetNext(mfaHandler);
            mfaHandler.SetNext(corporateAppHandler);
            corporateAppHandler.SetNext(supportHandler);

            //Usuario realizando la validación
            /*
            - No pasa el Email token porque no tiene el MFA de acceso al correo de la empresa porque no tiene su dispositivo celular
            - No pasa el MFA por la misma razón
            No pasa la app corporativa por la misma razón
            */

            var request = new PasswordResetRequest
            {
                HasEmailToken = false,
                PassedMFA = false,
                VerifiedViaCorporateApp = false
            };

            Console.WriteLine("== Iniciando recuperación de contraseña ==");
            emailHandler.Handle(request);
        }
    }

}
