using System;
using System.Collections;
using System.Collections.Specialized;

class Tank:ICloneable
{
    public double masa = 0; // тони
    public int ekipaj = 0;  // кількість людей екіпажу
    public int snaread = 0; // скільки мм снаряд

    public void look()
    {
        Console.WriteLine($"Маса {masa} тон");
        Console.WriteLine($"Екіпаж {ekipaj} людей");
        Console.WriteLine($"Снаряд{snaread} mm");
    }
    public object Clone()
    {
        return MemberwiseClone();
    }

}

class program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Tank[] tanks = new Tank[4]
        {
            new Tank
            {
                masa = 30,
                ekipaj = 3,
                snaread = 225
            },
            new Tank
            {
                masa = 20, 
                ekipaj = 3,
                snaread = 175
            },
            new Tank
            {
                 masa = 50,
                ekipaj = 5,
                snaread = 250
            },
            new Tank
            {
                 masa = 0,
                ekipaj = 0,
                snaread = 0
            }
        };

        for (int i = 0; i < tanks.Length; i++)
        {
            tanks[i].look();
        }

        Console.WriteLine("\nРезультат після додавання ідентичного танку:\n");

        tanks[3] = (Tank) tanks[2].Clone();

        for (int i = 0; i < tanks.Length; i++)
        {
            tanks[i].look();
        }
    }
}
