using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.Helper;

namespace OpenSente.UserControls
{
    public partial class HighlightFancyButton : UserControl
    {
        #region Ctor

        public HighlightFancyButton()
        {
            InitializeComponent();
            lblText.Text = Text;
            lblText.MouseEnter += HighlightFancyButton_MouseEnter;
            lblText.MouseLeave += HighlightFancyButton_MouseLeave;
            if (!this.Enabled)
            {
                this.BackColor = Color.Gray;
            }
        }


        #endregion

        #region Private Fields

        private Object _Obj;
        private eObjectType _ObjectType;

        #endregion

        #region Public Fields

        public float FontSize
        {
            get { return this.lblText.Font.Size; }
            set { this.lblText.Font = new Font("Microsoft Sans Serif",value); }
        }

        public string LabelText 
        {
            get { return this.lblText.Text; } 
            set { this.lblText.Text = value; }
        }

        public Object Obj
        {
            get { return _Obj; }
            set { _Obj = value; }
        }

        public eObjectType ObjectType
        {
            get { return _ObjectType; }
            set { _ObjectType = value; }
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion

        #region Events

        private void HighlightFancyButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void HighlightFancyButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        #endregion
    }
}
