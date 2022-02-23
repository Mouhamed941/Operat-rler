//atama ve işlemli işlemleri
int x = 3;
int y = 3 ;
y = y+2;
System.Console.WriteLine(y);
System.Console.WriteLine(x);
y /= 1 ;
System.Console.WriteLine(y);

y *= 2 ;
System.Console.WriteLine(y);

//Mantıksal Öperatörler
// || &&  !
bool IsSuccess  =true;
bool IsCompleted = false;

if (IsSuccess && IsCompleted)
{
    System.Console.WriteLine("Perfect!");  //true && false = false
}

if (IsSuccess || IsCompleted)
{
    System.Console.WriteLine("Great!");     // true // false = true
}


if (IsSuccess && !IsCompleted)
{
    System.Console.WriteLine("Fine!");      // true && !false = true
}

// İlşkisel Öperatörler
// < , > , <= , >= , == , !=
int a = 3;
int b = 5 ;
bool sonuc = a < b;
System.Console.WriteLine(sonuc);    //True

sonuc = a>b;
System.Console.WriteLine(sonuc);    // False

sonuc = a>=b;
System.Console.WriteLine(sonuc);    // False

sonuc = a<=b;
System.Console.WriteLine(sonuc);    // True

sonuc = a==b;
System.Console.WriteLine(sonuc);    // False

sonuc = a != b ;
System.Console.WriteLine(sonuc);    // True

// Aritmetik Öperatörleri
// + - * /
int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1/sayi2;
System.Console.WriteLine(sonuc1);

sonuc1 = sayi1+sayi2;
System.Console.WriteLine(sonuc1);   // 15

sonuc1 = sayi1-sayi2;
System.Console.WriteLine(sonuc1);   // 5

sonuc1 = sayi1*sayi2;
System.Console.WriteLine(sonuc1);   // 50
sonuc1 = sayi1++;
System.Console.WriteLine(sonuc1);

// % : mod alır
int a1 = 25;
int kalan = a1 % 4;
System.Console.WriteLine(kalan);    // 1 

