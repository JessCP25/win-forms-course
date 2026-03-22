using ApplicationBusiness;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsCourse
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IRepositorySimple<Sale> _saleRepository;
        public FormMain(IServiceProvider serviceProvider, IRepositorySimple<Sale> saleRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _saleRepository = saleRepository;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            dgv.DataSource = await _saleRepository.GetAllAsync();
            dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void cervezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormBeer>();
            form.ShowDialog();
        }

        private async void btnVenta_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormNewSale>();
            form.ShowDialog();
            await Refresh();
        }
    }
}
