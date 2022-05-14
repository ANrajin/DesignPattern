Factory Design Pattern states that “A factory is an object which is used for creating other objects”. In technical terms, 
we can say that a factory is a class with a method. That method will create and return different types of objects based on 
the input parameter, it received. In simple words, if we have a superclass and n number of subclasses, and based on the 
data provided, if we have to create and return the object of one of the subclasses, then we need to use the Factory Design 
Pattern in C#.

Factory Design pattern, we create an object without exposing the object creation logic to the client and the client will 
refer to the newly created object using a common interface. The basic principle behind the factory design pattern is that, 
at run time, we get an object of a similar type based on the parameter we pass.


#### When to use the Factory Design Pattern in real-time applications?

It would not be a good programming approach to specify the exact class name while creating the objects by the client 
which leads to tight coupling between the client and the product. To overcome this problem, we need to use the Factory 
Design Pattern in C#. This design pattern provides the client with a simple mechanism to create the object. So, we need 
to use the Factory Design Pattern in C# when

-	The Object needs to be extended to the subclasses

-	Classes don’t know what exact sub-classes it has to create

-	The Product implementation going to change over time and the Client remains unchanged


#### Problems of Simple Factory Pattern in C#

1.	This violates the open/closed design principle.

2.	We also have a tight coupling between the Factory (CreditCardFactory) class and product 
	classes (MoneyBack, Titanium, and Platinum).


#### Real-Life Example of Factory Pattern:
From Lehman’s point of view, we can say that a factory is a place where products are created. In order words, we can say that it is a
centralized place for creating products. Later, based on the order received, the appropriate product is delivered by the factory. For
example, a car factory can produce different types of cars. If you are ordering a car to the car factory, then based on your requirements
or specifications, the factory will create the appropriate car and then delivered that car to you.
