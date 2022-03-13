using System;
using System.Collections;
using static System.Console;

namespace Chess_Board_Cell_Color
{
/*
Task
Given two cells on the standard chess board, determine whether they have the same color or not.

Example
For cell1 = "A1" and cell2 = "C3", the output should be true.
For cell1 = "A1" and cell2 = "H3", the output should be false.

Input/Output
[input] string cell1

[input] string cell2

[output] a boolean value

true if both cells have the same color, false otherwise.
*/

    class Program
    {

        public bool ChessBoardCellColor(string cell1, string cell2)
        {
            int index = 0;
            char[] white = new char[8]{'1', '2', '3', '4', '5', '6', '7', '8'};
            char[] black = new char[8]{'1', '2', '3', '4', '5', '6', '7', '8'};



            
            string newCell1 =  cell1.Remove(index, 1);
            string newCell2 =  cell2.Remove(index, 1);
            WriteLine(newCell1 + " " + newCell2);
            char[] charCell1 = newCell1.ToCharArray();
            char[] charCell2 = newCell2.ToCharArray();

            if(charCell2 == charCell1)
            {                
                return true;
            }
            else return false;
        }
            
        //    string[] checkBoardA = new string[8]{"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8"};
        //    string[] checkBoardB = new string[8]{"B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8"};
        //    string[] checkBoardC = new string[8]{"C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8"};
        //    string[] checkBoardD = new string[8]{"D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8"};
        //    string[] checkBoardE = new string[8]{"E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8"};
        //    string[] checkBoardF = new string[8]{"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8"};
        //    string[] checkBoardG = new string[8]{"G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8"};
        //    string[] checkBoardH = new string[8]{"H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8"};

        //    string[,] checkBoard = new string[64,64];
       
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ChessBoardCellColor("A1", "B2");
        }
    }
}
