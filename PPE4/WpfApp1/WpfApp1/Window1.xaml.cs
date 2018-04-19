using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class questionnaire_un : Window
    {
        public questionnaire_un()
        {
            InitializeComponent();
        }

        private void BtnOui_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-J7KG7T8\SQLEXPRESS; Initial catalog=Formulaire; Integrated Security=True;");
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO reponse FROM Reponse VALUES ('" + BtnOui.Content + "')");
            sqlCommand.ExecuteNonQuery();
        
        }

        private void BtnNon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSansObjet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNecessiteCorrection_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
