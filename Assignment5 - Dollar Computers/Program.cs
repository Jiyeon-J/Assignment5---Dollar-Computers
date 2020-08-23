using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5___Dollar_Computers
{
    /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 20, 2020
      Program description: Dollar Computers
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */
    static class Program
    {
        public static Product product;
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutBoxForm aboutBoxForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            product = new Product();
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutBoxForm = new AboutBoxForm();


            Application.Run(new SplashForm());
        }
    }
}
