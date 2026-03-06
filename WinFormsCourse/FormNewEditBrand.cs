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
    public partial class FormNewEditBrand : Form
    {
        private readonly AddBrand _addBrand;
        private readonly EditBrand _editBrand;
        private int _id;
        public FormNewEditBrand(AddBrand addBrand, EditBrand editBrand)
        {
            InitializeComponent();
            _addBrand = addBrand;
            _editBrand = editBrand;
        }

        public void SetInfo(Brand brand)
        {
            _id = brand.Id;
            txtBrand.Text = brand.Name;
            Text = "Editar marca";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_id == 0) 
                {
                    await Add();
                }else
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
            string name = txtBrand.Text.Trim();
            await _addBrand.ExecuteAsync(new Brand()
            {
                Name = name,
            });

            Close();
        }

        private async Task Edit()
        {
            string name = txtBrand.Text.Trim();
            await _editBrand.ExecuteAsync(new Brand()
            {
                Id = _id,
                Name = name
            });

            Close();
        }
    }
}
