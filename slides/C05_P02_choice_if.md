# Choice
## if...else

notes: Choice is about decision making

---

## A choice

- Choice is a yes or no
- Yes or no can also be expressed as true or false

--- 

## Examples of choice

<ul>
<li> <code>if</code> number is odd <code>then</code> print it
<li> <code>if</code> hungry <code>then</code> eat
<li> <code>if</code> temperature below 20 <code>then</code> wear a jacket
<li> <code>if</code> current time is after 18:00 <code>then</code> close laptop
<li> <code>if</code> destination is left 
<ul>
    <li> <code>then</code> go left
    <li> <code>else</code> go right
</ul>
</ul>

notes: A computer requires a boolean value to make a decision.

---

## Complexity == Combining choices

Leaving the office:
* Is it the end of workday?
* Do I have a glass?
* Is my glass empty?
* Do I want to drink my glass?
* Is the dishwasher running?
* Is the dishwasher full?

notes: Computers make binary choices (yes/no)

---

## Example 1

```csharp []
if(DateTime.Now.Hour > 18) 
{
    Console.WriteLine("It past 6PM. Go home!");
} 
else 
{
    Console.WriteLine("It's not yet 18:00...");
}
```

notes: Remind people about statement blocks.

---


## Example 2

```csharp []
int hour = DateTime.Now.Hour;
if(hour > 8 && hour < 17) 
{
    Console.WriteLine("It between 8:00 and 17:00. You should be at work");
} 
else 
{
    if(hour > 18) 
    {
        Console.WriteLine("It's late! Please go home!");
    }
}
```

note: 
- `else if` can be written without statement blocks.
- Demo that it can be shortend
---


## Example 2: Shorter

```csharp []
int hour = DateTime.Now.Hour;
if(hour > 8 && hour < 17) 
    Console.WriteLine("08:00-17:00: You are at work");
else if(hour > 18) 
    Console.WriteLine("18:00 or later: You are at home");
```

note: 
- `else if` can be written without statement blocks.
- Demo that it can be shortend

---

## Example 2: Multiple staments? 

Use statement block

```csharp [5-86]
int hour = DateTime.Now.Hour;
if(hour > 8 && hour < 17)
    Console.WriteLine("08:00-17:00: You are at work");
else if(hour > 18)
{
    Console.WriteLine("18:00 or later: You are at home");
    Console.WriteLine("You worked hard today");
}
```

---

## Recap

- `if` and `else` are keywords
- `if( boolean_expression )`
- After `if` and `else` comes either a:
  - `statement` 
  - `statement_block`