# Vigen-re-Cipher-Program-in-C-
A simple Vigenère cipher program created in C#.

This is a simple command line program based on Vigenere cipher made in C#. The program has both encryption and decryption functions
The program functions by first taking the plaintext and keys as input. Then, the program removes all the symbols and whitespaces from the palaintext go create a new string.
E.g. if the plaintext is "Hello this is my program. I made it in 3 weeks", it is converted to "HellothisismyprogramImadethisinweeks" (ignore the quotes)
Then this is used to generate the key
The key is then used to encrypt the plaintext by doing simple math involving adding the ascii values of the plaintext character and it's corresponding key character. Some extra math is done and the resultant number is converted into a character, which is then added to the ciphertext string.
Then, the program uses the original plaintext as the reference and inserts all the symbols and whitespaces at the corresponding locations in the ciphertext.
That is about it I guess
