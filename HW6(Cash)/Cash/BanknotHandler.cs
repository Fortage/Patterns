using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cash.BanknotesHandler
{
    public abstract class BanknotHandler
    {
        private readonly BanknotHandler nextHandler;

        protected BanknotHandler(BanknotHandler nextHandler) => this.nextHandler = nextHandler;

        protected abstract int Value { get; }
        protected abstract Regex MoneyParser { get; }

        public virtual bool Validate(string banknote) => !(nextHandler is null) && nextHandler.Validate(banknote);

        public IEnumerable<IBanknote> GetCash(string sumToCashOut)
        {
            try
            {
                return GetCash(GetMoneySum(sumToCashOut));
            }
            catch (FormatException)
            {
                if (!(nextHandler is null))
                    return nextHandler.GetCash(sumToCashOut);
                throw;
            }
        }

        protected virtual IEnumerable<IBanknote> GetCash(int sum)
        {
            if (!(nextHandler is null))
                return nextHandler.GetCash(sum);

            if (sum == 0) return Enumerable.Empty<IBanknote>();

            throw new ArgumentException($"Не Валидная сумма ({sum})");
        }

        private int GetMoneySum(string money)
        {
            var match = MoneyParser.Match(money);

            if (!match.Success)
                throw new FormatException($"Неверный формат денежных средств({money})");

            if (match.Value.StartsWith('0'))
                throw new ArgumentException($"Не Валидная сумма ({money})");

            return int.Parse(match.Groups["Количество"].Value);
        }
    }
}