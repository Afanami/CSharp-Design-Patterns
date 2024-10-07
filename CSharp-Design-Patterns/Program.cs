/*
    Encapsulation
    Encapsulation is the process of hiding the internal state of an object and requiring all interactions to be performed through an object's methods.
    Encapsulation is used to protect the data from accidental corruption.
    Encapsulation is a way to achieve data hiding in C#.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Encapsulation;

    BadBankAccount badAccount = new BadBankAccount();
    badAccount.balance = 100;
    Console.WriteLine(badAccount.balance);

    BankAccount bankAccount = new BankAccount(100);
    Console.WriteLine(bankAccount.GetBalance());

    bankAccount.Deposit(50);
    Console.WriteLine(bankAccount.GetBalance());

    bankAccount.Withdraw(100);
    Console.WriteLine(bankAccount.GetBalance());
*/

/*
    Abstraction
    Abstraction is the process of hiding the implementation details and showing only the functionality to the user.
    Abstraction is achieved using abstract classes and interfaces in C#.
    Abstraction is used to define the structure of a class without providing the implementation details.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Abstraction;

    // Without abstraction
    EmailService emailService = new EmailService();
    emailService.Connect();
    emailService.Authenticate();
    emailService.SendEmail();
    emailService.Discconect();

    // With abstraction
    EmailService emailService = new EmailService();
    emailService.SendEmail();
*/

/*
    Inheritance
    Inheritance is the process of creating a new class by using the properties and methods of an existing class.
    Inheritance is used to achieve code reusability in C#.
    Inheritance is used to define a new class (subclass/derived class) based on an existing class (superclass/base class) where subclasses inherit properties and methods from the superclass and can also add new feature or override existing features. 
    Inheritance "is-a" relationship.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Inheritance;

    var car = new Car();

    // Accessing properties from the base class
    car.Brand = "Toyota";
    car.Start();
    car.Stop();

    // Accessing properties from the derived class
    car.NumberOfDoors = 4;
    car.NumberOfWheels = 4;
*/

/*
    Polymorphism
    Polymorphism is the ability of an object to take on many forms.
    Polymorphism is used to define different behaviors for subclasses that have the same method name.
    Polymorphism is achieved using method overriding in C#.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Polymorphism;

    List<Vehicle> vehicles = new List<Vehicle>();
    vehicles.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2021, NumberOfDoors = 4 });
    vehicles.Add(new Motorcycle { Brand = "Honda", Model = "CBR", Year = 2021 });

    foreach (var vehicle in vehicles)
    {
        // Treat all vehicles as the base class
        vehicle.Start();
    }
*/

/*
    Coupling
    Coupling is the degree of dependency between two classes.
    Tight coupling is when a class is dependent on another class.
    Loose coupling is when a class is not dependent on another class.
    Loose coupling is achieved using interfaces in C#.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Coupling;
    
    var order = new Order(new SmsSender());
    order.PlaceOrder();
*/

/*
    Composition
    Composition is the process of creating a new class by combining multiple classes.
    Composition is used to achieve code reusability in C#.
    Composition "has-a" relationship.
*/

/*
    using CSharp_Design_Patterns.src.OopsPrinciples.Composition;

    var car = new Car();
    car.StartCar();
*/

/*
Composition vs Inheritance

When to use Composition:
    When you want to create a new class by combining multiple classes.
    When you want to achieve code reusability.
    When you want to create a class that has a "has-a" relationship with other classes.

When to use Inheritance:
    When you want to create a new class by using the properties and methods of an existing class.
    When you want to achieve code reusability.
    When you want to create a class that has an "is-a" relationship with other classes.
    When you want to leverage polymorphism to define different behaviors for subclasses that have the same method name.
*/

/*
    Fragile Base Class Problem
    The fragile base class problem is a problem that occurs when a base class is modified and the changes break the derived classes. This problem is common in inheritance-based designs where changes to the base class can have unintended consequences on the derived classes due to the tight coupling between them.
    The fragile base class problem can be avoided by using composition instead of inheritance.
    Composition is more flexible than inheritance because it allows you to create a new class by combining multiple classes, which reduces the dependency between classes.

    Inhertiance coupling:
        Tight coupling
        Fragile base class problem
        Inflexible
        Code duplication

    Limited Extensibility:
        Inheritance is a static relationship that cannot be changed at runtime.
        Inheritance is a compile-time relationship that is fixed at design time.
        Inheritance is a one-time relationship that cannot be changed once the classes are defined.
        Inheritance is a rigid relationship that does not allow for dynamic changes at runtime.

    Mitigating the Fragile Base Class Problem:
        Use composition instead of inheritance.
        Use interfaces to define contracts between classes.
        Use dependency injection to decouple classes.
        Use design patterns to reduce dependencies between classes.
*/