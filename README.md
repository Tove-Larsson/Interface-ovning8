# Övning 8 - Interface

Konsolapplikation i C# (.NET) som övar på interface, explicit interface-implementation och kontrakt.

## Innehåll

- `IStart`: interface med metoden `Start()`, implementerat av `Program1` och `Program2`.
- `IAnother`: extra interface med metoden `ShowSomeInfo()`, implementerat av `Program1`.
- `Extra/`: `IExtra1` och `IExtra2` har båda en metod `Run()`, men med returtyperna `int` respektive `void`. `ExtraClass` implementerar båda explicit.

## Struktur

```
Interface_ovning8/
├── Program.cs        (Main)
├── Program1.cs
├── Program2.cs
├── IStart.cs
├── IAnother.cs
└── Extra/
    ├── IExtra1.cs
    ├── IExtra2.cs
    └── ExtraClass.cs
```

## Köra programmet

```
dotnet run --project Interface-ovning8
```

eller starta projektet från Visual Studio.

## Förväntad utskrift

```
Nu kör vi program 1
Nu kör vi program 2
Detta är extra information från program 1
Run with int
Run with void
```

## Vad övningen visar

- Ett interface är ett kontrakt: klassen måste implementera alla medlemmar.
- Olika klasser kan dela metodnamn via ett interface och ändå ha egen kod bakom.
- Två metoder med samma namn och parametrar men olika returtyp kan inte båda vara publika i samma klass. Explicit implementation (`int IExtra1.Run()`, `void IExtra2.Run()`) löser det, och metoderna nås då via en cast eller en variabel av interfacetypen.

## Bortkommenterad kod

I `Program.cs` finns två delar bortkommenterade med avsikt:

- Första versionen utan interface, där `Program1` hade `Run()` och `Program2` hade `Go()`. Uppgiften bad om att kommentera bort den efter att interfacet införts.
- Extra-delen med två instanser av `ExtraClass` (`IExtra1 extra1 = new ExtraClass();` och `IExtra2 extra2 = new ExtraClass();`), enligt föreläsningsmaterialet. Den aktiva varianten använder i stället en enda instans med cast till respektive interface.
