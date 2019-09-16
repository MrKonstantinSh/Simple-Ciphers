using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_ciphers
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            tbKey.Text = Model.Validation.Validation.ModifyKey(tbKey.Text).ToString();
            rtbSrcText.Text = Model.Validation.Validation.ModifyText(rtbSrcText.Text);

            Model.Ciphers.TypesOfCiphers typesOfCipher = Model.Ciphers.TypesOfCiphers.RailFence;
            if (rbRailFence.Checked)
                typesOfCipher = Model.Ciphers.TypesOfCiphers.RailFence;
            else if (rbRotatingSquare.Checked)
                typesOfCipher = Model.Ciphers.TypesOfCiphers.RotatingSquare;


            if (cbUseDataInRcb.Checked)
                rtbResText.Text = Controller.Controller.Encrypt(rtbSrcText.Text, tbKey.Text, typesOfCipher);
            else
                Controller.Controller.Encrypt(tbPathToSrcFile.Text, tbPathToResFile.Text,
                    tbKey.Text, typesOfCipher);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            tbKey.Text = Model.Validation.Validation.ModifyKey(tbKey.Text).ToString();
            rtbSrcText.Text = Model.Validation.Validation.ModifyText(rtbSrcText.Text);


            Model.Ciphers.TypesOfCiphers typesOfCipher = Model.Ciphers.TypesOfCiphers.RailFence;
            if (rbRailFence.Checked)
                typesOfCipher = Model.Ciphers.TypesOfCiphers.RailFence;
            else if (rbRotatingSquare.Checked)
                typesOfCipher = Model.Ciphers.TypesOfCiphers.RotatingSquare;


            if (cbUseDataInRcb.Checked)
                rtbResText.Text = Controller.Controller.Decrypt(rtbSrcText.Text, tbKey.Text,
                    typesOfCipher);
            else
                Controller.Controller.Decrypt(tbPathToSrcFile.Text, tbPathToResFile.Text,
                    tbKey.Text, typesOfCipher);
        }

        private void BtnChoosePathToSrcFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tbPathToSrcFile.Text = openFileDialog.FileName;
        }

        private void BtnChoosePathToResFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tbPathToResFile.Text = openFileDialog.FileName;
        }
    }
}