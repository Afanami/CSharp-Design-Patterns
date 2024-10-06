// Encapsulation
// Encapsulation is the process of hiding the internal state of an object and requiring all interactions to be performed through an object's methods.
// Encapsulation is used to protect the data from accidental corruption.
// Encapsulation is a way to achieve data hiding in C#.

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