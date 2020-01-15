using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BethanysPieShopMobile.Model
{
    public class Pie : INotifyPropertyChanged
    {
        private int _id;
        private string _pieName;
        private string _description;
        private decimal _price;
        private string _imageUrl;
        private bool _inStock;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged();
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged();
            }
        }

        public bool InStock
        {
            get => _inStock;
            set
            {
                _inStock = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
