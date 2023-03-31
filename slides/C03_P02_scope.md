## Variable scope
notes:
- Looking at the lifetime of an variable
- What happens to a variable if your application is exited?
---

### Paremeters have their own scope (1/2)
```csharp []
// Declaring method
void Say(string name, string text)
{
    Console.WriteLine(name + ": " + text);
}





// Invoking a method
Say("Wouter", "Hello World");
```
---
### Paremeters have their own scope (2/2)

```csharp [1-4,11-12|7-9|]
// Declaring method
void Say(string name, string text)
{
    Console.WriteLine(name + ": " + text);
}

// Declaring variables and assigning values
string name = "Wouter";
string text = "Hello World";

// Invoking a method
Say(name, text);
```

---
### Variables in a method have their own scope
```csharp []
int Add(int a, int b)
{
    a = a + 98;
    int result = a + b;
    return result;
}

int a = 1;
int b = 2;
int result = Add(a, b);
result = result - 1;
```

notes: 
- What is are the values of `a` and `result`?

---
### Errors (1/2)
```csharp []
void SystemSpeak(string text)
{
    string result = "System: " + text; 
}

SystemSpeak("Hello World");

// 🐛 Error: 'result' is not defined
Console.WriteLine(result); 
```

<div class="fragment">

```csharp []
void SystemSpeak(string text)
{
    // 🐛 Error: name `text` already defined
    string text = "System: " + text; 
    Console.WriteLine(text);
}

SystemSpeak("Hello World");
```

</div>

---


### Errors (2/2)
```csharp []
void SystemSpeak(string text)
{
    string finalText = "System: " + text;
    Console.WriteLine(finalText);
}

// 🐛 Error: Name `SystemSpeak` already defined
string SystemSpeak = "Hello World"; 

SystemSpeak(SystemSpeak);
```