# 3. Binding Modes & ChangeNotification
F�rst skal `Pie` klassen opdateres med **NotifyPropertyChange**:

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

### Fors�g med Mode
�ndre startup tilbage til MainPage. 
I MainPage s�ttes binding til `PieName`til `Mode=OneWay` og binding til `Price`s�ttes til `TwoWay`.

Desuden laves en eventhandler til Button, som s�tter prisen op p� CherryPie:
```c#
private void Button_Clicked(object sender, System.EventArgs e)
{
    CherryPie.Price++;
}
```

1. Test for�gelse af Price
2. Test med et breakpoint i Button-eventhandler at hvis man �ndrer `Price` i Entry, opdateres det fra Destination tilbage til Source (pga. TwoWay binding).
3. Test ogs� at hvis man �ndrer `PieName` og k�rer til breakpoint, s� er navnet ikke �ndret (pga. OneWay binding).
