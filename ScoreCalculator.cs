/**************************************************************************************************************************************
 * Naveen Reddy
 * C0838989
 * 2022-02-11
 * TEST - 1
 * Question - 2
***************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class ScoreCalculator : Form
    {
        // global variables to use in the functions:
        int scoretotal;
        int scorecount;
        public ScoreCalculator()
        {
            InitializeComponent();
        }
        /*****************************************************************************************************************************
         * this method loads the after click event on btnExit
         * and this method is used to close the application
         ****************************************************************************************************************************/
        private void btnExit_Click(object sender, EventArgs e)
        {  // this will close the window or the apllcication
            this.Close();
        }


        /*****************************************************************************************************************************
         * this method loads the after click event on btnAdd
         * this methods add the user score and calculates the count, avg.
        ******************************************************************************************************************************/
        private void btnAdd_Click(object sender, EventArgs e)
        {   // variables to store average and score.
            decimal average;
            // here we take the score input from user.
            int score = Convert.ToInt32(txtScore.Text);
            // scoretotal is calculated by adding score to it.
            scoretotal += score;
            // scorecount is calculated by adding 1 to its every click.
            scorecount += 1;
            // calculating average .
            average = scoretotal / scorecount ;

            // printing the calculated total score.
            txtScoreTotal.Text = scoretotal.ToString();
            // printing the calculated total print.
            txtScoreCount.Text = scorecount.ToString();
            // printing the average .
            txtAverage.Text = average.ToString();
            // cursor waits to the user at score text box and shows focus.
            txtScore.Focus();
            // clears the score text box and makes empty text box.
            txtScore.Text = "";
        }

        /****************************************************************************************************************************
         * this method loads the after click event on btnExit
         * this method will clear all the previous data in the text boxes.
         ****************************************************************************************************************************/
        private void btnClearScores_Click(object sender, EventArgs e)
        {   // here we are making scoretotal and scorecount values to zero 
            // after clicking the btnclearscore it shoud clear all the values 
            scoretotal = 0;
            scorecount = 0;

            // here we are making textaverage,score,count and txttotal to empty text box
            txtAverage.Text = "";
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            // cursor waits to the user at score text box and shows focus.
            txtScore.Focus();
            
        }
    }
}
/**************************************************************************************************************************************
 *                                                              JOKE
 **************************************************************************************************************************************              
 * Customer : "waiter, do you serve crabs?"
 * Waiter : "Please sit down sir, we serve everyone."
 **************************************************************************************************************************************
 *                                                         END OF THE TEST - 1
 **************************************************************************************************************************************
 */