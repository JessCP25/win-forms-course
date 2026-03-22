using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Entities;
using Repository.AdditionalDataClass;
using System.Threading.Tasks;

namespace WinFormsCourse
{
    public partial class FormNewSale : Form
    {
        private readonly IRepositoryAdditionalData<Beer, BeerAdditionalData> _beerRepository;
        private readonly CreateSale _createSale;

        public FormNewSale(IRepositoryAdditionalData<Beer, BeerAdditionalData> beerRepository, CreateSale createSale)
        {
            InitializeComponent();
            _beerRepository = beerRepository;
            _createSale = createSale;
        }

        private async Task ChargeData()
        {
            cboBeer.DataSource = await _beerRepository.GetAllAsync();
            cboBeer.DisplayMember = "Name";
            cboBeer.ValueMember = "Id";
            if (cboBeer.Items.Count > 0)
            {
                cboBeer.SelectedIndex = 0;
            }
        }

        private async void FormNewSale_Load(object sender, EventArgs e)
        {
            await ChargeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal unitPrice = ((Beer)cboBeer.SelectedItem).Price;
            int idBeer = ((Beer)cboBeer.SelectedItem).Id;
            string name = ((Beer)cboBeer.SelectedItem).Name;
            int quantity = int.Parse(txtQuantity.Value.ToString());

            dgv.Rows.Add(idBeer, quantity, name, unitPrice, unitPrice * quantity);

            txtQuantity.Value = 1;
            if (cboBeer.Items.Count > 0)
            {
                cboBeer.SelectedIndex = 0;
            }
            cboBeer.Focus();
        }

        private async void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                var saleDTO = new SaleDTO();
                saleDTO.Concepts = new List<ConceptDTO>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    var conceptDTO = new ConceptDTO()
                    {
                        IdBeer = int.Parse(row.Cells[0].Value.ToString()),
                        UnitPrice = decimal.Parse(row.Cells[3].Value.ToString()),
                        Quantity = int.Parse(row.Cells[1].Value.ToString())
                    };

                    saleDTO.Concepts.Add(conceptDTO);
                }

                await _createSale.ExecuteAsync(saleDTO);
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }

        }
    }
}