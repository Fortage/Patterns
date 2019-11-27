namespace Cash.BanknotesHandler.DollarsHandlers
{
    public class HundredDollarHandler : DollarHandler
    {
        protected override int Value => 100;

        public HundredDollarHandler(BanknotHandler nextHandler) : base(nextHandler) { }
    }
}