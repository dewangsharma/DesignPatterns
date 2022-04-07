// See https://aka.ms/new-console-template for more information

/*
 * - - - - - - - - - - - - - - - - - - - - - - Factory Method Design Pattern - - - - - - - - - - - - - - - - - - - - - -
 * 
 * "Define an interface for creating the object but let the subclasses decide which class to instantiate.
 *  The Factory Method lets a class defer instantiation it uses to subclasses."
 * 
 * 
 * Follow these steps:
 *  1. Create a Product interface i.e. ICreditCard
 *  2. Create concrete Products i.e. MoneyBackCard, TitaniumCard
 *  3. Create an abstract Factory (Abstract of Creator of Product) i.e. CreditCardFactory 
 *  4. Create concrete Factory (Creator of Product) i.e. MoneyBackCardFactory, TitaniumCardFactory
 *  5. Consuming Factory Method in Client code i.e. as done belove in Main_FactoryMethod()
 */


using CFactoryMethod;

Console.WriteLine("Example of Factory Method Design Pattern");

Main_FactoryMethod();

void Main_FactoryMethod()
{
    var cardType = "MoneyBackCard";
    ICreditCard card;
    if (cardType == "MoneyBackCard")
        card = new MoneyBackCardFactory().GetProduct();
    else
        card = new TitaniumCardFactory().GetProduct();

    Console.WriteLine($"Card: { card.GetCreditCardType()}, Limit: {card.GetCreditLimit() }");
    Console.ReadLine();

    // OR 
    // But this approach is also partially a Abstract Factory Design Pattern
    var factoryType = "TitaniumFactory";
    CreditCardFactory cardFactory;
    if (factoryType == "MoneyBackFactory")
        cardFactory = new MoneyBackCardFactory();
    else
        cardFactory = new TitaniumCardFactory();
    ICreditCard creditCard = cardFactory.GetProduct();
    Console.WriteLine($"Credit Card: { creditCard.GetCreditCardType()}, Limit: {creditCard.GetCreditLimit() }");
    Console.ReadLine();
}