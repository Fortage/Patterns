namespace Cash.BanknotesHandler.DollarsHandlers
{
    public class FiftyDollarHandler : DollarHandler
    {
        protected override int Value => 50;

        public FiftyDollarHandler(BanknotHandler nextHandler) : base(nextHandler) { }
    }
}