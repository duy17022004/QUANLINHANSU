using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIENNET
{
    public partial class frmmain : Form
    {
        private string loaitk;
        private frmchucvu frmnhanvien;

        public frmmain(string loaitk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchucvu frmchucvu = new frmchucvu();
            frmchucvu.Show();
            this.Hide();    
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            if(loaitk == "ADMIN")
            {
                mnudanhmuc.Enabled = true;
                mnuqlhs.Enabled = true; 
                mnuqtht.Enabled = true; 
            }
            if(loaitk =="EMPLOYEE")
            {
                mnudanhmuc.Enabled = false;
                mnuqlhs.Enabled = true;
                mnuqtht.Enabled=false;
                
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien f = new frmnhanvien();
            f.Show();
            this.Hide();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taikhoan f = new taikhoan();
            f.Show();
            this.Hide();
        }
    }
}
