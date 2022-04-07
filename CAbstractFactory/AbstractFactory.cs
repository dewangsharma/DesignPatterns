namespace CAbstractFactory
{
    internal abstract class CreditCardFactory
    {
        internal abstract string Name { get; }
        internal abstract ICreditCard GetProduct(string cardType);

        internal static CreditCardFactory GetCreditCardFactory(string factoryType)
        {
            if (factoryType.ToLower() == "personal")
                return new PersonalCardFactory();
            if (factoryType.ToLower() == "business")
                return new BusinessCardFactory();

            throw new NotImplementedException($"FactoryType: {factoryType}");
        }
    }

    internal class PersonalCardFactory : CreditCardFactory
    {
        internal override string Name { get; } = "Personal CreditCard Factory";
        internal override ICreditCard GetProduct(string cardType)
        {
            if (cardType.ToLower() == "moneyback")
            {
                return new MoneyBackCard();
            }
            if (cardType.ToLower() == "titaniumcard")
            {
                return new TitaniumCard();
            }
            throw new NotImplementedException($"CardType: {cardType}");
        }
    }

    internal class BusinessCardFactory : CreditCardFactory
    {
        internal override string Name { get; } = "Business CreditCard Factory";
        internal override ICreditCard GetProduct(string cardType)
        {
            if (cardType.ToLower() == "executivecard")
            {
                return new ExecutiveCard();
            }
            if (cardType.ToLower() == "enterprisecard")
            {
                return new EnterpriseCard();
            }
            throw new NotImplementedException($"CardType: {cardType}");
        }
    }
}
