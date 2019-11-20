using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace AIS
{
    public partial class QRcode : Form
    {
        public string s0, s1, s2;

        public QRcode()
        {
            InitializeComponent();


        }

        private void QRcode_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Изображение(*.png)|*.png";
            sfd.FileName = s0 + " " + s1 +  " " + s2 + ".png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;
                pictureBox1.Image.Save(filename, ImageFormat.Png);
                MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }            
        }
    }
}
