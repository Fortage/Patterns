namespace Cash.BanknotesHandler.EurosHandlers
{
    public class HundredEurHandler : EurHandler
    {
        public HundredEurHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 100;
    }
}