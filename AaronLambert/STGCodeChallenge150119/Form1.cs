using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STGCodeChallenge150119
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DoTheWork();
        }

        private void DoTheWork()
        {
            string isbn = txtInput.Text.Trim();
            MessageBox.Show(string.Format("{0} is{1} a valid ISBN.", isbn, (ValidateISBN(isbn) ? "" : " not")));

        }

        private bool ValidateISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) return false;

            // Remove any dashes
            isbn = isbn.Replace("-", "");

            // Must be 10 digits
            if (isbn.Length != 10) return false;

            // Validate the ISBN using the mathematical hash
            int hash = 0;
            if (!CalculateHash(isbn, out hash))
            {
                return false;
            }

            // The calculated value must be evenly divisible by 11
            return ((hash % 11) == 0);
        }

        private bool CalculateHash(string isbn, out int hash)
        {
            // Validate the ISBN using the mathematical hash
            hash = 0;
            for (int i = 0; i < 10; i++)
            {
                // Must be a valid number - make sure each char is a digit
                string c = isbn.Substring(i, 1);
                int d = 0;
                if (!int.TryParse(c, out d))
                {
                    // The final char can be X, which represents 10
                    if (c == "X" && i == 9)
                    {
                        d = 10;
                    }
                    else
                    {
                        return false;
                    }
                }
                hash += d * (10 - i);
            }
            return true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string isbn = "";
            Random rand = new Random();

            for (int i = 0; i < 9; i++)
            {
                isbn += rand.Next(9);
            }
            int hash = 0;
            CalculateHash(isbn + "0", out hash);
            int dx = (hash % 11);
            if (dx == 0)
            {
                isbn += "0";
            }
            else if (dx == 1)
            {
                isbn += "X";
            }
            else
            {
                isbn += (11 - dx);
            }
            txtInput.Text = isbn.Insert(9, "-").Insert(5, "-").Insert(1, "-");
        }
    }
}
