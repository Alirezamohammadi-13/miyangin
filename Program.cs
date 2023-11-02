Console.WriteLine("Alireza mohammadi");
Console.WriteLine("miyangin nomre");



int tedad = 0;
double nomarat = 0;
double zarib;
double kol = 0;
int yesorno;
do
{
    Console.WriteLine("nomre dars ra vared konid");
    double nomre = Convert.ToDouble(Console.ReadLine());
    nomarat += nomre;

    Console.WriteLine("chand vahedi ast?");
    int adad = Convert.ToInt32(Console.ReadLine());
    tedad += adad;

    zarib = adad * nomre;
    kol += zarib;
    Console.WriteLine("aya mayel be edame hastin? 1bale 2 kheyr");

    yesorno = Convert.ToInt32(Console.ReadLine());


} while (yesorno == 1);
Console.WriteLine("miyangin shoma:");
Console.WriteLine(kol / tedad);
Console.WriteLine(" tamam");
