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
    }
}