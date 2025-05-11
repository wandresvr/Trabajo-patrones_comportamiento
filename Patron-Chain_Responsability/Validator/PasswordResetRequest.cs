namespace patron_chain_responsability.Validator
{
    public class PasswordResetRequest
    {
        public bool HasEmailToken { get; set; }
        public bool PassedMFA { get; set; }
        public bool VerifiedViaCorporateApp { get; set; }
        public bool NeedsHumanSupport => !HasEmailToken && !PassedMFA && !VerifiedViaCorporateApp;
    }

}