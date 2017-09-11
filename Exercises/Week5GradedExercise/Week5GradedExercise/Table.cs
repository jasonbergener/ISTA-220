using System;
/* 
 * Author: Jason Bergener
 * Description: The instructions were to use arrays to return the winning bets
 * that result in each possible outcome of the roulette wheel.
 * This class supports the main program and encapsulates the table data.
*/

namespace Week5GradedExercise
{
    class Table
    {
        private int[,] table = new int[12, 3] { //defines the structure of the table
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 },
            { 13, 14, 15 },
            { 16, 17, 18 },
            { 19, 20, 21 },
            { 22, 23, 24 },
            { 25, 26, 27 },
            { 28, 29, 30 },
            { 31, 32, 33 },
            { 34, 35, 36 }
        };
        //provides the default color scheme for a roulette wheel/table
        private int[] black = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        private int[] red = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        public int GetNum(int row, int column) //returns the value of the table element
        {
            return table[row, column];
        }

        public string GetColor(int i) //returns the color of the input (works with RandomColors())
        {
            string color = null;
            if (i == 0 || i == 37)
            {
                color = "green";
            }
            foreach (int c in black)
                if (c == i)
                {
                    color = "black";
                }
            foreach (int c in red)
                if (c == i)
                {
                    color = "red";
                }
            return color;
        }

        public int Column(int i) //returns the column of the input
        {
            for (int row = 0; row < 12; row++) //steps through each row
            {
                for (int column = 0; column < 3; column++) //steps through each column of each row
                {
                    if (table[row, column] == i) //looks for the match
                    {
                        return column;
                    }
                }
            }
            return -1;
        }

        public int Row(int i) //returns the row of the input
        {
            for (int row = 0; row < 12; row++) //steps through each row
            {
                for (int column = 0; column < 3; column++) //steps through each column of each row
                {
                    if (table[row, column] == i) //looks for the match
                    {
                        return row;
                    }
                }
            }
            return -1;
        }

        public void RandomColors() //This is unimplemented, but allows randomizing the colors
        {
            int blackCount = 0; //these make sure there are an equal number of each color (18)
            int redCount = 0;
            Random random = new Random();
            for (int i = 1; i < 37; i++)
            {
                int temp = (int)random.Next(2);
                if (temp == 0)
                {
                    if (blackCount > 17)
                    {
                        red[redCount] = i;
                        redCount++;
                    }
                    else
                    {
                        black[blackCount] = i;
                        blackCount++;
                    }
                }
                else if (temp == 1)
                {
                    if (redCount > 17)
                    {
                        black[blackCount] = i;
                        blackCount++;
                    }
                    else
                    {
                        red[redCount] = i;
                        redCount++;
                    }
                }
            }
        }
    }
}
