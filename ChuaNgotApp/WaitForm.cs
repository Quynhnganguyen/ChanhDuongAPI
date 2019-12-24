using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ChuaNgotApp
{
    public class WaitForm : Form
    {
        private WaitForm loadingForm;
        private Thread loadthread;
      
        public WaitForm(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                StartPosition = FormStartPosition.Manual;
                Location = new Point(parent.Location.X + (parent.Width / 2) - Width / 2,
                                parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
        }

        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(parent);
        }
        
        public new void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new ThreadStart(loadingForm.CloseLoadingForm));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void InitializeComponent()
        {
            Name = "WaitForm";
            Text = "Please Wait...";
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Width = 240;
            Height = 50;
            Enabled = true;
        }
        private void LoadingProcessEx(object parent)
        {
            Form Cparent = parent as Form;
            loadingForm = new WaitForm(Cparent);
            loadingForm.ShowDialog();
        }

        public void CloseLoadingForm()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
