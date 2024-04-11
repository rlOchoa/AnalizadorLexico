﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();
        }

        private void basicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Basico basic = new forms.Basico();
            basic.Show();
        }

        private void unirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Unir unir = new forms.Unir();
            unir.Show();
        }

        private void cocatenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Concatenar concatenar = new forms.Concatenar();
            concatenar.Show();
        }

        private void cerraduraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.CerraduraPos cerradurapos = new forms.CerraduraPos();
            cerradurapos.Show();
        }

        private void cerradurakleeneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            forms.CerraduraKleene cerradurakleene = new forms.CerraduraKleene();
            cerradurakleene.Show();
        }

        private void opcionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Opcional opcional = new forms.Opcional();
            opcional.Show();
        }

        private void eRAFNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ERAFN erafn = new forms.ERAFN();
            erafn.Show();
        }

        private void unionParaAnalizadorLexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.UnionALex unionALex = new forms.UnionALex();
            unionALex.Show();
        }

        private void convertirAFNAFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ConverAFNAFD converAFNAFD = new forms.ConverAFNAFD();
            converAFNAFD.Show();
        }

        private void analizarUnaCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.AnalizCadena analizarCadena = new forms.AnalizCadena();
            analizarCadena.Show();
        }

        private void probarAnalizadorLéxicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ProbarALex probarALex = new forms.ProbarALex();
            probarALex.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void aFNsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}