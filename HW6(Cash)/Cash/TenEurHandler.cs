namespace Cash.BanknotesHandler.EurosHandlers
{
    public class TenEurHandler : EurHandler
    {
        public TenEurHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 10;
    }
}