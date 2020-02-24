# 3. Binding Modes & ChangeNotification
Først skal `Pie` klassen opdateres med **NotifyPropertyChange**:

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

### Forsøg med Mode
Ændre startup tilbage til MainPage. 
I MainPage sættes binding til `PieName`til `Mode=OneWay` og binding til `Price`sættes til `TwoWay`.

Desuden laves en eventhandler til Button, som sætter prisen op på CherryPie:
```c#
private void Button_Clicked(object sender, System.EventArgs e)
{
    CherryPie.Price++;
}
```

1. Test forøgelse af Price
2. Test med et breakpoint i Button-eventhandler at hvis man ændrer `Price` i Entry, opdateres det fra Destination tilbage til Source (pga. TwoWay binding).
3. Test også at hvis man ændrer `PieName` og kører til breakpoint, så er navnet ikke ændret (pga. OneWay binding).
