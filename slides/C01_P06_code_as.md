# Code as ...

---

## Code as human

> "I want to see a message on the screen that says 'Hello world!'"

(We call this specifications)

---

## Code as C#

```csharp
System.Console.WriteLine("Hello world!");
```

---

## Code as IL
```
IL_0000 ldstr   "Hello world!"
IL_0005 call    Console.WriteLine (String)
IL_000A ret
```

IL stands for intermediate language

notes: IL is what the runtime takes and converts to assembly

---

## Code as x64 Assembly
```
L0000   mov rcx, 0x13286c12568
L000a   mov rcx, [rcx]
L000d   jmp qword ptr [0x7ffe3624fc90]
```