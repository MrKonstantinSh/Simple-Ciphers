using System;
using System.Windows.Forms;
using Simple_ciphers.Model.Ciphers;
using Simple_ciphers.Model.Validation;
using Simple_ciphers.Controller;

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
            TypesOfCiphers typesOfCipher = TypesOfCiphers.RailFence;
            if (rbRailFence.Checked)
            {
                typesOfCipher = TypesOfCiphers.RailFence;
            }
            else if (rbRotatingSquare.Checked)
            {
                typesOfCipher = TypesOfCiphers.RotatingSquare;
            }
            else if (rbVigenerCipher.Checked)
            {
                typesOfCipher = TypesOfCiphers.Vigenere;
            }

            tbKey.Text = Validation.ModifyKey(tbKey.Text, typesOfCipher);
            rtbSrcText.Text = Validation.ModifyText(rtbSrcText.Text, typesOfCipher);

            if (cbUseDataInRcb.Checked)
            {
                rtbResText.Text = MainController.Encrypt(rtbSrcText.Text, tbKey.Text, typesOfCipher);
            }
            else
            {
                MainController.Encrypt(tbPathToSrcFile.Text, tbPathToResFile.Text,
                    tbKey.Text, typesOfCipher);
            } 
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            TypesOfCiphers typesOfCipher = TypesOfCiphers.RailFence;
            if (rbRailFence.Checked)
            {
                typesOfCipher = TypesOfCiphers.RailFence;
            }
            else if (rbRotatingSquare.Checked)
            {
                typesOfCipher = TypesOfCiphers.RotatingSquare;
            }
            else if (rbVigenerCipher.Checked)
            {
                typesOfCipher = TypesOfCiphers.Vigenere;
            }

            tbKey.Text = Validation.ModifyKey(tbKey.Text, typesOfCipher).ToString();
            rtbSrcText.Text = Validation.ModifyText(rtbSrcText.Text, typesOfCipher);

            if (cbUseDataInRcb.Checked)
            {
                rtbResText.Text = MainController.Decrypt(rtbSrcText.Text, tbKey.Text,
                    typesOfCipher);
            }
            else
            {
                MainController.Decrypt(tbPathToSrcFile.Text, tbPathToResFile.Text,
                    tbKey.Text, typesOfCipher);
            }
        }

        private void BtnChoosePathToSrcFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPathToSrcFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnChoosePathToResFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPathToResFile.Text = openFileDialog.FileName;
            }
        }

        private void RbRotatingSquare_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.ReadOnly = true;
        }

        private void RbRailFence_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.ReadOnly = false;
        }

        private void RbVigenerCipher_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.ReadOnly = false;
        }
    }
}