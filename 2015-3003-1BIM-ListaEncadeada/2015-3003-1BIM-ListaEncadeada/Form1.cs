﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();
        }
        private void AdicionarPoX(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Inserir(int.Parse(textBox6.Text), elemento);

        }

      

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void ExibirLista(object sender, EventArgs e)
        {

            lista.ImprimeLista();
         
    
        }
        private void RemoveToValue(object sender, EventArgs e)
        {
            lista.RemoveValue(int.Parse(textBox2.Text));
        }

        private void RemoveToPosition(object sender, EventArgs e)
        {
            lista.Remove(int.Parse(textBox1.Text));
        }
        private void TrocarPos(object sender, EventArgs e)
        {
            lista.TrocarPosition(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
        private void AdicionarAposValor(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.AdicionarAposValor(int.Parse(textBox5.Text), elemento);
        }

        
    }
}
