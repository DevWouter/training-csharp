# Choice
## switch...case

<!-- .slide: data-background-image="images/C05/jowita-jelenska-mp4ZJi-Uv9Q-unsplash.jpg" -->

notes: Alternative way for if-else

---

## A different choice

- A "switch-case" is usefull if you have many options
- the `switch` statement requires an value (variable or literal)
- the body of the `switch` contains "cases"
- the `case` statement requires:
  - a constant or a constant expression;
  - no variables allowed.
- A `case` must end with a `break` statement

note: the only variable needs to be in the switch expression. The `break` statement is due to some languages allowing fallthroughs.

--- 

## Example

```csharp [|3|4,14|5-7|8-10|11-14]
int temperature = Random.Shared.Next(-20, 50); // Celcius

switch (temperature)
{
    case 18:
        Console.WriteLine("It's a perfect day");
        break;
    case > 30:
        Console.WriteLine("It's too hot");
        break;
    default:
        Console.WriteLine("We don't have an opinion");
        break;
}
```

---

## Fallthrough example

```csharp [8-11]
int temperature = Random.Shared.Next(-20, 50); // Celcius

switch (temperature)
{
    case 18:
        Console.WriteLine("It's a perfect day");
        break;
    case < -10:
    case > 30:
        Console.WriteLine("It's too hot or too cold");
        break;
    default:
        Console.WriteLine("We don't have an opinion");
        break;
}
```