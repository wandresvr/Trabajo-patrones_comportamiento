using patron_chain_responsability.Interfaces;
using patron_chain_responsability.Validator;

namespace patron_chain_responsability.Handlers
{
   public abstract class PasswordResetHandler : IPasswordResetHandler
    {
        protected IPasswordResetHandler Next;

        public void SetNext(IPasswordResetHandler next)
        {
            Next = next;
        }

        public abstract void Handle(PasswordResetRequest request);
    }
}