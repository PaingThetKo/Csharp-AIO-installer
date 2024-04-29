using System.Diagnostics;
using System.IO;


namespace AIO_installer
{
    public partial class frmAIO : Form
    {
        public frmAIO()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            string path = Directory.GetCurrentDirectory();

            try
            {
                if (File.Exists(path + @"\softwares\Steam\SteamSetup.exe"))
                {
                    Process.Start(path + @"\softwares\Steam\SteamSetup.exe");
                }
                else
                {
                    MessageBox.Show("Please Check your file.", "File Not Found!");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = this.cbobits.GetItemText(this.cbobits.SelectedItem);

            string path = Directory.GetCurrentDirectory();

            if (item == "32 Bits") 
            {
                try
                {
                    if (File.Exists(path + @"\softwares\Extreme Copy\32 Bits\ExtremeCopy-2.1.0-std-32bits.msi"))
                    {
                        Process.Start(path + @"\softwares\Extreme Copy\32 Bits\ExtremeCopy-2.1.0-std-32bits.msi");
                    }
                    else
                    {
                        MessageBox.Show("Please Check your file.", "File Not Found!");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

            else if(item == "64 Bits")
            {
                try
                {
                    if (File.Exists(path + @"\softwares\Extreme Copy\64 Bits\ExtremeCopy-2.1.0-std-64bits.msi"))
                    {
                        Process.Start(path + @"\softwares\Extreme Copy\64 Bits\ExtremeCopy-2.1.0-std-64bits.msi");
                    }
                    else
                    {
                        MessageBox.Show("Please Check your file.", "File Not Found!");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();

            try
            {
                if (File.Exists(path + @"\software\ExtremeCopy-2.1.0-std-32bits.exe"))
                {
                    Process.Start(path + @"\software\ExtremeCopy-2.1.0-std-32bits.exe");
                }
                else
                {
                    MessageBox.Show("Please Check your file.", "File Not Found!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    

    }
}
