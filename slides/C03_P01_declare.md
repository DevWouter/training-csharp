## Declaring a method
---

### Example

```csharp []
// Declaring method
void MyMethod()
{
}
```

* `void` is the return type
* `MyMethod` is the name of the method
* `()` is the parameter list
* `{` is the start of the method body
* `}` is the end of the method body
* No `;` since it's not a statement

---

### Invoking a method

```csharp []
// Invoking a method
MyMethod();

// Declaring method
void MyMethod()
{
}

// Invoking a second time
MyMethod();
```

notes: Declaring a method can be done anywhere in the code. Since it's not a statement, the order doesn't matter.

---
### Parameters

```csharp []
// Declaring method
void Say(string name, string text)
{
    Console.WriteLine($"{name}: {text}");
}

// Invoking a method
Say("Wouter", "Hello World");
```

notes: On line 8 we pass a string literal as first and second parameter. The first parameter is assigned to the `name` parameter and the second parameter is assigned to the `text` parameter.

---
### Return values

```csharp []
// Declaring method
int Add(int a, int b)
{
    return a + b;
}

// Invoking a method
int result = Add(1, 2);
```
notes: The `return` statement is used to return a value from a method. The return type of the method must match the type of the value returned.

---
### void is special

```csharp []
void Say(string name, string text)
{
    Console.WriteLine($"{name}: {text}");
}

int Add(int a, int b)
{
    return a + b;
}
```

note: What does the `Say` method return? What does the `Add` method return?