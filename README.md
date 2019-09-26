# Simple-Ciphers (RailFence, RotatingGrill, Vigenere)

## RailFence cipher:
***`alphabet`*** - English (ABCDEFGHIJKLMNOPQRSTUVWXYZ).  
***`key`*** - positive numbers (all other characters are ignored).

##### Available functions:
```c#
string Encrypt(string plaintext, string key)
```
###### Description:
Encrypts plaintext with a cipher "Rail-Fence" with the specified key.  
###### Formal parameters:
***`plaintext`*** - the text to be encrypted.  
***`key`*** - fence height.
###### Return value:  
***`The ciphertext`***.
___
```c#
string Decrypt(string ciphertext, string key)
```
###### Description:
Decrypts ciphertext with a cipher "Rail-Fence" with the specified key.
###### Formal parameters:
***`ciphertext`*** - the text to decrypt.  
***`key`*** - fence height.
###### Return value:  
***`Decrypted text`***.
___
##### Principle of operation:
###### Encrypt:
1. Build a key-tall "rail fence".
2. Read characters from left to right from top to bottom.    
###### Example:  
***`key = 3`***  
***`plaintext = "HELLOWORLD"`***
> H          O            L  
>     E     L   W    R     D  
>        L           O  

***`ciphertext = HOLELWRDLO"`***
###### Decrypt:
In order to decrypt the received text, it is necessary
perform the reverse actions performed during encryption and use
the same key.
### RotatingGrill cipher:
***`alphabet`*** - English (ABCDEFGHIJKLMNOPQRSTUVWXYZ).  
***`key`*** - array of holes in the grill.
##### Constructors:
```c#
public RotatingGrill()
{
    key[0] = new int[2] { 0, 0 };
    key[1] = new int[2] { 3, 1 };
    key[2] = new int[2] { 2, 2 };
    key[3] = new int[2] { 1, 3 };
}
```
Initializes the key with a default value.
###### Grill initialized with the default key (zeros - holes):
> 0   X   X   X  
> X   X   X   0  
> X   X   0   X  
> X   0   X   X  
____
```c#
public RotatingGrill(int[][] key, int grillSize)
{
    this.key = key;
    this.grillSize = grillSize;
}
```
Allows you to create your own grill with your own key.
##### Available functions:
```c#
string Encrypt(string plaintext, string key = null)
```
###### Description:
Encrypts text using the "rotating grill" algorithm.  
###### Formal parameters:
***`plaintext`*** - the text to be encrypted.  
***`key`*** - ***specified when creating the object***.
###### Return value:  
***`The ciphertext`***.
___
```c#
string Decrypt(string ciphertext, string key = null)
```
###### Description:
Decrypts the text using the "rotating grill" algorithm. 
###### Formal parameters:
***`ciphertext`*** - the text to decrypt. 
***`key`*** - ***specified when creating the object***.
###### Return value:  
***`Decrypted text`***.
##### Principle of operation:
###### Encrypt:
1. Write the letters of the plaintext in free holes..
2. Rotate the grill 90 degrees.
3. Perform steps 1, 2 until you encrypt all the text.
###### Decrypt:
Perform reverse encryption actions.
### Vigenere cipher:
***`alphabet`*** - Russian (АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ).  
***`key`*** - characters of the Russian alphabet (all other characters are ignored).  
The implementation of this cipher is made with a ***`progressive key`***.
##### Constructors:
```c#
public Vigenere()
{
    alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
}
```
Initializes the alphabet to the default value.
```c#
public Vigenere(string alphabet)
{
    this.alphabet = alphabet;
}
```
Allows you to set your own alphabet.
___
##### Available functions:
```c#
string Encrypt(string plaintext, string key)
```
###### Description:
Encrypts text using the "Vigenere" algorithm.
###### Formal parameters:
***`plaintext`*** - the text to be encrypted.   
***`key`*** - the key for the lookup table.
###### Return value:  
***`The ciphertext`***.
___
```c#
string Decrypt(string ciphertext, string key)
```
###### Description:
Decrypts text using the "Vigenere" algorithm.
###### Formal parameters:
***`ciphertext`*** - the text to decrypt.   
***`key`*** - the key for the lookup table.
###### Return value:  
***`Decrypted text`***.
___
##### Principle of operation:
###### Encrypt:
1. Select a lookup table according to the current key characters.
2. Substitute a character with the character from the lookup table for the current plaintext character.
###### Decrypt:
Perform reverse encryption actions.