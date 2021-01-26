# 3. Binding Modes & ChangeNotification

### Fors�g med Binding Modes
I MainPage s�ttes binding til `PieName`til `Mode=OneWay` og binding til `Price`s�ttes til `TwoWay`.

1. Test af Binding Mode: Pr�v at �ndre b�de Pie name og Price og tryk p� knappen for at udl�se objektet. 
   Kun Price �ndres pga. TwoWay. �ndre Mode for Pie Name og se at nu kan den ogs� �ndres fra UI -> Source
   
2. Klik p� knappen for at for�ge Price. Bem�rk at prisen stiger p� objektet, men det synkroniseres ikke ud p� UI.


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
