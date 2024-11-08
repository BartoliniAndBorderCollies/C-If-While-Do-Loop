Console.WriteLine("Program sprawdza czy podana liczba jest parzysta");
Console.Write("Podaj liczbę: ");
string? answer = Console.ReadLine();
uint number = uint.Parse(answer);

if (number % 2 == 0)
    Console.WriteLine("Liczba {0} jest parzysta", number);
else
    Console.WriteLine("Liczba {0} jest nieparzysta bejb", number);

//-----------------------------------------------------------------------------------------------------------

Console.WriteLine("Tutaj robie sobie while");

int n = 5;
while(n > 0)
{
    Console.WriteLine(n);
    n--;
}

//---------------------------------------------------------------------------------------------------------------


Console.WriteLine("Program oblicza sumę liczb w zadanym przedziale");
Console.Write("Proszę podać liczbę z dolnego zakresu: ");

string? answerDolnyZakres = Console.ReadLine();
uint dolnyZakres = uint.Parse(answerDolnyZakres);

Console.Write("Proszę podać liczbę z górnego zakresu: ");
string? answerGornyZakres = Console.ReadLine();
uint gornyZakres = uint.Parse(answerGornyZakres);

uint suma = 0;
while(dolnyZakres <= gornyZakres)
{
    suma += dolnyZakres;
    Console.WriteLine(dolnyZakres);
    dolnyZakres++;
}

Console.WriteLine("Suma liczb z podanego zakresu wynosi {0}", suma);

//----------------------------------------------------------------------------------------


//Do while -> warunek jest sprawdzany PO wykonaniu Do
// w ten sposób Do jest wykonane minimum 1 raz

Console.WriteLine("Tutaj robię sobie Do while");
int l = 5;
do
{
    Console.WriteLine(l);
    l--;
} while (l > 0);

//------------------------------------------------------------------------------------------

//for loop

Console.WriteLine("Program DRUGI KTÓRY UZYWA for loop i oblicza sumę liczb w zadanym przedziale");
Console.Write("Proszę podać liczbę z dolnego zakresu: ");

string? answerDolnyZakres2 = Console.ReadLine();
uint dolnyZakres2 = uint.Parse(answerDolnyZakres);

Console.Write("Proszę podać liczbę z górnego zakresu: ");
string? answerGornyZakres2 = Console.ReadLine();
uint gornyZakres2 = uint.Parse(answerGornyZakres);

uint suma2 = 0;
for(/*inicjalizacja*/ uint i = dolnyZakres2;  /*warunek kontynuacji*/ i<=gornyZakres2; /*modyfikator*/ i++)
{
    suma2 += i;
    Console.WriteLine(i);
}

Console.WriteLine("suma wynosi {0}", suma2);