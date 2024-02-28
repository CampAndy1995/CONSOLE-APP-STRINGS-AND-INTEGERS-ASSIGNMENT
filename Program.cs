using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Strings_And_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "divided by" + numberTwo + "equals" + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
         
            
            //List<Player> players = new List<Player>();

            //Player player1 = new Player("Chad");
            //Player player2 = new Player("Steve");
            //Player player3 = new Player("Karen");

            //players.Add(player1);
            //players.Add(player2);
            //players.Add(player3);

            //foreach (Player player in players)
            //{
            //    Console.WriteLine(player.username);
            //}


            //Console.ReadKey();
        }
    }
}

//class Player
//{
//    public String username;

//    public Player(String username)
//    {
//        this.username = username;
//    }

//    public override string ToString()
//    {
//        return base.ToString();
//    }
//}
