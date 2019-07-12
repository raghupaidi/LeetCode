using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{
    public class SudokoValidaiton
    {

        /* Determine if a 9x9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

                Each row must contain the digits 1-9 without repetition.
                Each column must contain the digits 1-9 without repetition.
                Each of the 9 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.

                A partially filled sudoku which is valid.

                The Sudoku board could be partially filled, where empty cells are filled with the character '.'.

                Example 1:

                Input:
                [
                  ["5","3",".",".","7",".",".",".","."],
                  ["6",".",".","1","9","5",".",".","."],
                  [".","9","8",".",".",".",".","6","."],
                  ["8",".",".",".","6",".",".",".","3"],
                  ["4",".",".","8",".","3",".",".","1"],
                  ["7",".",".",".","2",".",".",".","6"],
                  [".","6",".",".",".",".","2","8","."],
                  [".",".",".","4","1","9",".",".","5"],
                  [".",".",".",".","8",".",".","7","9"]
                ]
                Output: true
                Example 2:

                Input:
                [
                  ["8","3",".",".","7",".",".",".","."],
                  ["6",".",".","1","9","5",".",".","."],
                  [".","9","8",".",".",".",".","6","."],
                  ["8",".",".",".","6",".",".",".","3"],
                  ["4",".",".","8",".","3",".",".","1"],
                  ["7",".",".",".","2",".",".",".","6"],
                  [".","6",".",".",".",".","2","8","."],
                  [".",".",".","4","1","9",".",".","5"],
                  [".",".",".",".","8",".",".","7","9"]
                ]
                Output: false
                Explanation: Same as Example 1, except with the 5 in the top left corner being 
                    modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
                Note:

                A Sudoku board (partially filled) could be valid but is not necessarily solvable.
                Only the filled cells need to be validated according to the mentioned rules.
                The given board contain only digits 1-9 and the character '.'.
                The given board size is always 9x9.
         */

        public bool IsValidSudoku(char[][] board)
        {
            var pass = false;
            foreach (var arr in board)
            {
                if (arr.Where(x => x != '.').Distinct().Count() != arr.Where(x => x != '.').Count())
                {
                    return pass;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                var colArray = new char[9];

                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        if (colArray.Contains(board[j][i]))
                        {
                            return pass;
                        }
                        colArray[j] = board[j][i];
                    }

                }
            }

            var subgridArray1 = new char[9];
            var subgridArray2 = new char[9];
            var subgridArray3 = new char[9];

            var subgridArray1CIndex = 0;
            var subgridArray2CIndex = 0;
            var subgridArray3CIndex = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray1.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray1[subgridArray1CIndex] = board[i][j];
                        subgridArray1CIndex += 1;
                    }
                }

                for (int j = 3; j < 6; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray2.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray2[subgridArray2CIndex] = board[i][j];
                        subgridArray2CIndex += 1;
                    }
                }

                for (int j = 6; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray3.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray3[subgridArray3CIndex] = board[i][j];
                        subgridArray3CIndex += 1;
                    }
                }
            }
            //reset
            subgridArray1 = new char[9];
            subgridArray2 = new char[9];
            subgridArray3 = new char[9];

            subgridArray1CIndex = 0;
            subgridArray2CIndex = 0;
            subgridArray3CIndex = 0;

            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray1.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray1[subgridArray1CIndex] = board[i][j];
                        subgridArray1CIndex += 1;
                    }
                }

                for (int j = 3; j < 6; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray2.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray2[subgridArray2CIndex] = board[i][j];
                        subgridArray2CIndex += 1;
                    }
                }

                for (int j = 6; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray3.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray3[subgridArray3CIndex] = board[i][j];
                        subgridArray3CIndex += 1;
                    }
                }
            }

            //reset
            subgridArray1 = new char[9];
            subgridArray2 = new char[9];
            subgridArray3 = new char[9];

            subgridArray1CIndex = 0;
            subgridArray2CIndex = 0;
            subgridArray3CIndex = 0;
            for (int i = 6; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray1.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray1[subgridArray1CIndex] = board[i][j];
                        subgridArray1CIndex += 1;
                    }
                }

                for (int j = 3; j < 6; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray2.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray2[subgridArray2CIndex] = board[i][j];
                        subgridArray2CIndex += 1;
                    }
                }

                for (int j = 6; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray3.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray3[subgridArray3CIndex] = board[i][j];
                        subgridArray3CIndex += 1;
                    }
                }
            }

            return true;
        }


        public bool IsValidSudoku_v2(char[][] board)
        {
            var pass = false;
            //checking rows
            foreach (var arr in board)
            {
                if (arr.Where(x => x != '.').Distinct().Count() != arr.Where(x => x != '.').Count())
                {
                    return pass;
                }
            }
            //checking columns
            for (int i = 0; i < 9; i++)
            {
                var colArray = new char[9];

                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        if (colArray.Contains(board[j][i]))
                        {
                            return pass;
                        }
                        colArray[j] = board[j][i];
                    }

                }
            }

            //checking subgrids
            var subgridArray1 = new char[9];
            var subgridArray2 = new char[9];
            var subgridArray3 = new char[9];

            var subgridArray1CIndex = 0;
            var subgridArray2CIndex = 0;
            var subgridArray3CIndex = 0;


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray1.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray1[subgridArray1CIndex] = board[i][j];
                        subgridArray1CIndex += 1;
                    }
                }

                for (int j = 3; j < 6; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray2.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray2[subgridArray2CIndex] = board[i][j];
                        subgridArray2CIndex += 1;
                    }
                }

                for (int j = 6; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (subgridArray3.Contains(board[i][j]))
                        {
                            return pass;
                        }
                        subgridArray3[subgridArray3CIndex] = board[i][j];
                        subgridArray3CIndex += 1;
                    }
                }

                if(i==2|| i == 5)
                {
                    //reset
                    subgridArray1 = new char[9];
                    subgridArray2 = new char[9];
                    subgridArray3 = new char[9];

                    subgridArray1CIndex = 0;
                    subgridArray2CIndex = 0;
                    subgridArray3CIndex = 0;
                }
            }           

            return true;
        }
    }
}
