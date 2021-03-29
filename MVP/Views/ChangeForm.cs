using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class ChangeForm : Form, IChangeView
    {
        public ChangeForm()
        {
            InitializeComponent();
        }
        public int id { get => int.Parse(txtID.Text); }
        public string site { get => txtSite.Text; }
        public string url { get => txtURL.Text; }
        public int gap { get
            {
                if(!string.IsNullOrEmpty(txtGap.Text))
                    return int.Parse(txtGap.Text);
                return 0;
            }
        }

        public event Action Change;
        public new void Show()
        {
            ShowDialog();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Change?.Invoke();
        }
    }
}
