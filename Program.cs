



// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 0;
while(i<10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

//  1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int a = 2;
while (a < 20)
{
    Console.WriteLine(a);
    a++;
}


//  1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int b = 2;
while (b < 20)
{
    if (b % 2 == 0)
    {
      Console.WriteLine(b);      
    }

    b++;
}

//  50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;
int c = 51;

while (c < 150)
{
    toplam += c;
    c++;
}

Console.WriteLine(toplam);

//  1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int toplamtek = 0;
int toplamcift = 0;
int d = 1;

while (d < 120)
{
    if ((d % 2) == 0)
    {
        toplamcift += d;
    }

    else
    {
        toplamtek += d;
    }

    buyuktoplam += d;
    d++;

  }

Console.WriteLine(toplamtek);
Console.WriteLine(toplamcift);
