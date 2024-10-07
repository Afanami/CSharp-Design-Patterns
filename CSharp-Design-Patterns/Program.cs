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

