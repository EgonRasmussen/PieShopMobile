# 3. Binding Modes & ChangeNotification

### Forsøg med Binding Modes
I MainPage sættes binding til `PieName`til `Mode=OneWay` og binding til `Price`sættes til `TwoWay`.

1. Test af Binding Mode: Prøv at ændre både Pie name og Price og tryk på knappen for at udlæse objektet. 
   Kun Price ændres pga. TwoWay. Ændre Mode for Pie Name og se at nu kan den også ændres fra UI -> Source
   
2. Klik på knappen for at forøge Price. Bemærk at prisen stiger på objektet, men det synkroniseres ikke ud på UI.


&nbsp;

### ChangeNotification
`Pie` klassen opdateres med **NotifyPropertyChange**:

```c#
public class Pie : INotifyPropertyChanged
{
    private int _id;
    private string _pieName;
    private double _price;

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

    public double Price
    {
        get => _price;
        set
        {
            _price = value;
            RaisePropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

Nu sker der en synkronisering af UI!
