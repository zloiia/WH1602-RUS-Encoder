using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WH1602_RUS_Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void original_TextChanged(object sender, EventArgs e)
        {
            String translated = "";
            foreach(char c in original.Text)
            {
                char toInsert = c;
                switch(c)
                {
                    case 'Б': toInsert = '\xA0'; break;
                    case 'Г': toInsert = '\xA1'; break;
                    case 'Ё': toInsert = '\xA2'; break;
                    case 'Ж': toInsert = '\xA3'; break;
                    case 'З': toInsert = '\xA4'; break;
                    case 'И': toInsert = '\xA5'; break;
                    case 'Й': toInsert = '\xA6'; break;
                    case 'Л': toInsert = '\xA7'; break;
                    case 'П': toInsert = '\xA8'; break;
                    case 'У': toInsert = '\xA9'; break;
                    case 'Ф': toInsert = '\xAA'; break;
                    case 'Ч': toInsert = '\xAB'; break;
                    case 'Ш': toInsert = '\xAC'; break;
                    case 'Ъ': toInsert = '\xAD'; break;
                    case 'Ы': toInsert = '\xAE'; break;
                    case 'Э': toInsert = '\xAF'; break;

                    case 'Ю': toInsert = '\xB0'; break;
                    case 'Я': toInsert = '\xB1'; break;
                    case 'б': toInsert = '\xB2'; break;
                    case 'в': toInsert = '\xB3'; break;
                    case 'г': toInsert = '\xB4'; break;
                    case 'ё': toInsert = '\xB5'; break;
                    case 'ж': toInsert = '\xB6'; break;
                    case 'з': toInsert = '\xB7'; break;
                    case 'и': toInsert = '\xB8'; break;
                    case 'й': toInsert = '\xB9'; break;
                    case 'к': toInsert = '\xBA'; break;
                    case 'л': toInsert = '\xBB'; break;
                    case 'м': toInsert = '\xBC'; break;
                    case 'н': toInsert = '\xBD'; break;
                    case 'п': toInsert = '\xBE'; break;
                    case 'т': toInsert = '\xBF'; break;

                    case 'ч': toInsert = '\xC0'; break;
                    case 'ш': toInsert = '\xC1'; break;
                    case 'ъ': toInsert = '\xC2'; break;
                    case 'ы': toInsert = '\xC3'; break;
                    case 'ь': toInsert = '\xC4'; break;
                    case 'э': toInsert = '\xC5'; break;
                    case 'ю': toInsert = '\xC6'; break;
                    case 'я': toInsert = '\xC7'; break;

                    case 'Х': toInsert = '\xD5'; break;

                    case 'Д': toInsert = '\xE0'; break;
                    case 'Ц': toInsert = '\xE1'; break;
                    case 'Щ': toInsert = '\xE2'; break;
                    case 'д': toInsert = '\xE3'; break;
                    case 'ф': toInsert = '\xE4'; break;
                    case 'ц': toInsert = '\xE5'; break;
                    case 'щ': toInsert = '\xE6'; break;

                    case 'р': toInsert = 'p'; break;
                    case 'А': toInsert = 'A'; break;
                    case 'В': toInsert = 'B'; break;
                    case 'е': toInsert = 'e'; break;
                    case 'у': toInsert = 'y'; break;
                    case 'х': toInsert = 'x'; break;
                    case 'а': toInsert = 'a'; break;
                    case 'о': toInsert = 'o'; break;
                    case 'с': toInsert = 'c'; break;
                }

                translated += String.Format("\\x{0:X2}", Convert.ToInt32(toInsert));
            }
            trans.Text = translated;
        }
    }
}
