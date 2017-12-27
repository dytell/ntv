using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Motion
{
    public partial class UserControlControl : UserControl
    {

        private bool _readKey;

        public bool ReadKey
        {
            get
            {
                return _readKey;
            }
            set
            {
                _readKey = value;
            }
        }

        public UserControlControl()
        {
            InitializeComponent();
        }

        private void UserControlControl_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
