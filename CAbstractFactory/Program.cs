// See https://aka.ms/new-console-template for more information

/*
 * - - - - - - - - - - - - - - - - - - - - - - Abstract Factory Design Pattern - - - - - - - - - - - - - - - - - - - - - -
 * 
 * “Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.”
 * 
 * In other words we can say that an Abstract Factory is a factory that creates other factories. It is also called the Factory of factories.
 * 
 *  Explaination: 
 *  We have multiple products i.e. MoneyBackCard, TitaniumCard, ExecutiveCard, EnterpriseCard
 *  These products have some properties, which allows them to be divided into 2 Categories/Factories i.e. PersonalCardFactory, BusinessCardFactory  
 *  Factory object uses the product type to return the product
 *  
 *  
 * 
 *  These are the steps for implementing the Abstract Factory Design Pattern
 *  1. Create the abstract Product i.e. ICreditCard 
    2. Create concrete Product i.e. MoneyBackCard, TitaniumCard, ExecutiveCard, EnterpriseCard
    3. Create an Abstract Factory i.e. CreditCardFactory
    4. Create a concrete Factories i.e. PersonalCardFactory, BusinessCardFactory
    5. Create the client i.e. Main_AbstractFactory
 */
using CAbstractFactory;

Console.WriteLine("Abstract Factory Design Pattern");

Main_AbstractFactory();

void Main_AbstractFactory()
{
    ICreditCard card;
    CreditCardFactory cardFactory;

    var factoryType = "business";
    var cardType = "executivecard";

    cardFactory = CreditCardFactory.GetCreditCardFactory(factoryType);
    Console.WriteLine($"Factory: { cardFactory.Name }");

    card = cardFactory.GetProduct(cardType);
    Console.WriteLine($"Card: { card.GetCreditCardType()}, Limit: {card.GetCreditLimit() }");
    Console.ReadLine();
}