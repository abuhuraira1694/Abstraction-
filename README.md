# Abstraction-
Abstraction in C# using abstract classes and interfaces

# what is abstraction?
 abstraction is a main concept of OOP which belongs to showing only essential details and hiding interfnal details.

# Benefits of abstraction
 * It reduce code complexity.
 * Improves readability and maintainability.
 * Allows developers to change implementation without effecting usage.

# How abstraction is achieved in C#?
 In C# there are two ways to implement abstraction.

 * using Abstract classes
 * Using Interfaces

# Abstract Classes:
  * its a class which is declared with **abstract** keyword. Abstract class is always use as base class.In abstract class we use **abstract methods** in the abstract class.
    In Abstract methods we just write method name an parameters(if method have) mean we just write method signature. we don't write any code inside the method
    mean we not write any body the method.
  * Abstract classes are partial abstraction means in abstract classes abstraction is not complete.
  * in the abstract classes we can write non-abstract methods(Normal methods).And these methods execute normaly like in other normal classes.
  * We can't make abstract methods **Privat** because we must have to **override** it in the derived class.
  * And if we make method private then Inheretance is not possible but for abstraction inheretance is compulsory.
  * We can not make **object** of abstract class.
  * we can make referance veriable of abstract class.
  * To use abstract classes we inherit them.
# Example:
  **Example_1** and **Example_2** in code files representing abstraction using abstract classes.
  * In Example_1 class1 is abstract class which contain two abstract methods.And this class is inherited in Class2 and in this class abstract methods are implemented and in the **Main** method an **Object** of class2 is made to call the methods.
  * In Example_2 class1 is abstract class which contain 3 abstract methods
     
