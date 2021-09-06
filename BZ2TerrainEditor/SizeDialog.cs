using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZ2TerrainEditor
{
	public partial class SizeDialog : Form
	{
		#region Fields

		private int selectedSize;
		private uint version;

        #endregion

        #region Properties

        public int SelectedSize
        {
            get { return this.selectedSize; }
        }

        public uint Version
        {
            get { return this.version; }
        }

        #endregion

        #region Constructors

        public SizeDialog()
		{
			this.InitializeComponent();
		}

		#endregion

		#region Methods

		private void valueSelector_ValueChanged(object sender, EventArgs e)
		{
			if (this.valueSelector.Value % valueSelector.Increment == 0)
				this.okButton.Enabled = true;
			else
				this.okButton.Enabled = false;
        }

        private void versionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            version = (uint)(5 - versionSelector.SelectedIndex);

            switch(version)
            {
                case 5:
                case 4:
                    valueSelector.Increment = 16;
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    valueSelector.Increment = 4;
                    break;
            }

            if (this.valueSelector.Value % valueSelector.Increment == 0)
                this.okButton.Enabled = true;
            else
                this.okButton.Enabled = false;
        }

        private void SizeDialog_Load(object sender, EventArgs e)
        {
            versionSelector.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
		{
			if (this.valueSelector.Value % valueSelector.Increment != 0)
				return;
			
			this.selectedSize = (int)this.valueSelector.Value;
			this.DialogResult = DialogResult.OK;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
