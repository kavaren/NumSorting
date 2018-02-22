using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static NumSortingGUI.Functions;
/// <summary>
/// To do: 
/// - backgroundworker
/// - prograssbar
/// - lokalne zmienne dla sortowań
/// - późniejsze przeniesienie funkcji sortowania do zewnętrznych bibliotek
/// - doczytanie o listach i dictionary
/// - wontki, wonteczki, wontunie - do Dawida z nimi 
/// - sprawdzić sposoby sortowania i ch ewentualne parametry
/// - wyświtlanie zbioru danych (chart)
/// - zliczanie ilości iteracji
/// - czasy sortowań
/// </summary>
namespace NumSortingGUI
{
    public partial class Form1 : Form
    {
        private static List<int> randomNumWrite;

        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            listGenNum.Items.Clear();

            randomNumWrite = GenerateNumbers(36);
            foreach (var item in randomNumWrite)
            {
                listGenNum.Items.Add(item);
            }
        }


        private void SortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
