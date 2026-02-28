using ApplicationBusiness;
using Entities;
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

        public FormBrand(IRepository<Brand> repository)
        {
            InitializeComponent();
            _repository = repository;
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
    }
}
