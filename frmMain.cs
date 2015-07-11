using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QualTipoMime
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String arquivo;

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            arquivo = openFileDialog1.FileName;

            FileInfo arq = new FileInfo(openFileDialog1.FileName);

            if (arquivo.Length > 0)
            {
                textBox1.Text = GetMimeType(arquivo);
                lblTamanho.Text = arq.Length.ToString() + " bytes";
                lblTamanho2.Text = (arq.Length / 1024).ToString() + " kylobytes";
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia o form de About
            frmAbout frmAbout = new frmAbout();

            //Mostra a tela como MODAL
            frmAbout.ShowDialog();
        }
    }
}
