using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Entities;
using Repository.AdditionalDataClass;
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
        private readonly AddBeer<BeerAdditionalData> _addBeer;
        private readonly EditBeer<BeerAdditionalData> _editBeer;
        private Beer _beer;
        public void SetBeer(Beer beer)
        {
            _beer = beer;
        }

        public FormNewEditBeer(IRepository<Brand> brandRepository, AddBeer<BeerAdditionalData> addBeer, EditBeer<BeerAdditionalData> editBeer)
        {
            InitializeComponent();
            _brandRepository = brandRepository;
            _addBeer = addBeer;
            _editBeer = editBeer;
        }

        private async void FormNewEditBeer_Load(object sender, EventArgs e)
        {
            await ChargeData();

            if (_beer != null) 
            {
                SetInfo();
            }
        }

        private async Task ChargeData()
        {
            cboMarca.DataSource = await _brandRepository.GetAllAsync();
            cboMarca.DisplayMember = "Name";
            cboMarca.ValueMember = "Id";

            if (cboMarca.Items.Count > 0)
            {
                cboMarca.SelectedIndex = 0;
            }
        }

        public void SetInfo()
        {
            Text = "Editar cerveza";
            txtNombre.Text = _beer.Name;
            cboMarca.SelectedValue = _beer.BrandId;
            txtAlcohol.Text = _beer.Alcohol.ToString();
        }

        private void txtAlcohol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            var textBox = (sender as TextBox);

            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(_beer == null)
                {
                    await Add();
                }
                else
                {
                    await Edit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Add()
        {
            string name = txtNombre.Text.Trim();
            int idBrand = int.Parse(cboMarca.SelectedValue.ToString());
            decimal alcohol = decimal.Parse(txtAlcohol.Text.Trim().ToString());
            string description = txtDescription.Text.Trim();

            await _addBeer.ExecuteAsync(new BeerDTO()
            {
                Name = name,
                BrandId = idBrand,
                Alcohol = alcohol,
                Description = description
            });

            this.Close();
        }

        private async Task Edit()
        {
            string name = txtNombre.Text.Trim();
            int idBrand = int.Parse(cboMarca.SelectedValue.ToString());
            decimal alcohol = decimal.Parse(txtAlcohol.Text.Trim().ToString());

            await _editBeer.ExecuteAsync(new Beer()
            {
                Id = _beer.Id,
                Name = name,
                BrandId = idBrand,
                Alcohol = alcohol,
            });

            this.Close();
        }
    }
}
