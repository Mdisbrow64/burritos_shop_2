Console.WriteLine("enter the card number: ");
string cardnumber = Console.ReadLine();

Console.WriteLine(cardnumber);

Console.WriteLine("How many of the last digits to show: ");
int numdigits = Convert.ToInt32(Console.ReadLine());

string lastfourdigits = cardnumber.Substring(cardnumber.Length - 4);
Console.WriteLine(lastfourdigits);

string mask = "";
for (int i = 0; i < cardnumber.Length - numdigits; i++)
{
	mask = mask + "*";
}

Console.WriteLine(mask);

string maskedstring = $"{mask}{lastfourdigits}";

Console.WriteLine(maskedstring);

