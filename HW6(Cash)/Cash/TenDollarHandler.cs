namespace Cash.BanknotesHandler.DollarsHandlers
{
    public class TenDollarHandler : DollarHandler
    {
        protected override int Value => 10;

        public TenDollarHandler(BanknotHandler nextHandler) : base(nextHandler) { }
    }
}