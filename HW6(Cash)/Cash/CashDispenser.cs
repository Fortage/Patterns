using System.Collections.Generic;
using Cash.BanknotesHandler;
using Cash.BanknotesHandler.DollarsHandlers;
using Cash.BanknotesHandler.EurosHandlers;
using Cash.BanknotesHandler.RublesHandlers;


namespace Cash
{
    public class CashDispenser
    {
        private readonly BanknotHandler handler;

        public CashDispenser()
        {
            handler = new TenRubleHandler(null);
            handler = new FiftyRubleHandler(handler);
            handler = new HundredRubleHandler(handler);
            handler = new TenEurHandler(handler);
            handler = new FiftyEurHandler(handler);
            handler = new HundredEurHandler(handler);
            handler = new TenDollarHandler(handler);
            handler = new FiftyDollarHandler(handler);
            handler = new HundredDollarHandler(handler);
        }

        public bool Validate(string banknote) => handler.Validate(banknote);
        public IEnumerable<IBanknote> GetCash(string sumToCashOut) => handler.GetCash(sumToCashOut);
    }
}