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
    public partial class ScoreboardView : UserControl
    {
        ScoreboardController _controller;
        

        public ScoreboardView(ScoreboardController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        public void updateWorpen()
        {
            lbl_worpen.Text = (int.Parse(lbl_worpen.Text) + 1).ToString();
        }

        public void updateScore() {


        }
 
    }
}
