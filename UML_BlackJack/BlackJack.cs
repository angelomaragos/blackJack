// Angelo Maragos
// This program utilizes classes to create a "player" and a "dealer", randomly assign two cards to each, four cards in total, and make a best course of action suggestion 
// for BlackJack

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment4
{

    
     

    class Hand : GetCard  //Hand class deriving from GetCard class
    {
        public Hand()   //constructor
        {
        }
       
       public void logic (string pc1, string pc2, string dc2 )
       {
         int dUpCard =0;
         int p1 = 0;
         int p2 = 0;

           Console.WriteLine("Player has a: {0} and a: {1}.  Dealer's up card is: {2} ", pc1, pc2, dc2);  //if statements to determine value of player and dealer up cards

           if (pc1 == "AH" || pc1 == "AC" || pc1 == "AD" || pc1 == "AS")
           {
               p1 = 0;
           }

           if (pc2 == "AH" || pc2 == "AC" || pc2 == "AD" || pc2 == "AS")
           {
               p2 = 0;
           }

           if (dc2 == "AH" || dc2 == "AC" || dc2 == "AD" || dc2 == "AS")
           {
               dUpCard = 0;
           }


           if (dc2 == "2H" ||dc2 == "2C" || dc2 =="2D" ||dc2 == "2S")
           {
               dUpCard = 2;
           }

           if (dc2 == "3H" || dc2 == "3C" || dc2 == "3D" || dc2 == "3S")
           {
               dUpCard = 3;
           }

           if (dc2 == "4H" || dc2 == "4C" || dc2 == "4D" || dc2 == "4S")
           {
               dUpCard = 4;
           }

           if (dc2 == "5H" || dc2 == "5C" || dc2 == "5D" || dc2 == "5S")
           {
               dUpCard = 5;
           }

           if (dc2 == "6H" || dc2 == "6C" || dc2 == "6D" || dc2 == "6S")
           {
               dUpCard = 6;
           }

           if (dc2 == "7H" || dc2 == "7C" || dc2 == "7D" || dc2 == "7S")
           {
               dUpCard = 7;
           }

           if (dc2 == "8H" || dc2 == "8C" || dc2 == "8D" || dc2 == "8S")
           {
               dUpCard = 8;
           }

           if (dc2 == "9H" || dc2 == "9C" || dc2 == "9D" || dc2 == "9S")
           {
               dUpCard = 9;
           }

           if (dc2 == "10H" || dc2 == "10C" || dc2 == "10D" || dc2 == "10S")
           {
               dUpCard = 10;
           }

           if (dc2 == "JH" || dc2 == "JC" || dc2 == "JD" || dc2 == "JS")
           {
               dUpCard = 10;
           }

           if (dc2 == "QH" || dc2 == "QC" || dc2 == "QD" || dc2 == "QS")
           {
               dUpCard = 10;
           }


           if (dc2 == "KH" || dc2 == "KC" || dc2 == "KD" || dc2 == "KS")
           {
               dUpCard = 10;
           }

           if (pc1 == "2H" || pc1 == "2C" || pc1 == "2D" || pc1 == "2S")
           {
               p1 = 2;
           }

           if (pc1 == "3H" || pc1 == "3C" || pc1 == "3D" || pc1 == "3S")
           {
               p1 = 3;
           }

           if (pc1 == "4H" || pc1 == "4C" || pc1 == "4D" || pc1 == "4S")
           {
               p1 = 4;
           }

           if (pc1 == "5H" || pc1 == "5C" || pc1 == "5D" || pc1 == "5S")
           {
               p1 = 5;
           }

           if (pc1 == "6H" || pc1 == "6C" || pc1 == "6D" || pc1 == "6S")
           {
               p1 = 6;
           }

           if (pc1 == "7H" || pc1 == "7C" || pc1 == "7D" || pc1 == "7S")
           {
               p1 = 7;
           }

           if (pc1 == "8H" || pc1 == "8C" || pc1 == "8D" || pc1 == "8S")
           {
               p1 = 8;
           }

           if (pc1 == "9H" || pc1 == "9C" || pc1 == "9D" || pc1 == "9S")
           {
               p1 = 9;
           }

           if (pc1 == "10H" || pc1 == "10C" || pc1 == "10D" || pc1 == "10S" || pc1 == "JH" || pc1 == "JC" || pc1 == "JD" || pc1 == "JS"
               || pc1 == "QH" || pc1 == "QC" || pc1 == "QD" || pc1 == "QS" || pc1 == "KH" || pc1 == "KC" || pc1 == "KD" || pc1 == "KS")
               
             
           {
               p1 = 10;
           }


           if (pc2 == "2H" || pc2 == "2C" || pc2 == "2D" || pc2 == "2S")
           {
               p2 = 2;
           }

           if (pc2 == "3H" || pc2 == "3C" || pc2 == "3D" || pc2 == "3S")
           {
               p2 = 3;
           }

           if (pc2 == "4H" || pc2 == "4C" || pc2 == "4D" || pc2 == "4S")
           {
               p2 = 4;
           }

           if (pc2 == "5H" || pc2 == "5C" || pc2 == "5D" || pc2 == "5S")
           {
               p2 = 5;
           }

           if (pc2 == "6H" || pc2 == "6C" || pc2 == "6D" || pc2 == "6S")
           {
               p2 = 6;
           }

           if (pc2 == "7H" || pc2 == "7C" || pc2 == "7D" || pc2 == "7S")
           {
               p2 = 7;
           }

           if (pc2 == "8H" || pc2 == "8C" || pc2 == "8D" || pc2 == "8S")
           {
               p2 = 8;
           }

           if (pc2 == "9H" || pc2 == "9C" || pc2 == "9D" || pc2 == "9S")
           {
               p2 = 9;
           }

           if (pc2 == "10H" || pc2 == "10C" || pc2 == "10D" || pc2 == "10S" || pc2 == "JH" || pc2 == "JC" || pc2 == "JD" || pc2 == "JS"
               || pc2 == "QH" || pc2 == "QC" || pc2 == "QD" || pc2 == "QS" || pc2 == "KH" || pc2 == "KC" || pc2 == "KD" || pc2 == "KS")
           {
               p2 = 10;
           }

           //private data memebers to make avaialbe to make data available to other methods
           prvP1 = p1;               
           prvP2 = p2;
           prvD2 = dUpCard;

           int playerCardVal =  p1 + p2;

      
       }

 
       public void strategy()
       {
         int  pc1 = prvP1;
         int  pc2 = prvP2;
         int yourHand = pc1 + pc2;
        int   dc2 = prvD2;
        string answer = "Hit";
        string[,] strat = new string[20, 20];  //  two dimmentsional strategy array to store string values (d, s, h) 

        strat[9, 3] = "Double";
        strat[9, 4] = "Double";
        strat[9, 5] = "Double";
        strat[9, 6] = "Double";
        strat[12, 4] = "Stand";
        strat[12, 5] = "Stand";
        strat[12, 6] = "Stand";



           if (yourHand < 9 )
           {
               answer = "Hit";
               strat[yourHand, dc2] = answer;
           }
        

           if (yourHand == 10 && dc2 != 10 || yourHand == 10 && dc2 != 0)
           {
               answer = "Double";
           }

           if (yourHand == 11 && dc2 != 0 )
           {
               answer = "Double";
           }

           if (yourHand > 12 && yourHand <17 && dc2 < 7)
           {
               answer = "Stand";
           }

           if (yourHand >= 17)
           {
               answer = "Stand";
           }

           Console.WriteLine("The reccommended strategy is to {0} ", answer);
       }




       int prvP1 = 0;
       int prvP2 = 0;
       int prvD2 = 0;

    }


   
   class GetCard
    {
        public GetCard()  //constructor
        {
           
        }


        public string getC(int randomNum)  //passing in random number to getC method to randomly select card
        {
         string[] allCards = new string[] {"2H", "2C", "2D", "2S","3H", "3C", "3D", "3S",
        "4H", "4C", "4D", "4S", "5H", "5C", "5D", "5S", "6H", "6C", "6D", "6S",
        "7H", "7C", "7D", "7S", "8H", "8C", "8D", "8S", "9H", "9C", "9D", "9S",
        "10H", "10C", "10D", "10S", "JH", "JC", "JD", "JS", "QH", "QC", "QD", "QS",
        "KH", "KC", "KD", "KS", "AH", "AC", "AD", "AS"};


         return allCards[randomNum];  //return random card


        }

       /*

        public int randNum()
        {
            Random generator = new Random();
            int numberGenerated = generator.Next(0, 52);

            return numberGenerated;
        }
  
       */



    }

   


     class Player : GetCard  //player class derives from GetCard class
    {
        public Player()  //player constructor
        {
            
        }

       public string [] Cards (string [] card)  //passing (2) random cards to player via array
        {
           
           string [] mycards = new string [10];

           for (int i = 0; i < 2; i++)
           {
               mycards[i] = card[i];


           }

           return mycards;
        }

    }


  class Dealer : GetCard   //dealer class derives from GetCard class
    {
        public Dealer()  //constructor
        {
      

        }

        public string[] dealerCards(string[] card)  //passing (2) random cards to dealer via array
        {

            string[] mycards = new string[10];


            for (int i = 0; i < 2; i++)
            {
                mycards[i] = card[i];


            }


            return mycards;
        }

    





    }

    
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] shoeArr = new int[52];  //shoeArr to keep track of what randomly generated cards have been selected
           
            int numberGenerated = 0;
            Player Angelo = new Player();  //creating player object
            Dealer Casino = new Dealer();  //creating dealer object


            GetCard a = new GetCard();  //creating GetCard object
            Hand h = new Hand();        //creating hand object

            Random generator = new Random();  

            int counter = 0;
            int shoe1 = 156;   //3 decks of 52 cards = 156
            bool quit = false;  // used for logic in quitting or continuing loop

            


            while (counter < (shoe1 - 5) && !quit)  //counter tallys how many cards have been dealt.  Shoe1 (156) - 5...figures that you'd need atleast 5 cards to play one round of 
                //BlackJack.  Two cards for dealer, two cards for player with an option to hit once.
            {


             int i = numberGenerated;
             numberGenerated = generator.Next(0, 52);  //randomly picks a number for a card to assign.
             shoeArr[i] = shoeArr[i] + 1; //keeps track of how often a particular card is selected
             if (shoeArr[i] > 3)    //if a particular card is selected more than 3 times, pick another random number (card)
             {
               i  = generator.Next(0, 52);
      
               shoeArr[i] = shoeArr[i] + 1;
               counter ++;  
             }

               

            
            string agm = a.getC(i);   


                Random generator2 = new Random();
                int numberGenerated2 = generator.Next(0, 52);

             
            int i2 = numberGenerated2;
            shoeArr[i2] = shoeArr[i2] + 1;
            if (shoeArr[i2] > 3)
            {
                i2 = generator.Next(0, 52);
      
                shoeArr[i2] = shoeArr[i2] + 1;
                counter++;
            }


               

                string agm2 = a.getC(i2);


                string[] arr = new string[] { agm, agm2 };

                Angelo.Cards(arr);  //assigning two "cards" to Angelo.Cards.    Angelo in this case represents player



                Random generator3 = new Random();
                int numberGenerated3 = generator.Next(0, 52);


               int i3 = numberGenerated3;
               shoeArr[i3] = shoeArr[i3] + 1;
              if (shoeArr[i3] > 3)
               {
                   i3  = generator.Next(0, 52);
          
                   shoeArr[i3] = shoeArr[i3] + 1;
                   counter++;
               }
               

                string agm3 = a.getC(i3);


                Random generator4 = new Random();
                int numberGenerated4 = generator.Next(0, 52);

             
               int i4 = numberGenerated4;
               shoeArr[i4] = shoeArr[i4] + 1;
              if (shoeArr[i4] > 3)
               {
                   i4  = generator.Next(0, 52);
                   Console.WriteLine("generator4 from if statement running {0}", i4);
                   shoeArr[i4] = shoeArr[i4] + 1;
                   counter++;
               }


                string agm4 = a.getC(i4);


                string[] casino_arr = new string[] { agm3, agm4 };  //two cards for dealer

                Casino.dealerCards(casino_arr);  //assigning two cards to Casion/dealer

                Console.WriteLine("Player has two cards. Dealer has two cards. One card face down, one card face up");

                counter = counter + 4;  //Four cards dealt.  2 to dealer two to player



                h.logic(agm, agm2, agm4);  //determine value of players two cards and dealer up card

                Console.WriteLine("Press Enter to see suggested BlackJack strategy.");
                Console.ReadLine();



                h.strategy();  ////strategy...what is the suggested move by the player, given players two cards and Dealers up card

                Console.WriteLine("Player had {0} and {1}.  Dealer had {2} and {3} ", agm, agm2, agm3, agm4); //display all cards that player and dealer were dealt

                Console.WriteLine();
                Console.WriteLine(" Game Over ");
                Console.WriteLine();

                Console.WriteLine();
            //    Console.WriteLine("counter is {0}", counter);
                Console.WriteLine("Continue playing? Enter Y to continue.  Enter N to end. ");

             
               

                string value2;


           value2 = Console.ReadLine();
           string upper2 = value2.ToUpper();
             if (upper2 == "N")
             {
                 
                 quit = true;
             }
                
            


             else
             {
                 quit = false;
             }



            }

            if (counter > (shoe1 - 5))
            {
                Console.WriteLine("The deck/shoe is empty.");  //end if out of enough cards in shoe1
            }

            else
            Console.WriteLine("Exiting ... Press Enter");  //confirm end

            Console.ReadLine();


           

       
        }


    }
}
