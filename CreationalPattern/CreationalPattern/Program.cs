using CreationalPattern.Singleton;
using CreationalPattern.Prototype;
using CreationalPattern.Builder;


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
