using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum GenreType { none, RPG, Beatemup, Action, Adventure, Shooter }

        #endregion

        #region FIELDS

        private int _id;
        private string _gameName;
        private string _medium;
        private DateTime _releaseDate;
        private GenreType _genre;
        private string _imageFileName;
        private string _description;
        private DateTime _purchaseDate;
        private double _personalRating;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string GameName
        {
            get { return _gameName; }
            set
            {
                _gameName = value;
               
            }
        }

        public string Medium
        {
            get { return _medium; }
            set
            {
                _medium = value;
               
            }
        }

        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        public GenreType Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        public double PersonalRating
        {
            get { return _personalRating; }
            set { _personalRating = value; }
        }

        public string FullName
        {
            get { return _gameName + " " + _medium; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
