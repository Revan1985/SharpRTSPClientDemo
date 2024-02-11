namespace SharpRTSPClientDemo
{
    public partial class Form1 : Form
    {
        Rtsp.Authentication? _authentication;
        Rtsp.IRtspTransport? _transport;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            string ip = TextBoxIP.Text;
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            if (string.IsNullOrEmpty(ip))
            {
                TextBoxIP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                TextBoxUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                TextBoxPassword.Focus();
                return;
            }

        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {

        }

    }
}
