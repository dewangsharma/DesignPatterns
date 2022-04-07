namespace CFactoryMethod
{
    internal abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        internal ICreditCard GetProduct()        
        { 
            return this.MakeProduct();
        }
    }

    internal class MoneyBackCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBackCard();
        }
    }

    internal class TitaniumCardFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new TitaniumCard();
        }
    }
}
