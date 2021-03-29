using System;
using System.Windows.Forms;
using MVP.DomainModel;

namespace MVP.Views
{
    public partial class AddForm : Form, IAddView
    {
        public AddForm()
        {
            InitializeComponent();
        }
        public Website website 
            { get =>
                new Website() { Site = txtSite.Text, URL = txtURL.Text, Gap = int.Parse(txtGap.Text) };
             }

        public event Action Add;
        public new void Show()
        {
            ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            Add?.Invoke();
        }
    }
}
