// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int previousFast = 0;
int previousMedium = 0;
int previousSlow = 0;

for(int i = 2; i < 100; i++)
{
    Console.WriteLine($"Level {i} requires {previousFast + (int)(108.84 * Math.Pow(i - 1, 0.98))} | {previousMedium + (int)(108.11 * Math.Pow(i - 1, 1.05))} | {previousSlow + (int)(111.95 * Math.Pow(i - 1, 1.09))} total EXP to reach");
    previousFast += (int)(108.84 * Math.Pow(i - 1, 0.98));
    previousMedium += (int)(108.11 * Math.Pow(i - 1, 1.05));
    previousSlow += (int)(111.95 * Math.Pow(i - 1, 1.09));
}
