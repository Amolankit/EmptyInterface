// See https://aka.ms/new-console-template for more information

// maker interface calls

using EmptyInterfaceSample.SuperTypeInterfaceSample.BlankInterfaceImplementation;

var bookRepo = new EmptyInterfaceSample.MakerInterfaceSample.BookRepository();
var book = bookRepo.GetById(1);

// Empty Super Type Usage
var release = new BookRelease
{
    Edition = new MonthlyEdition { Month = new DateTime(2023, 8, 1) }
};
release.PrintEditionDetails();

release = new BookRelease
{
    Edition = new FirstEdition()
};
release.PrintEditionDetails();


// Evolved Super type usage
var firstEdition = new EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation.FirstEdition();
firstEdition.AdvanceEdition();

Console.WriteLine($"Advanced Edition Number: {firstEdition.EditionNumber}");

var monthlyEdition = new EmptyInterfaceSample.SuperTypeInterfaceSample.EvolvedInterfaceImplementation.MonthlyEdition { Month = new DateTime(2023, 8, 1) };
monthlyEdition.AdvanceEdition();

Console.WriteLine($"Next Month: {monthlyEdition.Month.ToString("MMMM yyyy")}");

Console.WriteLine("Hello, World!");