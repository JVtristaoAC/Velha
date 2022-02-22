using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Velha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void bt1_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;

        }

        private void bt2_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;
        }

        private void bt3_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;

        }

        private void bt4_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;

        }

        private void bt5_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;

        }
        private void bt6_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;
        }

        private void bt7_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;
        }

        private void bt8_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {

                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };

            botao.IsEnabled = false;
        }

        private void bt9_Clicked(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vez == "X")
            {
                
                botao.Text = "O";
                vez = "O";

            }
            else
            {
                botao.Text = "X";
                vez = "X";
            };
            
            botao.IsEnabled = false;
        }

        private void Confirmar_Clicked(object sender, EventArgs e)
        {
             int[,][,][,] condicoesVencer = new {

               //COLUNAS
                   {{ 0, 0 }, { 1, 0 }, { 2, 0 }},
                   {{ 0, 1 }, { 1, 1 }, { 2, 1 }},
                   {{ 0, 2 }, { 1, 2 }, { 2, 2 }},

               //LINHAS
                   {{ 0, 0 }, { 0, 1 }, { 0, 2 }},
                   {{ 1, 0 }, { 1, 1 }, { 1, 2 }},
                   {{ 2, 0 }, { 2, 1 }, { 2, 2 }},

               //DIAGONAIS
                   {{ 0, 0 }, { 1, 1 }, { 2, 2 }},
                   { { 2, 0 }, { 1, 1 }, { 0, 2 } } };

            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            bt1.IsEnabled = true;
            bt2.IsEnabled = true;
            bt3.IsEnabled = true;
            bt4.IsEnabled = true;
            bt5.IsEnabled = true;
            bt6.IsEnabled = true;
            bt7.IsEnabled = true;
            bt8.IsEnabled = true;
            bt9.IsEnabled = true;
        }
    }
}
