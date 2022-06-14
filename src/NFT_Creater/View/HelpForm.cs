using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NFTCreater.NFT.View
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
            
        }
    }
}
