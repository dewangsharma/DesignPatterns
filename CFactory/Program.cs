/*
 * - - - - - - - - - - - - - - - - - - - - - - Factory Design Pattern - - - - - - - - - - - - - - - - - - - - - -
 * 
 * "A factory is an object which is used for creating other objects".
 * 
 * In technical terms we can say that a factory is a class with a method. 
 * This method will create and return different types of objects, based on the input parameter it received. 
 * 
 * 
 * In simple words, if we have a super class and n number of subclasses, and based on the data provided, 
 * if we have to create and return object of one of the subclasses then we need to use Factory Design Pattern in C#. 
 * 
 * 
 * We create an object without exposing the object creation logic to the client 
 * and the client will refer to newly created objects using a common interface. Main idea of Factory Design Pattern is that at runtime, we get an object of similar type based on the parameter we pass.  
 * 
 * 
 * We can use Factory Design Pattern in C# when:
 *      - The object needs to be extended to the subclasses.
 *      - Classes don’t know what exact subclass it has to create.
 *      - The Product (CreditCard in the above example) can change over the period of time but the client remains the same.
 *
 *
 * Problem with the Factory Design Pattern: 
 *      - If we have a new Card type then we have to add a new condition in the GetCreditCard method. This violates the Open/Close principle. 
 *      - We also have tight coupling between Factory (CreditCardFactory) class and Product class.
 * We can overcome this problem by using the Factory Method Design Pattern.
 */

using CFactory;

Console.WriteLine("Factory Design Pattern:");
Console.WriteLine("'A factory is an object which is used for creating other objects'");

Without_Factory_Design_Pattern();

Factory_Design_Pattern();

/// <summary>
/// Implement the logic without the Factory Method
/// 
/// Problem without using Factory Design Pattern:
/// Tight coupling between client and the product class (credit card), 
/// so if we add a new credit card then we have to change all the clients for that.
/// </summary>
void Without_Factory_Design_Pattern()
{
    string cardType = "MoneyBack";
    ICreditCard? card = null;
    if (cardType.ToLower() == "moneyback")
    {
        card = new MoneyBackCard();
    }
    if (cardType.ToLower() == "titaniumcard")
    {
        card = new TitaniumCard();
    }
    if (card == null)
        throw new NotImplementedException();

    Console.WriteLine($"Card: { card.GetCreditCardType()}, Limit: {card.GetCreditLimit() }");
    Console.ReadLine();
}

void Factory_Design_Pattern()
{
    ICreditCard card = CredidCardFactory.GetCreditCard("MoneyBack");
    Console.WriteLine($"Card: { card.GetCreditCardType()}, Limit: {card.GetCreditLimit() }");
    Console.ReadLine();
}
