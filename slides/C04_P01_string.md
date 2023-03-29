# String
---

Literal strings are defined by enclosing the text in double quotes (`"`).

```csharp []
string text = "Hello World";
```
---

## String concatenation

```csharp []
string name = "World";
string text = "Hello " + name;
```

---

## String interpolation

```csharp []
string name = "World";
string text = $"Hello {name}";
```

---
## Escape characters

```csharp []
string text = "Hello\n\tWorld";
```

Outputs:
``` []
Hello
    World
```

<div class="fragment">

- `\n` is a newline
- `\t` is a tab

</div>

--- 

## Escaping escape characters

```csharp []

string text = "Hello\\n\\tWorld";
```

Outputs:
``` []
Hello\n\tWorld
```


---
## @: Verbatim strings

```csharp []
string text = @"Hello
    World";
```
Outputs:
``` []
Hello
    World
```
---
## $@: Interpolated Verbatim strings

```csharp []
string name = "World";
string text = $@"Hello
    {name}";
```
Outputs:
``` []
Hello
    World
```

---
## Verbatim strings (common pitfall)

```csharp []
void SayHello()
{
    string text = @"Hello
        World";
        Console.WriteLine(text);
}

Console.WriteLine("Unwanted indentation:");
SayHello();
```
Outputs:
``` []
Unwanted indentation:
    Hello
        World
```

---

## Raw strings

```csharp []
void SayHello()
{
    string text = """
                Hello
                    World
                """;
        Console.WriteLine(text);
}

SayHello();
```
Outputs:
``` []
Hello
    World
        
```