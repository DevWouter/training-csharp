## Variable scope
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
    int result = a + b;
    return result;
}

int a = 1;
int b = 2;
int result = Add(a, b);
```

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

---
<!-- .slide: data-visibility="hidden" -->
### Tip: Naming conventions

Naming conventions are used to prevent conflicts between variables and methods.

<div class="fragment">
They are way that something is usually done, especially within a particular area or activity.
</div>

<div class="fragment">

#### Naming conventions

| Casing       | Usage                     |
| ------------ | ------------------------- |
| `camelCase`  | Variables and parameters  |
| `PascalCase` | Methods, types and member |

Conventions != rules

</div>

---

<!-- .slide: data-visibility="hidden" -->
### Please don't 🫣


```csharp []
void sYSTEMsPEAK(string PARAM___TEXT)
{
    string lOcAlVaLue = "System: " + PARAM___TEXT;
    Console.WriteLine(lOcAlVaLue);
}
```

<div class="fragment">

```csharp []
void ಠ_ಠ(string text)
{
    Console.WriteLine(text);
}

ಠ_ಠ("Hello");
```

</div>

<p class="fragment">Yes, this will compile</p>
note: Pronounced as <a href="https://translate.google.com/?sl=en&tl=kn&text=%E0%B2%A0_%E0%B2%A0&op=translate">`tà underscore tà` (Google Translate)</a>