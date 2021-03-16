using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juste_prix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int randomed;
        int nbEssais;
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            int pickedNum = PickANumber();

            if (pickedNum > 0)
            {
                if (pickedNum != randomed)
                {
                    pickedNum = TryAgain(pickedNum);
                }
                else
                {
                    YouWin();
                }
            }
        }

        private void BtnNllePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

         void YouWin()
        {
            textBlockInfo.Text = "Bravo! Tu as gagné";
        }

         int PickANumber()
        {
            string picked = textBoxEssai.Text;

                int pickedNum;
                bool isNumeric = int.TryParse(picked, out pickedNum);
            if ( isNumeric == false)
            {
                textBlockInfo.Text = "Oups, ce n'est pas un nombre....essaye encore une fois :)";
            }
            else
            {
                textBlockInfo.Text = string.Empty;
            }

            return pickedNum;
        }

        void NouvellePartie()
        {
            randomed = GenererNombreAleatoire();
            textBlockInfo.Text = string.Empty;
            textBoxEssai.Text = string.Empty;
            nbEssais = 0;

            UpdateTry();
        }
        void UpdateTry()
        {
            textBlockNbEssais.Text = "Nb d'essais: " + nbEssais;
        }

        int GenererNombreAleatoire()
        {
            return new Random().Next(0, 50);
        }

        int TryAgain(int pickedNum)
        {
            if (pickedNum > randomed)
            {
                textBlockInfo.Text = "C'est moins";
            }
            else
            {
                textBlockInfo.Text = "C'est plus";
            }
            nbEssais = nbEssais + 1;
            UpdateTry();

            return pickedNum;
        }
    }

}
