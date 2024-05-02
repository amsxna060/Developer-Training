using System;

namespace games
{
    enum Powers{
        Rock=1,
        Paper,
        Scissor
    }
    
    class Game{
        // can't use var in return type
        static string tell_winner(int uc,int rc){
            if (uc == rc) return "draw";
            if((uc==1 && rc==3) 
             ||(uc==2 && rc==1) 
             ||(uc==3 && rc==2))
            return "You win the Game....!!!";
            else
                return "You lost this Game, Better luck next time...(＾-＾)b";
        }
        public static void RockPaperScissor(){
            replay:
            System.Console.WriteLine($"Choose a option : \n1.Rock\n2.Paper\n3.Scissor");
            var user_choosed = (Powers)int.Parse(Console.ReadLine());
            System.Console.WriteLine($"You choosed {user_choosed}.");
            Random rd = new Random();
            int n =  rd.Next(1,4);
            var robot_choosed = (Powers)n;
            System.Console.WriteLine($"Robot choosed {robot_choosed}.");
            var winner = tell_winner((int)user_choosed,(int)robot_choosed);
            if(winner == "draw"){
                Console.WriteLine("___IT'S A DRAW___, \n Wanna play Again?");
                System.Console.WriteLine($"Choose a option : \n1.Yes\n2.No");
                bool isYes = (int.Parse(Console.ReadLine())==1)?true:false;
                if (isYes) goto replay;
            }else{
                Console.WriteLine(winner);
            }
        }
    }
}