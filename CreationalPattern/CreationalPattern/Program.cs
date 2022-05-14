using CreationalPattern.Singleton;
using CreationalPattern.Prototype;
using CreationalPattern.Builder;
using CreationalPattern.Factory;
using CreationalPattern.FactoryMethod;
using CreationalPattern.AbstractFactory;


/*Singleton*/
Logger fromFather = Logger.GetLogger();
fromFather.Write("Father instantiated");

Logger fromMother = Logger.GetLogger();
fromMother.Write("Mother instantiated");


/*Prototype*/
Zoombie zoombie = new Zoombie();
zoombie.Look = "Red";
zoombie.Health = 100;
zoombie.Strength = 200;
zoombie.Speed = 300;

//clone the object form the prototype
var zoombie1 = zoombie.Copy();
Console.WriteLine(zoombie1.Look);

/*Builder*/
CarBuilder builder = new CarBuilder();
Car c = builder.AddColor("Red")
    .AddDoor()
    .AddWheels()
    .AddEngine()
    .Build();


/*Factory*/
CreditCard cardDetails = CardFactory.GetCard("Titanium");

if(cardDetails != null)
{
    Console.WriteLine(cardDetails.GetCardType());
    Console.WriteLine(cardDetails.GetCreditLimit());
    Console.WriteLine(cardDetails.GetAnnualCharge());
}


/*Factory Method*/
var creditCard = new PlatinumFactory().Create();

if(creditCard != null)
{
    Console.WriteLine(creditCard.GetCardType());
    Console.WriteLine(creditCard.GetCreditLimit());
    Console.WriteLine(creditCard.GetAnnualCharge());
}


/*Abstract Factory*/
MilitaryFactory militaryFactory = new AmericanMilitaryFactory();

Fighter fighter = militaryFactory.GetFighter();//F16
Ship ship = militaryFactory.GetShip();//Carrier