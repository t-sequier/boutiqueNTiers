using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Webservice.WebServiceSoapClient client = new Webservice.WebServiceSoapClient();

            /*Appel WS synchrone*/
            /*Webservice.CPays[] tmp = client.lesPays();
            foreach(Webservice.CPays p in tmp)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }*/

            /*Appel WS asynchrone*/
            client.lesPaysCompleted += Client_lesPaysCompleted;
            client.lesPaysAsync();
        }

        private void Client_lesPaysCompleted(object sender, Webservice.lesPaysCompletedEventArgs e)
        {
            foreach (Webservice.CPays p in e.Result)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }
        }
    }
}
