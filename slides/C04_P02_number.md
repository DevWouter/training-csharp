# Numbers
---
## Types of numbers
- Integers
    - Signed vs Unsigned
    - 8-bit, 16-bit, 32-bit, 64-bit
- Floating point numbers
    - Single precision (32-bit)
    - Double precision (64-bit)
    - Decimal precision (128-bit)
- Notation
    - Binary (base 2)
    - Decimal (base 10)
    - Hexadecimal (base 16)

---
## Integers
- Signed integers
    - Can be positive or negative
- Unsigned integers
    - Can only be positive
---
## Integer sizes
<div class="r-fit-text">
- 8-bit
    - `sbyte` (min: `-128`, max: `127`)
    - `byte` (min: `0`, max: `255`)
- 16-bit
    - `short` (min: `-32.768`, max: `32.767`)
    - `ushort` (min: `0`, max: `65.535`)
- 32-bit
    - `int` (min: `-2.147.483.648`, max: `2.147.483.647`)
    - `uint` (min: `0`, max: `4.294.967.295`)
- 64-bit
    - `long` (min: `-9.223.372.036.854.775.808`, max: `9.223.372.036.854.775.807`)
    - `ulong` (min: `0`, max: `18.446.744.073.709.551.615`)
</div>

notes: the `s`-prefix stands for `signed` and the `u`-prefix stands for `unsigned`

---
## Integer Notation

```csharp []
byte   byteNumber       = 42;
sbyte  signedByteNumber = 42;
ushort unsignedShort    = 42;
short  shortInteger     = 42;
uint   unsignedInteger  = 42;
int    integer          = 42;
ulong  unsignedLong     = 42L;
long   longInteger      = 42L;

// Hexadecimal value 0x42 = 66
short  numberHex        = 0x42;
// Binary value 0b01000010 = 66, _ is ignored     
short  numberBin        = 0b_0100_0010;
```

---

## Floating point numbers
- Single precision (32-bit)
    - `float`
- Double precision (64-bit)
    - `double`
- Decimal precision (128-bit)
    - `decimal`
