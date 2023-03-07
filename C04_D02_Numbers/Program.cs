﻿byte byteNumber = 42;        //  8 bit integer number (unsigned,   0-255)
sbyte signedByteNumber = 42; //  8 bit integer number (signed,  -128-127)

ushort unsignedShort = 42;   // 16 bit integer number (unsigned,    0-65535)
short shortInteger = 42;     // 16 bit integer number (signed, -32768-32767)

uint unsignedInteger = 42;   // 32 bit integer number (unsigned,         0-4294967295)
int integer = 42;            // 32 bit integer number (signed, -2147483648-2147483647)

ulong unsignedLong = 42L;     // 64 bit integer number (unsigned,                  0-18446744073709551.615)
long longInteger = 42L;       // 64 bit integer number (signed, -9223372036854775808-9223372036854775807)

// Literal values in Hex and binary
short numberHex = 0x42;             // Hexadecimal value 0x42 = 66
short numberBin = 0b_0100_0010;    // Binary value 0b01000010 = 66, _ is ignored


float floatNumber = 3.14f; // 32 bit floating point number (NOTICE the f at the end)
double douleNumber = 3.14; // 64 bit floating point number (NOTICE the missing f at the end)
double alsoDouble = 3.14d; // 64 bit floating point number (NOTICE the d at the end)
decimal decimalNumber = 3.14m; // 128 bit floating point number (NOTICE the m at the end)

double pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949129833673362440656643086021394946395224737190702179860943702770539217176293176752384674818467669405132000568127145263560827785771342757789609173637178721468440901224953430146549585371050792279689258923542019956112129021960864034418159813629774771309960518707211349999998372978049951059731732816096318595024459455346908302642522308253344685035261931188171010003137838752886587533208381420617177669147303598253490428755468731159562863882353787593751957781857780532171226806613001927876611195909216420198938095257201065485863278865936153381827968230301952035301852968995773622599413891249721775283479131515574857242454150695950829533116861727855889075098381754637464939319255060400927701671139009848824012858361603563707660104710181942955596198946767837449448255379774726847104047534646208046684259069491293313677028989152104752162056966024058038150193511253382430035587640247496473263914199272604269922796782354781636009341721641219924586315030286182974555706749838505494588586926995690927210797509302955321;

// Print the values using format specifiers
Console.WriteLine("Printing integer");
Console.WriteLine("-----------");
Console.WriteLine(integer.ToString()); // Writes "42"
Console.WriteLine(integer.ToString("D5")); // Writes "00042"
Console.WriteLine(integer.ToString("x8")); // Writes "0000002a"
Console.WriteLine(integer.ToString("F2")); // Writes "42.00"

Console.WriteLine("Printing Pi");
Console.WriteLine("-----------");
Console.WriteLine(pi.ToString());      // Writes "3.14159265358979"
Console.WriteLine(pi.ToString("F10")); // Writes "3.1415926536"
Console.WriteLine(pi.ToString("F2"));  // Writes "3.14"
Console.WriteLine(pi.ToString("E1"));  // Writes "3.1E+00"

// NOTE: The culture determines how numbers are formatted, e.g. decimal separator
//       The value in the comments is for the en-US culture 

// NOTE: That pi is also a constant in the Math class (we cover that later)
pi = Math.PI;