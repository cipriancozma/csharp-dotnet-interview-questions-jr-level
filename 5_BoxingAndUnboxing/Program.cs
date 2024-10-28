int number = 5;
object boxedNumber = number; // boxing

int unboxedNumber = (int)boxedNumber; // unboxing

short otherShortNumber = 3;
int otherShortNumberCastToInt = (int)otherShortNumber;  // this will work fine, no error will be thrown
   

Console.ReadKey();