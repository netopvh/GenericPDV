﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericPdv
{
    public partial class Catalogo : UserControl
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void fillByIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtoTableAdapter.FillById(this.dataSetGnPdv.Produto, ((int)(System.Convert.ChangeType(idToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
