# 8086 Micro-processor Emulator

Program to Emulate 8086 Microprocessor behavior.

## Description

Emulator has implemented basic Instructions such as MOV, ADD, SUB and side options like SET or RESET. <br>
We can operate on numbers and strings. The Emulator is capable of storing strings as a sequence of characters or even strings stored as bits of Information. <br>
Registry values are stored and displayed as HEX representation, except normal strings, which are displayed as a sequence of characters. <br>
It is possible to add numbers and strings (concenate). Substraction works for numbers only.

Negative values, are displayed with "-" at the beginning, to make it more readable. <br>
However, negative hex is not a common way of representing negative numbers. It is only "allowed in C#" because it is the unary negation operator applied to a positive constant; i.e. when the question shows -0x1, it is "negate (some expression)", where "some expression" is 0x1.

Main difference between string and string stored as bits of information, is that string is stored as a sequence of characters where <br>
one character equals to one bit. Where string stored as bits of informations, is encoded with ASCII to HEX, and then considered as a number which can't
exceed given range of 16-bits.

For example, if we take string "ba" and want to store it as a bits of information, string is firstly encoded trough <br>
ASCII to "6261", and then taken as a number to check if it meets the conditions. <br>
Since we can't store more than two characters as a bits of information, because one letter converted to binary is 8-bit, this method works. <br>
However, it's important to note that the hexadecimal value 6261 does not represent the concatenation of the letters "b" and "a" as a string. <br>
Instead, it represents the numerical values 98 and 97, which are the ASCII codes for the letters "b" and "a".

## How to Run?

To open and test this project, all you need to do is Open Visual Studio and click Clone a Repository. On the repository location, you paste this: https://github.com/MAJDER0/8086-Micro-Processor-Emulator <br>
and click clone. Once project is there, you can compilate it.



