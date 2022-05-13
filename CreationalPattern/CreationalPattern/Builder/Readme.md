The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step approach. 
The Process of constructing a complex object should be generic so that the same construction process can be used 
to create different representations of the same complex object.

So, the Builder Design Pattern is all about separating the construction process from its representation. When the 
construction process of your object is very complex then only you need to use to Builder Design Pattern.


In order to separate the construction process from its representation, the builder design pattern Involve `four`
components. They are as follows.

-	#####Builder: The Builder is an interface that defines all the steps which are used to make the concrete product.

-	#####Concrete Builder: The ConcreteBuilder class implements the Builder interface and provides implementation to all the 
	abstract methods. The Concrete Builder is responsible for constructs and assembles the individual parts of the product 
	by implementing the Builder interface. It also defines and tracks the representation it creates.

-	#####Director: The Director takes those individual processes from the Builder and defines the sequence to build the product.

-	#####Product: The Product is a class and we want to create this product object using the builder design pattern. 
	This class defines different parts that will make the product.


#### When to use the Builder Design Pattern in real-time applications?

We need to use the Builder Design Pattern in real-time applications in the following scenarios.
-	When you want to make a complex object by specifying only its type and content. The built object is constructed 
	from the details of its construction.

-	When you decouple the process of building a complex object from the parts that make up the object.

-	When you want to isolate the code for construction and representation.