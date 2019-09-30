﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GissaTalForms
{
    public partial class guessNumber : Form
    {
        int numberOfGuesses = 0;
        Random random = new Random();
        int randomNumber;
        public guessNumber()
        {
            randomNumber = random.Next(1, 101);
            InitializeComponent();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(guessInput.Text);
            numberOfGuesses++;
            guessCounterLabel.Text = numberOfGuesses.ToString();
            if(guess<randomNumber)
            {
                guessMessage.Text = "Ditt tal är för lågt!";
            }
            else if(guess>randomNumber)
            {
                guessMessage.Text = "Ditt tal är för högt!";
            }
            else
            {
                guessMessage.Text = "Bra jobbat! Du gissade rätt!";
                guessButton.Enabled = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            randomNumber = random.Next(1, 101);
            numberOfGuesses = 0;
            guessCounterLabel.Text = "0";
            guessMessage.Text = "Du har inte gissat ännu";
            guessInput.Text = "0";
            guessButton.Enabled = true;
        }
    }
}
