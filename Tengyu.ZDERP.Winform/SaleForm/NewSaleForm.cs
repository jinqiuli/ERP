using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Tengyu.ZDERP.Data;

namespace Tengyu.ZDERP.Winform
{
    public partial class NewSaleForm : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 销售订单
        /// </summary>
        public SalesOrder _SalesOrder { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public User _User { get; set; }

        public NewSaleForm(User user, SalesOrder sales)
        {
            InitializeComponent();
            _SalesOrder = sales;
            _User = user;
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}