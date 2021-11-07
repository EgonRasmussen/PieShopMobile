using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BethanysPieShopMobile.Model
{
    public class Pie
    {
        public int Id { get; set; }

        public string PieName { get; set; }

        public double Price { get; set; }
    }

    //public class Pie : INotifyPropertyChanged
    //{
    //    private int _id;
    //    private string _pieName;
    //    private double _price;

    //    public int Id
    //    {
    //        get => _id;
    //        set
    //        {
    //            _id = value;
    //            RaisePropertyChanged();
    //        }
    //    }

    //    public string PieName
    //    {
    //        get => _pieName;
    //        set
    //        {
    //            _pieName = value;
    //           RaisePropertyChanged();
    //        }
    //    }

    //    public double Price
    //    {
    //        get => _price;
    //        set
    //        {
    //            _price = value;
    //            RaisePropertyChanged();
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}
}
