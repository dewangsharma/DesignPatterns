namespace CAbstractFactory
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

    internal class ExecutiveCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 10000;
        }

        public string GetCreditCardType()
        {
            return "ExecutiveCard";
        }

        public int GetCreditLimit()
        {
            return 5000000;
        }
    }

    internal class EnterpriseCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 5000;
        }

        public string GetCreditCardType()
        {
            return "EnterpriseCard";
        }

        public int GetCreditLimit()
        {
            return 1000000;
        }
    }
}
