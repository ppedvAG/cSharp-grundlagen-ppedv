# ABLAUF VOM KURS, VADZIM

[csharp-spickzettel](CSHARP-CHEATSHEET.md)

[git-commands](GIT-COMMANDS.md)

[vs-shortcuts](VS-SHORTCUTS.md)

[csharp-snippets](CSHARP-SNIPPETS.md)

## M00 | WARMING UP

- [x] Greeter
- [x] VS
- [x] Git

VS Installer > installierte Version ändern > sprachpakete


## M10 | GETTING STARTED

- [x] Intro [csharp docs](https://docs.microsoft.com/de-de/dotnet/csharp/)
- [x] .NET [Dokumentation](https://docs.microsoft.com/de-de/dotnet/api/?view=netframework-4.8)
- [x] [M1HelloWorld](../vadzim/CS-GK-VC-V/M1HelloWorld/M1HelloWorld.cs)
- [x] [DConsole](../vadzim/CS-GK-VC-V/Demo-Console/DConsole.cs)

sln props > startup projects > current

Übersicht von Klassen und Interfaces, die man im Kurs vor allem braucht

## M20 | DATA TYPES, OPERATORS

- [x] Datentypen
- [x] [bool](../vadzim/CS-GK-VC-V/Demo-bool/Dbool.cs)
- [x] [string](../vadzim/CS-GK-VC-V/Demo-String/Dstring.cs)
- [x] [int](../vadzim/CS-GK-VC-V/Demo-int/Dint.cs)
- [x] [double](../vadzim/CS-GK-VC-V/Demo-double/Ddouble.cs)
- [x] Operatoren
- [x] Casting
- [x] [enum](../vadzim/CS-GK-VC-V/Demo-enum/Denum.cs)
- [x] [Ü MiniRechner](../vadzim/CS-GK-VC-V/M2MiniRechner/M2MiniRechner.cs)
- [ ] [bits](../vadzim/CS-GK-VC-V/Demo-bits/Dbits.cs)

## M30 | ARRAYS & CONTROLS

- [x] [Arrays](../vadzim/CS-GK-VC-V/Demo-Array/DArray.cs)
- [x] if else
- [x] for
- [x] while & do while
- [x] switch
- [x] [Demo-Random](../vadzim/CS-GK-VC-V/Demo-Random/DRandom.cs)
- [x] [M3Zahlenratespiel](../vadzim/CS-GK-VC-V/M3Zufallszahl/M3Zufallszahl.cs)

## M40 | METHODS

- [x] arguments
- [x] parameters
- [x] return
- [x] overloads
- [x] out & ref args
- [x] [DMethods](../vadzim/CS-GK-VC-V/Demo-Methods/DMethods.cs)

## M50 | CLASSES & OOP

- [x] constructor
- [x] fields
- [x] props
- [x] class methods
- [x] access modifier
- [x] inctances / objects
- [x] destructor
- [x] [DLibrary - MyClass](../vadzim/CS-GK-VC-V/Demo-Library/MyClass.cs) <!-- der bessere Name: MyClassWFields -->
- [x] [DLibrary - MyClassWProps](../vadzim/CS-GK-VC-V/Demo-Library/MyClassWProps.cs)
- [x] [DLibraryConsumer](../vadzim/CS-GK-VC-V/Demo-Library-Consumer/DLibConsumer.cs)
- [x] [Ü MTransport](../vadzim/CS-GK-VC-V/MTransport/Transport.cs)
- [x] [Ü MTransportConsumer](../vadzim/CS-GK-VC-V/MTransport/TConsumer.cs)

## M60 | INHERITENCE / VERERBUNG

- [ ] base
- [ ] virtual & override methods
- [ ] abstract methods
- [ ] [DLibrary - MyRandom](../vadzim/CS-GK-VC-V/Demo-Library/MyRandom.cs)
- [ ] [DLibraryConsumer - Region Call MyRandom](../vadzim/CS-GK-VC-V/Demo-Library-Consumer/DLibConsumer.cs)
- [ ] [DLibrary - MyClassInhCtor](../vadzim/CS-GK-VC-V/Demo-Library/MyClassInhCtor.cs)
- [ ] [DLibraryConsumer - Region Call MyClassInhCtor](../vadzim/CS-GK-VC-V/Demo-Library-Consumer/DLibConsumer.cs)
- [ ] [Ü Flugzeug](../vadzim/CS-GK-VC-V/MTransport/Flugzeug.cs)
- [ ] [Ü PKW](../vadzim/CS-GK-VC-V/MTransport/PKW.cs)
- [ ] [Ü Schiff](../vadzim/CS-GK-VC-V/MTransport/Schiff.cs)

## M70 | INTERFACES & POLYMORPHISM

- [ ] interfaces
- [ ] override vs overload
- [ ] [Ü IKannAndereTransportieren](../vadzim/CS-GK-VC-V/MTransport/IKannAndereTransportieren.cs)
- [ ] [Ü IMitRädern](../vadzim/CS-GK-VC-V/MTransport/IMitRädern.cs)

DLibrary, DLibraryConsumer

## M80 | GENERIC DATA STRUCTURES

- [ ] [List`<T>`](../vadzim/CS-GK-VC-V/Demo-List/DList.cs)
- [ ] [Stack`<T>`](../vadzim/CS-GK-VC-V/Demo-Stack/DStack.cs)
- [ ] [Queue`<T>`](../vadzim/CS-GK-VC-V/Demo-Queue/DQueue.cs)
- [ ] [KeyValuePair`<T1, T2>`](../vadzim/CS-GK-VC-V/Demo-KeyValuePair/DKeyValuePair.cs)
- [ ] [Dictionary`<T1, T2>`](../vadzim/CS-GK-VC-V/Demo-Dictionary/DDictionary.cs)
- [ ] Hachtable
- [ ] [Ü Passagierliste](../vadzim/CS-GK-VC-V/MTransport/Flugzeug.cs)

## M90 | WINDOWS FORMS

- [ ] partial classes
- [ ] widgets / components
- [ ] component props
- [ ] [TicTacToe](../vadzim/CS-GK-VC-V/Demo-WinForm/DWinForm.cs)

## M100 | DELEGATES & EVENTS

- [ ] custom delegates
- [ ] built-in delegates
- [ ] anonumous functions
- [ ] event handler

Ddelegate

Ü Kollidierende Buttons

Ü Einfacher Taschenrechner?

Klasse Timing?

Klasse Stopwatch?

## M110 | Exception-Handling​

- [ ] Exception & throw
- [ ] try catch finally
- [ ] Exception types
- [ ] [standard exception](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/using-standard-exception-types)
- [ ] *todo Überblick für verbreitete Exceptions. z.B. ForamtE ist beim oberen Link nicht dabei
- [ ] [Demo-Exception](../vadzim/CS-GK-VC-V/Demo-Exceptions/Form1.cs)

## M120 | Unit-Tests

- [ ] TestPackages & TestProject
- [ ] TestClasses, TestMethods, TestAnnotations
- [ ] Assert-Klasse
- [ ] [Demo-UnitTest1](../vadzim/CS-GK-VC-V/Demo-UnitTests/UnitTest1.cs)

## M130 | File Access Dateizugriff​

- [ ] SaveFileDialog & OpenFileDialog
- [ ] StreamReader & StreamWriter
- [ ] JSON, serialize & deserialize 
- [ ] [Ü TransportListe (M10Ü)](../vadzim/CS-GK-VC-V/M13Serialisierung/Form1.cs)

Ü Anmeldeformular? / Gästeliste?

## M140 | Datenbankzugriff mit Entity Framework​

- [ ] entities
- [ ] models
- [ ] dbcontext
- [ ] dbset
- [ ] [Demo EntityFrCore](../vadzim/CS-GK-VC-V/Demo-EntityFrameworkCore/DEFCore.cs)

## M150 | Datenbankzugriff mit ADO.NET​

to be continued..

- [ ]
- [ ]
- [ ]

Cheatsheets syntax
listen von Klassen, Exceptions