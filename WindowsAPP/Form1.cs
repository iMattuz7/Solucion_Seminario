
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAPP
{
    public partial class Form1 : Form

    {
        //private readonly IProductService _productService;
       // private ProductService _productService;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("matias.almiron", "1307imattuz");

            MailMessage mm = new MailMessage("matias.almiron@gmail.com", "matias.almiron@gmail.com", "test", "test");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_productService = new ProductService();
            //var products = _productService.GetAllProductsDisplayedOnHomePage();
            //listView1.da
        }
    }
}
