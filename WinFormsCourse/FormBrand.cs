using ApplicationBusiness;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCourse
{
    public partial class FormBrand : Form
    {
        private readonly IRepository<Brand> _repository;
        private readonly IServiceProvider _serviceProvider;

        public FormBrand(IRepository<Brand> repository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
        }

        private async Task Refresh()
        {
            var brands = await _repository.GetAllAsync();
            dgv.DataSource = brands;
        }

        private async void FormBrand_Load(object sender, EventArgs e)
        {
            await Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FormNewEditBrand>();
            frm.ShowDialog();

            await Refresh();
        }
    }
}
