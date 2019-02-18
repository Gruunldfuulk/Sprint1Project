using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            //
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }
    
        private Product GetProductData()
        {
            return new Product()
            {
                Id = 0,
                GameName = "Chrono Trigger",
                Medium = "ROM Cartridge",
                ReleaseDate = DateTime.Parse("03/11/1995"),
                Genre = Product.GenreType.RPG,
                PersonalRating = 9.5,
                PurchaseDate = DateTime.Parse("12/15/1995"),
                Description =
                "Chrono Trigger is a Role Playing game from the end" +
                "\nof the SNES. Featuring multiple Timelines that" +
                "\nthe player must go through. It also makes use " +
                "\nof some of the first multiple endings, new game+," +
                "\nactive time battle, and team attacks in the RPG world.",
                ImageFileName = "snes_chrono_trigger.jpg"
            };
        }

        private Company GetCompanyData()
        {
            Company company = new Company();
            company.Name = "Retro Gaming Software, Inc";
            company.Address = "11 Front Street";
            company.City = "Traverse City";
            company.PageLabel = "Game Details";

            return company;
        }
        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
