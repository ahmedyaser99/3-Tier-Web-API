namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage resp = client.GetAsync("https://localhost:44375/api/Instructor").Result;

            if (resp.IsSuccessStatusCode)
            {
                List<Instructor> ins = resp.Content.ReadAsAsync<List<Instructor>>().Result;
                dataGridView1.DataSource = ins;

            }
        }
    }
}