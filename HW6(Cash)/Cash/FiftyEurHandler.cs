namespace Cash.BanknotesHandler.EurosHandlers
{
    public class FiftyEurHandler : EurHandler
    {
        public FiftyEurHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 50;
    }
}