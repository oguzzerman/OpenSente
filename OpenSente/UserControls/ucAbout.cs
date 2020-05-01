using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSente.UserControls
{
    public partial class ucAbout : UserControl
    {
        public ucAbout()
        {
            InitializeComponent();
            this.SizeChanged += UcAbout_SizeChanged;
        }

        private void UcAbout_SizeChanged(object sender, EventArgs e)
        {
            pbOSLogo.Location = new Point(this.Size.Width / 2 - 50, pbOSLogo.Location.Y);
            pbOSFull.Location = new Point(this.Size.Width / 2 - 56, pbOSFull.Location.Y);
            lblZerman.Location = new Point(this.Size.Width / 2 - 300, lblZerman.Location.Y);
            lblZermanMail.Location = new Point(this.Size.Width / 2 - 300, lblZermanMail.Location.Y);
            lblErtaymaz.Location = new Point(this.Size.Width / 2, lblErtaymaz.Location.Y);
            lblErtaymazMail.Location = new Point(this.Size.Width / 2, lblErtaymazMail.Location.Y);
        }
    }
}
