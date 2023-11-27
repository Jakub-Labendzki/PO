byte (8 bitów => 1 bajt)            | 0                              -      255
sbyte (8 bitów => 1 bajt)           | -128                           -      127
short (16 bitów => 2 bajty)         | -32768                         -      32767
ushort (16 bitów => 2 bajty)        | 0                              -      65535
int (32 bitów => 4 bajty)           | -2 147 483 648                 -      2 147 483 647
uint (32 bitów => 4 bajty)          | 0                              -      4 294 967 295
long (64 bitów => 8 bajtów)         | -9 223 372 036 854 775 808     -      9 223 372 036 854 775 807      |Sufix L
ulong (64 bity => 8 bajtów)         | 0                              -      18 446 744 073 709 551 615     |Sufix UL
bool                                | true                           -      false
char (16 bitów => 2 bajty, znak z tablicy Unicode)         |  U+0000 -      U+FFFF 
srting ?
float (32 bity)                     | -3.4 x 10^38                   -      3.4 x 10^38 
double (64 bity)
decimal (128 bitów)


Console.WriteLine("\x2665");


Console.Write("Podaj bok a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Podaj bok b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Podaj bok c: ");
double c = double.Parse(Console.ReadLine());
double p = (a + b + c) / 2;
double heron = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine(heron);



static void Main(string[] args)
{
    int[] tabA = CreateArray("tabA");
    if (tabA != null) 
    {
        SetArray(tabA, "tabA");
        DisplayArray(tabA, "tabA");
    }
}

//funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę (CreateArray)
public static int[] CreateArray(string name)
{
    Console.Write($"Podaj rozmiar tablicy <0 ; {int.MaxValue}>: ");
    int size = 0;
    try
    {
        size = int.Parse(Console.ReadLine());
        if (size <= 0) throw new ArgumentException("\nRozmiar tablicy musi być dodatni");
    }
    catch(Exception e)
    {
        Console.WriteLine("Wystąpił błąd: {0}", e.Message);
        return null;
    }
    int[] array = new int[size];
    return array;
}

//funkcja statyczna, która ustawia elementy tablicy
public static void SetArray(int[] nameset, string name)
{
    Console.WriteLine($"\nPodaj elementy tablicy {name}: ");
    for (int i = 0; i < nameset.Length; i++)
    {
        Console.Write($"Podaj elementy tablicy {i + 1}: ");
        try
        {
            nameset[i] = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("\nWystąpił błąd: {0}\n ", e.Message);
            i--;
        }
    }       
}

//funkcja statyczna, która wyświetla zawartość tablicy
public static void DisplayArray(int[] array, string name)
{
    Console.WriteLine($"\nWyświetlenie elementów zawartości");
    int i = 0;
    foreach (var element in array)
    {
        Console.WriteLine($"\n{name}[{i}]: {element}");
        i++;
    }
}




-----------------------------------------------------------------------------
            int[] array = new int[5];

            do
            {
                Console.WriteLine("Wprowadź 5 liczb całkowitych:");
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"Podaj liczbę {i + 1}:");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>");
                }
                break;
            } 
            while (true);
            

            

            int index = 0;
            string input = "";

            do
            {
                Console.Write("\nWprowadź indeks tablicy lub q, aby zakończyć program:");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    index = int.Parse(input);

                    if (index > array.Length - 1)
                    {
                        throw new OverflowException("Błąd: ");
                    }

                    Console.WriteLine($"Liczba pod indeksem {index} to {array[index]}");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Indeks musi być między 0 a {array.Length - 1}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Indeks musi być między 0 a {array.Length - 1}. Error: {ex}");
                }
            }
            while (true);


--------------------------------------------------------------------------

            string input;

            do
            {
                Console.Write("Podaj liczbę całkowitą lub 0, aby wyjść z programu:");
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    int number = int.Parse(input)-;
                    if (number < 0)
                    {
                        throw new ArgumentOutOfRangeException("Liczba nie może być ujemna");
                    }

                    if (number > 0)
                    {
                        double sqrt = Math.Sqrt(number);
                        Console.WriteLine($"\nPierwiastek z {number} wynosi {sqrt}\n\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNieprawidłowe dane wejściowe. Podaj prawidłową liczbę całkowitą");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"\nNieprawidłowe dane wejściowe. Przekroczono zakres liczby <{int.MinValue} ; {int.MaxValue}>");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"\nBłąd: {ex.Message}\n");
                }
                finally 
                {
                    Console.WriteLine("Dziękujemy za skorzystanie z programu");
                }
                
            }
            while (input != "q");


-----------------------------------------------------------------------------

    bool isCorrect = false;
      do
      {
        try
        {
        
            Console.WriteLine("Podaj dwie liczby");
            Console.Write("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.Write($"\nWynik dzielenia liczb ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.ResetColor();
            isCorrect = true;
        
        } 
        catch (FormatException)
        {
          ErrorColorChange("Błędny format danych");
        }
        catch (OverflowException)
        {
          ErrorColorChange("Wartość podana przez użytkownika przekracza zakres liczby <{int.MinValue};{int.MaxValue}>");
        }
        catch (DivideByZeroException)
        {
          ErrorColorChange("Dzielenie przez 0");
        }
        catch (Exception ex)
        {
          ErrorColorChange("Błąd: {ex.Message}");

        }
        finally 
        {
          Console.WriteLine("\n\nDziękujemy za korzystanie z programu\n\n");
        }
      } while (!isCorrect);



------------------------------------
Wyjątki:
FormatException - Wyrzucany, gdy format danego argumentu jest nieprawidłowy.
OverflowException - Wyrzucany, gdy następuje przepełnienie wartości liczbowej, co oznacza, że wartość jest zbyt duża, aby zmieścić się w danym typie.
DivideByZeroException - Wyrzucany, gdy próbujemy dokonać dzielenia przez zero, co jest operacją niedozwoloną w matematyce.
Exception ex - Jest to ogólny wyjątek, który może być używany do przechwytywania różnych rodzajów wyjątków. Jest to ogólna klasa bazowa dla wszystkich wyjątków.
ArgumentOutOfRangeException ex - Wyrzucany, gdy przekazane argumenty są poza zakresem akceptowalnych wartości.
IndexOutOfRangeException - Wyrzucany, gdy indeks używany do odwoływania się do elementu w kolekcji lub tablicy jest poza zakresem dostępnych indeksów.
ArgumentNullException - Wyrzucany, gdy podana wartość (zwykle obiekt) jest równa null, a operacja nie akceptuje wartości null.
