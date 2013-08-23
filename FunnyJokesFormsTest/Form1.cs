using FunnyJokesPortableClassLibrary.Contracts.Models;
using FunnyJokesPortableClassLibrary.Models;
using FunnyJokesPortableClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyJokesFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            test();
        }

        public async void test()
        {
            FunnyJokesRestDataService s = new FunnyJokesRestDataService();
           // Observ<IJoke> jokes = await s.getJokesByCategory("adu_eng", 0, 2);
        }
    }
}
