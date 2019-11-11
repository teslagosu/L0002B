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

namespace inl3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //instansvariabler
        string firstName;
        string lastName;
        string ssn;

        //konstruktor
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //funktion som utför något när man klickar på knappen
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //rensar allt från textrutan.
            txtBox_info.Clear();
           
            //förnamnet är från txt_firstname rutan.
            firstName = txt_firstName.Text;
            //efternamnet är från txt_lastName rutan.
            lastName = txt_lastName.Text;
            //personnummret är från txt_ssn rutan. byter ut strecket "-" mot en tom sträng
            ssn = txt_SSN.Text.Replace("-","");
            //kontrollsiffran är på index 8 och är längden är 1.
            string kontrollsiffra = ssn.Substring(8, 1);

            // ny instans av personklassen(förnamn,efternamn,personnummer)
            Person p = new Person(firstName, lastName, ssn);
            //ny instans av personcontroller klassen(Person p)
            PersonController pc = new PersonController(p);

            //anropar funktionen i personcontroller klassen
            pc.ssnIsValid(p.ssn);
            //om personnummret är giltigt
            if (pc.ssnIsValid(ssn) == true)
          
            {
                //visa i textboxen förnamn,efternamn,personnummret och skriv ut om det är en man eller kvinna.
                txtBox_info.AppendText("Förnamn: " + p.firstName + "\n");
                txtBox_info.AppendText("Efternamn: " + p.lastName + "\n");
                txtBox_info.AppendText("Personnummer: " + p.ssn + "\n");

                //kollar om det är en kvinna
                if (pc.manOrWoman(ssn) == true)

                {
                    //skriver ut att det är en kvinna
                    txtBox_info.AppendText("Kvinna");
                }
                else
                {   //annars skriver den ut att det är en man
                    txtBox_info.AppendText("Man");
                }
                
                
                
            }
            //om personnummret inte skulle vara giltigt så skriver den ut ogiltigt personnummer.
            else
            {
                txtBox_info.AppendText("ogiltigt personnummer");
            }
           

            
           
           


        }

       
    
    }
}
