namespace Cash.BanknotesHandler.RublesHandlers
{
    public class HundredRubleHandler : RubleHandler
    {
        public HundredRubleHandler(BanknotHandler nextHandler) : base(nextHandler) { }

        protected override int Value => 100;
    }
}