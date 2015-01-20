using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallenge7 {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
        }

        private void cmdValidate_Click(object sender, EventArgs e) {

            lblResult.Text = IsValidISBN(txtISBN.Text).ToString();

        }

        private bool IsValidISBN(string pISBN) {

            char[] validChar = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'X' };
            string isbn = string.Empty;
            int theSum = 0;

            bool isValid = false;

            foreach (char c in pISBN) {
                if (validChar.Contains(c)) {
                    isbn += c.ToString().ToUpper();
                }
            }

            if (isbn.Length == 10) {

                for (int i = 10, j = 0; i > 1; i--, j++) {
                    theSum += (int.Parse(isbn[j].ToString()) * i);
                }

                theSum += (isbn[9].ToString() == "X") ? 10 : int.Parse(isbn[9].ToString());

                isValid = (theSum % 11 == 0);

            } else {
                isValid = false;
            }

            return isValid;
        }

        private void cmdGenerate_Click(object sender, EventArgs e) {

            lblNewISBN.Text = GenerateISBN();

            lblResult.Text = IsValidISBN(lblNewISBN.Text).ToString();

        }

        private string GenerateISBN() {

            Random r = new Random();

            int x = r.Next(999999999);//Max range

            string isbn = string.Format("{0:000000000}", x);

            int theSum = 0;
            int temp = 0;
            for (int i = 10, j = 0; i > 1; i--, j++) {
                theSum += (int.Parse(isbn[j].ToString()) * i);
            }

            for (int i = 0; i <= 10; i++) {

                temp = theSum;

                temp += i;

                if (temp % 11 == 0) {
                    isbn += (i == 10) ? "X" : i.ToString();
                }
            }

            return isbn;
        }
    }
}
