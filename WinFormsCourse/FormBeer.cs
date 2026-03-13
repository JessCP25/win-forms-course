using ApplicationBusiness;
using Entities;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FormBeer : Form
    {
        private readonly IRepositoryAdditionalData<Beer, BeerAdditionalData> _repository;
        private readonly GetBeerById<BeerAdditionalData> _getBeerById;
        private readonly IServiceProvider _serviceProvider;
        public FormBeer(IRepositoryAdditionalData<Beer, BeerAdditionalData> repository, 
            IServiceProvider serviceProvider, 
            GetBeerById<BeerAdditionalData> getBeerById)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
            _getBeerById = getBeerById;
        }

        private async Task Refresh()
        {
            var beers = await _repository.GetAllAsync();
            dgv.DataSource = beers;
        }

        private async void FormBeer_Load(object sender, EventArgs e)
        {
            await Refresh();
            AddColumn();
        }

        private void AddColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.BackColor = Color.LightGray;
            dgv.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            dgv.Columns.Add(deleteButtonColumn);
        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "EditButton")
            {
                var frm = _serviceProvider.GetRequiredService<FormNewEditBeer>();
                var beerDTO = await _getBeerById.ExecuteAsync(id);

                frm.SetBeer(beerDTO);

                frm.ShowDialog();

                await Refresh();
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var confirmResult = MessageBox.Show("¿Está seguro de eliminar la cerveza?", "Eliminar cerveza", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    await _repository.DeleteAsync(id);
                    await Refresh();
                }

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FormNewEditBeer>();
            frm.ShowDialog();

            await Refresh();
        }
    }
}
