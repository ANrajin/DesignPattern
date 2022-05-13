We need to use the Singleton Design Pattern in C# when we need to ensures that only one instance of a particular 
class is going to be created and then provide simple global access to that instance for the entire application.


#### Advantages of using the Singleton Pattern

-	The first and most important advantage of using the singleton design pattern in C# is that 
	it takes care of concurrent access to the shared resource. That means if we are sharing a 
	resource with multiple clients simultaneously, then concurrent access to that resource is 
	well managed by the singleton design pattern.

-	It can be lazy-loaded and also has Static Initialization.

-	To share common data i.e. master data and configuration data which is not changed that frequently 
	in an application. In that case, we need to cache the objects in memory.

-	As it provides a single global point of access to a particular instance, so it is easy to maintain.

-	To reduce the overhead of instantiating a heavy object again and again.




#### Implementation Guidelines
-	You need to declare a constructor that should be private and parameterless. This is required because 
	it is not allowed the class to be instantiated from outside the class. It only instantiates from within 
	the class

-	The class should be declared as sealed which will ensure that it cannot be inherited. This is going to 
	be useful when you are dealing with the nested class. We will discuss this scenario with an example in 
	our upcoming article.

-	You need to create a private static variable that is going to hold a reference to the single created 
	instance of the class if any.

-	You also need to create a public static property/method which will return the single-created instance of 
	the singleton class. This method or property first check if an instance of the singleton class is available 
	or not. If the singleton instance is available, then it returns that singleton instance otherwise it will 
	create an instance and then return that instance.