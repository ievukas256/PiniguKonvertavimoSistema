Console.WriteLine("Iveskite EUR kiekį:");
decimal input = int.Parse(Console.ReadLine());

string[] currName = {"USD","PLN","BYR" };
decimal[] currExchange = { 0.97350M, 4.57400M, 0.4M };
bool result =true;

while (result)
{
    Console.WriteLine("Konvertuoti į:USD, PLN, BYR, jei norite baigti spauskite N:");
    string currency = Console.ReadLine();

    switch (currency) {
        case "USD":
            {
                Console.WriteLine($"{input} EUR = {ExchangeUSD(input, currExchange)}USD");
                break;
            }
        case "PLN":
            {
                Console.WriteLine($"{input} EUR = {ExchangePLN(input, currExchange)}PLN");
                break;
            }
        case "BYR":
            {
                Console.WriteLine($"{input} EUR = {ExchangeBYR(input, currExchange)}BYR");
                break;
            }
        case "N":
            {
                result = false;
                break;
            }
        default:
            {
                Console.WriteLine("Pasirinktas netinkamas veiksmas.");
                break;
            }
    }
}
 decimal ExchangeUSD(decimal input, decimal []currExchange)
{
    return  input * currExchange[0];
}

decimal ExchangePLN(decimal input, decimal[] currExchange)
{
    return input * currExchange[1];
}

decimal ExchangeBYR(decimal input, decimal[] currExchange)
{
    return input * currExchange[2];
}