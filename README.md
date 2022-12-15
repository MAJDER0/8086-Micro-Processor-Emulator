##Description

Program to Emulate 8086 Microprocessor behavior.
Emulator has implemented basic Instructions such as MOV ADD SUB and side options like SET or RESET.
We can operate on numbers and strings. It's capable of storing strings as a sequence of characters or even strings stored as bits of Information.
Registries value are stored and displayed as HEX values, except normal string, which is displayed as a sequence of characters.
Basically, main difference between string and string stored as bits of information, is the fact that string is stored as a sequence of characters where 
one character equals to one bit. Since string stored as bit of informations, is encoded with ASCII to HEX, and then considered as a number which can't
exceed given range of 16-bits. For example, if we take string "ba" and want to store it as a bits of informations, the string is first encoded trough
ASCII to 6261, and then taken as a number to check if it meets the conditions. Since we can't store more than two characters as a bits of information,
because one letter converted to binary is 8-bits, this method works.However, it's important to note that the hexadecimal value 6261 does not 
represent the concatenation of the letters "b" and "a" as a string. Instead, it represents the numerical values 98 and 97, 
which are the ASCII codes for the letters "b" and "a".



