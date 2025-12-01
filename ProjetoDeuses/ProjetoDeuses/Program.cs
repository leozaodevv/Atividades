// See https://aka.ms/new-console-template for more information
Console.WriteLine("É um ser divino? s/n");
char res = Convert.ToChar(Console.ReadLine());
if (res == 's')
{
    Console.Clear();
    Console.WriteLine("Ele vive no olimpo? s/n");
    res = Convert.ToChar(Console.ReadLine());
    if (res == 's')
    {
        Console.Clear();
        Console.WriteLine("Qual é um dos poderes desse deus?\n\n1 - Raio\n2 - Água\n3 - Guerra");
        res = Convert.ToChar(Console.ReadLine());
        if(res == '1')
        {
            Console.Clear();
            Console.WriteLine("Esse deus é ZEUS.");
        }
        else if(res == '2')
        {
            Console.Clear();
            Console.WriteLine("Esse deus é POSEIDON.");
        }
        else if (res == '3')
        {
            Console.Clear();
            Console.WriteLine("Em qual sentido essa Guerra se encaixa mais:\n\n1 - Bruta, selvagem e destruição\n2 - Estratégica, inteligência militar e táticas ");
            res = Convert.ToChar(Console.ReadLine());   
            if(res == '1')
            {
                Console.Clear();
                Console.WriteLine("Esse deus é ARES.");
            }
            else if(res == '2')
            {
                Console.Clear();
                Console.WriteLine("Essa deusa é Atena");
            }
        }
    }
    else if(res == 'n')
    {
        Console.Clear();
        Console.WriteLine("Local onde vive:\n\n1 - Submundo\n2 - Natureza\n3 - Céu");
        res = Convert.ToChar(Console.ReadLine());
        if(res == '1')
        {
            Console.Clear();
            Console.WriteLine("Controla o Submundo? s/n");
            res = Convert.ToChar(Console.ReadLine());
            if(res == 's')
            {
                Console.Clear();
                Console.WriteLine("Esse deus é HADES.");
            }
            else if (res == 'n')
            {
                Console.Clear();
                Console.WriteLine("Ao que esse deus é associado?\n\n1 - Noite\n2 - Morte\n3 - Escuridão");
                res = Convert.ToChar(Console.ReadLine());
                if (res == '1')
                {
                    Console.Clear();
                    Console.WriteLine("Esse deus é NIX.");
                }
                else if(res == '2')
                {
                    Console.Clear();
                    Console.WriteLine("Esse deus esta mais ligado à:\n\n1 - Necromancia, magia\n2 - Personificação da Morte");
                    res = Convert.ToChar(Console.ReadLine());
                    if(res == '1')
                    {
                        Console.Clear();
                        Console.WriteLine("Essa deusa é HÉCATE.");
                    }
                    else if (res == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("Esse deus é TÂNATO.");
                    }
                }
                else if(res == '3')
                {
                    Console.Clear();
                    Console.WriteLine("Esse deus é ÉREBO.");
                }
            }
        }
        else if(res == '2')
        {
            Console.Clear();
            Console.WriteLine("Esse deus esta mais associado à:\n\n1 - Florestas e montanhas\n2 - Bosques\n3 - Fonte de rios doces.");
            res = Convert.ToChar(Console.ReadLine());
            if(res == '1')
            {
                Console.Clear();
                Console.WriteLine("Esse deus é PAN.");
            }
            else if(res == '2')
            {
                Console.Clear();
                Console.WriteLine("Esse deus é SÁTIROS.");
            }
            else if(res == '3')
            {
                Console.Clear();
                Console.WriteLine("Esse deus é NÁIADES.");
            }
        }
        else if(res == '3')
        {
            Console.Clear();
            Console.WriteLine("Esse Deus esta mais associado ao:\n\n1 - Sol\n2 - Lua\n3 - Aurora");
            res = Convert.ToChar(Console.ReadLine());
            if(res == '1')
            {
                Console.Clear();
                Console.WriteLine("Esse Deus é HÉLIOS.");
            }
            else if (res == '2')
            {
                Console.Clear();
                Console.WriteLine("Essa deusa é SELENE.");
            }
            else if(res == '3')
            {
                Console.Clear();
                Console.WriteLine("Essa deus é EOS.");
            }
        }
    }

}
else if (res == 'n')
{
    Console.WriteLine("É um semi-deus?");
}
