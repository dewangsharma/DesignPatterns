namespace CFactory
{
    public static class CredidCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType.ToLower())
            {
                case "moneyback":
                    return new MoneyBackCard();

                case "titaniumcard":
                    return new TitaniumCard();

                default:
                    throw new Exception("Cardtype cannot be created");
            }
        }
    }
}
