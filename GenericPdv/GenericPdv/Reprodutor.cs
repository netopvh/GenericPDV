﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericPdv
{
    public partial class Reprodutor : Form
    {
        string caminho;
        public Reprodutor(string path)
        {
            caminho = path;
            InitializeComponent(); 
        }

        private void Reprodutor_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = caminho;
        }
    }
}