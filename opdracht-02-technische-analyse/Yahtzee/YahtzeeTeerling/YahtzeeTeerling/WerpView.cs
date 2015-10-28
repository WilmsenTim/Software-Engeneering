using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class WerpView : UserControl
    {
        WerpController _controller;

        public WerpView(WerpController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void btn_werp_alles_Click(object sender, EventArgs e)
        {
            _controller.werpAlles();
        }
    }
}
