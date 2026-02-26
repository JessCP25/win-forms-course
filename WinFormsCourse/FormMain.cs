using Microsoft.Extensions.DependencyInjection;

namespace WinFormsCourse
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FormMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new FormBrand();
            var form = _serviceProvider.GetRequiredService<FormBrand>();
            form.ShowDialog();
        }
    }
}
