using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using ApplicationBusiness.Mappers;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.AdditionalDataClass;
using Repository.Mappers;
using Repository.QueryObjects;

namespace WinFormsCourse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormMain());
            var mainForm = serviceProvider.GetRequiredService<FormMain>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:false, reloadOnChange: true)
                .Build();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DB")));

            services.AddTransient<AddBrand>();
            services.AddTransient<EditBrand>();
            services.AddTransient<CreateSale>();
            services.AddTransient<AddBeer<BeerAdditionalData>>();
            services.AddTransient<EditBeer<BeerAdditionalData>>();
            services.AddTransient<GetBeerById<BeerAdditionalData>>();
            services.AddTransient<IRepository<Brand>, BrandRepository>();
            services.AddTransient<IRepositorySimple<Sale>, SaleRepository>();
            services.AddTransient<IRepositoryAdditionalData<Beer, BeerAdditionalData>, BeerRepository>();
            services.AddTransient<IMapper<BeerDTO, Beer>, MapperToBeerEntity>();
            services.AddTransient<IMapper<SaleDTO, Sale>, MapperToSaleEntity>();
            services.AddTransient<IMapper<BeerDTO, BeerAdditionalData>, MapperToBeerAdditionalData>();
            services.AddTransient<ISuperMapper<Beer, BeerAdditionalData, BeerDTO>, SuperMapperToBeerDTO>();
            services.AddTransient<BeerWithBrandQuery>();

            services.AddTransient<FormMain>();
            services.AddTransient<FormBrand>();
            services.AddTransient<FormNewEditBrand>();
            services.AddTransient<FormBeer>();
            services.AddTransient<FormNewEditBeer>();
            services.AddTransient<FormNewSale>();
        }
    }
}