namespace Homework6;


class Program
{
    static void Main()
    {
        BankCard c1 = new("3749238875837284", "6485", "347", "10/15", 3874.3);
        BankCard c2 = new("1234567890123456", "1234", "123", "12/12", 123.45);
        BankCard c3 = new("4567834566788945", "5678", "257", "09/25", 202.3);
        BankCard c4 = new("6654657954589936", "4672", "578", "04/30", 7358.5);
        BankCard c5 = new("5306156121356869", "2256", "543", "11/27", 2021.23);

        Client u1 = new("Name1", "Surname1", c1);
        Client u2 = new("Name2", "Surname2", c2);
        Client u3 = new("Name3", "Surname3", c3);
        Client u4 = new("Name4", "Surname4", c4);
        Client u5 = new("Name5", "Surname5", c5);


        Client[] Users = { u1, u2, u3, u4, u5 };
       List<string> info=new List<string>();

        string pin;

        while(true)
        {
            Console.WriteLine("Enter your PIN");
            pin= Console.ReadLine();
            for (int i = 0; i < Users.Length; i++)
            {
                if (pin == Users[i].Card?.PIN)
                {
                    Console.WriteLine($"{Users[i].Name} {Users[i].Surname} Welcome!");
                    Console.WriteLine($@"1.Balans
2.Nagd Pul
3.Edilen Emeliyyatlar siyahisi
4.Kartdan Karta Kochurme");
                    int v = Convert.ToInt32(Console.ReadLine());
                    switch (v)
                    {
                        case 1:
                            Console.WriteLine(Users[i].Card?.Balance);
                            break;
                        case 2:
                            Console.WriteLine($@"1. 10AZN
2. 20AZN
3. 50AZN
4. 100AZN
5. Diger");
                            v = Convert.ToInt32(Console.ReadLine());
                            switch (v)
                            {
                                case 1:
                                    if (10 < Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= 10;
                                        info.Add($"Balance-=10, at {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                    break;
                                case 2:
                                    if (20 < Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= 20;
                                        info.Add($"Balance-=20, at {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                    break;
                                case 3:
                                    if (50 < Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= 50;
                                        info.Add($"Balance-=50, at {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                    break;
                                case 4:
                                    if (100 < Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= 1000;
                                        info.Add($"Balance-=100, at {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter amount");
                                    int mon= Convert.ToInt32(Console.ReadLine());
                                    if (mon < Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= mon;
                                        info.Add($"Balance-={mon}, at {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            foreach (var inf in info)
                                Console.WriteLine(inf);
                            break;
                        case 4:
                            Console.WriteLine("Enter his PIN");
                            pin= Console.ReadLine();
                            for (int j = 0; j < Users.Length; j++)
                            {
                                if(Users[j].Card.PIN==pin)
                                {
                                    Console.WriteLine("Enter Amount");
                                    double amount=Convert.ToDouble(Console.ReadLine());
                                    if(amount<Users[i].Card.Balance)
                                    {
                                        Users[i].Card.Balance -= amount; 
                                        Users[j].Card.Balance += amount;
                                        info.Add($"{Users[j].Card.PIN} e {amount} kochuruldu, time: {DateTime.Now}");
                                    }
                                    else throw new Exception("No Enough Balance");
                                }
                            }

                            break;

                        default:
                            break;
                    }
                    break;
                }     
            }

            



        }
    }
}