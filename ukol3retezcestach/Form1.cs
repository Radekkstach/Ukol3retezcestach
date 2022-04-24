using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3retezcestach
{
//    V TextBox je dán řetězec slov.Slova jsou oddělena jednou mezerou.
//Spočítejte:
//- počet slov
//- počet cifer
//- počet písmen
//- nejdelší slovo
//- vložení posledního znaku doprostřed (Má-li zadaný řetězec lichý počet znaků, pak poslední znak
//vložte před prostřední znak. (Např. “ABCDEF” -> “ABCFDEF”, “ABC” -> “ACBC”)).
//Vše spočítejte pomocí jednoho cyklu.
//Po stisku tlačítka údaje zobrazte do komponent Label.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;
            textBox2.Text = text.Substring(0, text.Length / 2) + text.Last() + text.Substring(text.Length / 2);
            int pocetslov = 0;
            int pocetcifer = 0;
            int pocetpismen = 0;
            int predchozi = 0;
            string nejdelsislovo = "";
            string cisla = "0 1 2 3 4 5 6 7 8 9";
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz ěščřžýáíéůú";
            text = text.Trim();
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            text = text.ToLower();
            string[] slova = text.Split(' ');
            
            foreach(string slovicka in slova)
            {
                pocetslov++;
                foreach(char cifra in slovicka)
                {
                    if(cisla.Contains(cifra))
                    {
                        pocetcifer++;
                    }
                    if(abecedniZnaky.Contains(cifra))
                    {
                        pocetpismen++;
                    }

                }
                if(slovicka.Length > predchozi)
                {
                    predchozi = slovicka.Length;
                    nejdelsislovo = slovicka;
                }

            }
            label1.Text = "Pocet slov: " + pocetslov;
            label2.Text = "Pocet cifer: " + pocetcifer;
            label3.Text = "Pocet pismen: " + pocetpismen;
            label4.Text = "Nejdlesi slovo: " + nejdelsislovo;
            


        }
    }
}
