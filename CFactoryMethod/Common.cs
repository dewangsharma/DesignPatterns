namespace CFactoryMethod
{
    interface ICreditCard
    {
        string GetCreditCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

    }
    internal class MoneyBackCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCreditCardType()
        {
            return "MoneyBackCard";
        }

        public int GetCreditLimit()
        {
            return 5000;
        }
    }

    internal class TitaniumCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 10;
        }

        public string GetCreditCardType()
        {
            return "TitaniumCard";
        }

        public int GetCreditLimit()
        {
            return 500;
        }
    }
}
