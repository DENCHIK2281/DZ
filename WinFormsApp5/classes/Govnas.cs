using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5.classes;

namespace WinFormsApp5.classes
{
    internal class Govnas
    {
        int начальное = 0;
        int конечное = 10;
        int это_вот_это;

        public int Это_вот_это
        {
            get => это_вот_это; 
            set
            {
                if ((value > конечное) || (value < начальное))
                {
                    MessageBox.Show("Значение слишком мальнекое или большое");
                }
                else
                {
                    это_вот_это = value;
                }
            }
        }

        public void увеличить()
        {
            Это_вот_это++;


        }
        public void уменшить()
        {
            Это_вот_это--;

        }
    }

}
