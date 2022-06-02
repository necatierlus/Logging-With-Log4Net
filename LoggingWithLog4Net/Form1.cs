using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggingWithLog4Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        log4net.ILog logData;

        private void Form1_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            logData = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logData.Info("Your data has been saved successfully!");
            MessageBox.Show("Completed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            try
            {
                int number2 = 1 / number1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Completed!");
                logData.Error(ex.Message, ex);
            }
        }
    }
}
