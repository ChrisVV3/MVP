using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using MVP.DomainModel;

namespace MVP.Views
{
    public partial class MainForm : Form, IMainView
    {
        private static int ticket = 0;
        System.Timers.Timer timer;
        private readonly ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            dgvWebsites.Columns.Add("Status", "Статус");
        }
        public List<Website> websites { get; set; }
        public int id { get; set; }

        public event Action Insert;
        public event Action Delete;
        public event Action Change;
        public event Action SetData;
        private void Reload()
        {
            SetData?.Invoke();
            dgvWebsites.DataSource = websites;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Reload();
            CreateTimer(1);
        }
        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWebsites.SelectedRows.Count > 0)
            {
                int index = dgvWebsites.SelectedRows[0].Index;
                id = int.Parse(dgvWebsites[1, index].Value.ToString());
                if (MessageBox.Show("Удалить сайт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    Delete?.Invoke();
                }
                Reload();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert?.Invoke();
            Reload();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change?.Invoke();
            Reload();
        }
        //Initialize timer
        public void CreateTimer(int seconds)
        {
            if (timer == null)
            {
                timer = new System.Timers.Timer();
                timer.Interval = seconds * 1000;
                timer.Enabled = true;
                timer.Elapsed += SetStatusTimerElapsed;
                timer.Start();
            }
        }
        // Event timer
        private void SetStatusTimerElapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            ticket = ticket == 10000 ? 1000 : ticket + 1000;
            if (dgvWebsites.Rows.Count > 0)
            {
                dgvWebsites.BeginInvoke(new MethodInvoker(SetStatus));
            }
        }
        // Assignment to a cell
        private void SetStatus()
        {
            for (int i = 0; i < dgvWebsites.RowCount; i++)
            {
                if (ticket % (int)dgvWebsites.Rows[i].Cells[4].Value == 0)
                    dgvWebsites.Rows[i].Cells[0].Value = CheckAvailable((string)dgvWebsites.Rows[i].Cells[3].Value);
            }
        }
        // Site availability
        private string CheckAvailable(string url)
        {
            Uri uri = new Uri(url);
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                httpWebRequest.Timeout = 3000;
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse()) ;
            }
            catch
            {
                return "Not Available";
            }
            return "Available";
        }
    }
}
