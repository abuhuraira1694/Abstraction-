# Abstraction-
*Abstraction in C# using abstract classes and interfaces*

# what is abstraction?
 *abstraction is a main concept of OOP which belongs to showing only essential details and hiding interfnal details.*

# Benefits of abstraction
 * *It reduce code complexity.*
 * *Improves readability and maintainability.*
 * *Allows developers to change implementation without effecting usage.*

# How abstraction is achieved in C#?
 *In C# there are two ways to implement abstraction.*

 * using Abstract classes
 * Using Interfaces

# 1.Abstract Classes:
  * *its a class which is declared with **abstract** keyword. Abstract class is always use as base class.In abstract class we use **abstract methods** in the abstract class.
    In Abstract methods we just write method name an parameters(if method have) mean we just write method signature. we don't write any code inside the method
    mean we not write any body the method.*
  * *Abstract classes are partial abstraction means in abstract classes abstraction is not complete.*
  * *in the abstract classes we can write non-abstract methods(Normal methods).And these methods execute normaly like in other normal classes.*
  * *We can't make abstract methods **Privat** because we must have to **override** it in the derived class.*
  * *And if we make method private then Inheretance is not possible but for abstraction inheretance is compulsory.*
  * *We can not make **object** of abstract class.*
  * *we can make referance veriable of abstract class.*
  * *To use abstract classes we inherit them.*
# Example:
  ***Example_1** and **Example_2** in code files representing abstraction using abstract classes.*
  * *In Example_1 class1 is abstract class which contain two abstract methods.And this class is inherited in Class2 and in this class abstract methods are implemented and in the **Main** method an **Object** of class2 is made to call the methods.*
  * *In Example_2 class1 is abstract class which contain 3 abstract methods.and class2 inherit it and implement abstract methods.Class3 also inherit abstract class and implement abstract methods. and noteable point here is that code of that class will be execute that class object we use.*
# 2.Interfaces:
* *Interfaces are complete abstraction.*
* *all the methods we write in interface are automaticaly abstracted mean not have to write abstract keyword with them.*
* *in interface every method is abstract no any normal is method is written. but from C# 8 or onward we can write code inside in method of by using **default** keyword.*
* *The inheritance of interfaces is called implementation.*
* *interfaces allows multiple implementation(inheritance) means we can implement(inherit) more then one interfaces in one class.*
* *we can not make instance of interfaces just like abstract class, we can make verable of interface.*
* *we can write method with same signature but in diferent interfaces.*
* *and if methods have same name of two interfaces we can implement both of them by single code*

# Example:
***Example_3** represent interface in this there are two interfaces both have methods with same signature(name+parameteres) and are implemented by one code.but if methods have same name and we want to implement code differently then we have to write inteface name with the name of abstract method then both metheds will be implementd with different code even if they have same name.*
