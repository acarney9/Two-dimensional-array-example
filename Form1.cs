using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alex Carney
//11/16/2017
namespace StudentAvgTwoDimArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showScoresButton_Click(object sender, EventArgs e)
        {
            //Create a 2 dim array to display data

            double[,] scores = { { 78, 94, 67},
                                 { 97, 93, 90},
                                 { 65, 67, 71},
                                 { 84, 85, 87}
                                };

            // pass the array to ShowData method
            ShowData(scores);
        }


        private void ShowData(double[,] theScores)
        {
            string output = "";

            for (int row = 0; row < theScores.GetLength(0); row++)
            {
                for (int col = 0; col < theScores.GetLength(1); col++)
                {
                    // traverse the array and concatenate the number

                    output = output + theScores[row, col] + " ";
                }

                output += "\n";

                displayLabel.Text = output;
            }
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            double[,] scores = { { 78, 94, 67},
                                 { 97, 93, 90},
                                 { 65, 67, 71},
                                 { 84, 85, 87}
                                };

            ShowStudentAverages(scores);

        }


        private void ShowStudentAverages(double[,] theScores)
        {
            string output = "";
            double studentSum = 0;
            double studentAvg = 0;

            for (int row = 0; row < theScores.GetLength(0); row++)
            {
                for (int col = 0; col < theScores.GetLength(1); col++)
                {
                    studentSum += theScores[row, col];

                }

                studentAvg = studentSum / theScores.GetLength(1);

                output += "Student " + (row + 1) + " Avg: " + studentAvg.ToString("n2") + "\n";

                studentSum = 0;


            }

            displayLabel.Text = output;
        }

        private void testAverageButton_Click(object sender, EventArgs e)
        {

            
                double[,] scores = { { 78, 94, 67},
                                     { 97, 93, 90},
                                     { 65, 67, 71},
                                     { 84, 85, 87}
                                    };

                ShowTestAverages(scores);

        }


        private void ShowTestAverages(double[,] theScores)
        {
                string output = "";
                double testSum = 0;
                double testAvg = 0;

                for (int col = 0; col < theScores.GetLength(1); col++)
                {
                    for (int row = 0; row < theScores.GetLength(0); row++)
                    {
                        testSum += theScores[row, col];

                    }

                    testAvg = testSum / theScores.GetLength(0);

                    output += "Test " + (col + 1) + " Avg: " + testAvg.ToString("n2") + "\n";

                    testSum = 0;


                }

                displayLabel.Text = output;

        }

    }
}

    

