using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Interfaces
{
        public interface IPasswordResetHandler
    {
        void SetNext(IPasswordResetHandler next);
        void Handle(PasswordResetRequest request);
    }
}