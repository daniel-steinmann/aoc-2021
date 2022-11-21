// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

class Day4
{
    static void Main(string[] args)
    {
        string filepath = "sample_input.txt";
        List<int> bingoNumbers = new();
        List<int[,]> numberBoards = new();
        bingoParser(bingoNumbers, numberBoards, filepath);
        // int bingoParser(List<int> bingoNumbers, List<int[]> numberBoards, filepath)

        // create equally sized list of boards for markers

        // void markNumber(ref int markerBoard, int numberBoard, int bingoNumber)

        // bool checkIfWinner(ref int markerBoard)

        // List<int> getUnmarkedNumbers(ref int markerBoard, int numberBoard)
    }

    static int bingoParser(List<int> bingoNumbers, List<int[,]> numberBoards, string filepath)
    {
        using (StreamReader sr = File.OpenText(filepath))
        {
            string s = "";
            int lineNumber = 0;
            int numberBoardIndex = 0;

            // Read first line
            while ((s = sr.ReadLine()) != null)
            {
                if (lineNumber == 0)
                {
                    string bingoNumberLine = s;
                    bingoNumbers = bingoNumberLine.Split(",").Select(x => Int32.Parse(x)).ToList();
                }

                if ((lineNumber - 2) % 6 == 0)
                {
                    numberBoardIndex++;
                }
            }

            // Read boards





            lineNumber++;
        }
        return 1;
    }
}
