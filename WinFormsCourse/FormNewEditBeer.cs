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
    public partial class FormNewEditBeer : Form
    {
        private readonly IRepository<Brand> _brandRepository;
        public FormNewEditBeer(IRepository<Brand> brandRepository)
        {
            InitializeComponent();
            _brandRepository = brandRepository;
        }

        private async void FormNewEditBeer_Load(object sender, EventArgs e)
        {
            await ChargeData();
        }

        private async Task ChargeData()
        {
            cboMarca.DataSource = await _brandRepository.GetAllAsync();
            cboMarca.DisplayMember = "Name";
            cboMarca.ValueMember = "Id";

            if (cboMarca.Items.Count > 0) {
                cboMarca.SelectedIndex = 0;
            }
        }
    }
}
