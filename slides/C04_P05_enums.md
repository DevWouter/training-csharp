# Enums

---

Types of computers:

* Desktop
* Laptop
* Tablet
* Smartphone

---

``` csharp []
int Desktop = 0;
int Laptop = 1;
int Tablet = 2;
int Smartphone = 3;

int computerType = Desktop;
```

---

```csharp []
enum ComputerType
{
    Desktop,
    Laptop,
    Tablet,
    Smartphone
}

ComputerType computerType = ComputerType.Desktop;
```

---

```csharp []
enum ComputerType
{
    Desktop = 0,
    Laptop = 1,
    Tablet = 2,
    Smartphone = 3
}

ComputerType computerType = ComputerType.Desktop;
```

notes: Enums are numeric

---

```csharp []
enum ComputerType
{
    Desktop = 4,
    Laptop = 2,
    Tablet = 3,
    Smartphone = 1,
}

ComputerType computerType = ComputerType.Desktop;
```

notes: Different order

---

```csharp []
enum ComputerType
{
    Desktop = 4,
    Laptop, // Will be 5
    Tablet = 3,
    Smartphone = 1,
}

ComputerType computerType = ComputerType.Desktop;
```

notes: Leaving values out will increment the previous value. See `Laptop`.


---

```csharp []
enum ComputerType
{
    Desktop = 4,
    Laptop, // Will be 5
    Tablet  = 3,
    Smartphone, // Will be 4
}

ComputerType computerType = ComputerType.Desktop;
```

notes: Values that are left out will not skip used values. See `Smartphone` is being the same as `Desktop`.