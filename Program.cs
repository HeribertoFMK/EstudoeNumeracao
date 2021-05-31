using System;
using enumeracao.Entities.Enums;
using enumeracao.Entities;


namespace enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ordem = new Order{

                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.AguardandoPagamento





            };
            
            
            Console.WriteLine(ordem);

            string txt = OrderStatus.AguardandoPagamento.ToString();



            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("FazendoEntrega");
            

           
             Console.WriteLine(os);
            


        }
    }
}
