using ApplicationBusiness;
using Entities;
using Repository.AdditionalDataClass;

namespace WinFormsCourse
{
    public partial class FormNewSale : Form
    {
        private readonly IRepositoryAdditionalData<Beer, BeerAdditionalData> _beerRepository;

        public FormNewSale(IRepositoryAdditionalData<Beer, BeerAdditionalData> beerRepository)
        {
            InitializeComponent();
            _beerRepository = beerRepository;
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
            if(cboBeer.Items.Count > 0)
            {
                cboBeer.SelectedIndex = 0;
            }
            cboBeer.Focus();
        }
    }
}