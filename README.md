# 4. Binding to a Single Object

### Oprettelse af Detail Screen

Vi begynder med en ny og udvidet udgave af Pie-klassen:
```c#
public class Pie : INotifyPropertyChanged
{
    private int _id;
    private string _pieName;
    private string _description;
    private double _price;
    private string _imageUrl;
    private bool _inStock;
    private DateTime _availableFromDate;

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

    public double Price
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

    public DateTime AvailableFromDate
    {
        get => _availableFromDate;
        set
        {
            _availableFromDate = value; 
            RaisePropertyChanged();
        }
    }

    public List<string> Ingredients { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

&nbsp;

### #1 Opret Detail Page
Opret en ny ContentPage kaldet **PieDetailPage**:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             x:Class="BethanysPieShopStockApp.PieDetailPage"
             Padding="5"
             BackgroundImage="patternwide.png">

    <ScrollView>
        <Grid Padding="10">
            <Grid.RowDefinitions>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="150"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="200"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="*"></RowDefinition>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width=".4*"></ColumnDefinition>
                <ColumnDefinition Width=".6*"></ColumnDefinition>
            </Grid.ColumnDefinitions>
            <Label x:Name="TitleLabel" 
               Text="Edit pie"
               Grid.Row="0" 
               Grid.Column="0" 
               Grid.ColumnSpan="2" 
               Style="{StaticResource TitleLabelStyle}"></Label>
            <Image x:Name="PieImage" 
               Grid.Column="0"
               Grid.Row="1" 
               Grid.ColumnSpan="2"
               Source="{Binding ImageUrl}"
               Margin="10" 
               WidthRequest="200" 
               HeightRequest="200" 
               HorizontalOptions="Center" 
               VerticalOptions="Center"></Image>
            <Label Text="Pie name" 
               Grid.Row="2" 
               Grid.Column="0"
               Style="{StaticResource SmallLabelStyle}"></Label>
            <Entry Grid.Row="2"
               Grid.Column="1"
               Text="{Binding PieName, Mode=TwoWay}" 
               Style="{StaticResource RegularEntry}"></Entry>
            <Label Text="Price" 
               Grid.Row="3" 
               Grid.Column="0"
               Style="{StaticResource SmallLabelStyle}"></Label>
            <Entry Grid.Row="3"
               Grid.Column="1"
               Text="{Binding Price, Mode=TwoWay}" 
               Style="{StaticResource RegularEntry}"></Entry>
            <Label Text="Description" 
               Grid.Row="4" 
               Grid.Column="0"
               Style="{StaticResource SmallLabelStyle}"></Label>
            <Editor Grid.Row="4"
               Grid.Column="1"
               Text="{Binding Description, Mode=TwoWay}" 
               Style="{StaticResource RegularEditorStyle}"></Editor>
            <Label Text="In stock?" 
               Grid.Row="5" 
               Grid.Column="0"
               Style="{StaticResource SmallLabelStyle}"></Label>
            <Switch Grid.Row="5"
               Grid.Column="1"
               IsToggled="{Binding InStock, Mode=TwoWay}"></Switch>
            <Label Text="Available date" 
               Grid.Row="6" 
               Grid.Column="0"
               Style="{StaticResource SmallLabelStyle}"></Label>
            <DatePicker Grid.Row="6"
                Grid.Column="1"
                Date="{Binding AvailableFromDate, Mode=TwoWay}"></DatePicker>
            <Button x:Name="SavePieButton" 
                Clicked="SavePieButton_OnClicked" 
                Text="Save Pie" 
                Style="{StaticResource RegularButtonStyle}" 
                Grid.Row="7" 
                Grid.Column="0"
                Grid.ColumnSpan="2"></Button>
        </Grid>
    </ScrollView>
</ContentPage>
```

Desuden oprettes et objekt af Pie, som bindes til PieDetailPage og tilsidst laves en eventhandler der åbner en alert pop-up.
```c#
#region #1 BINDING SINGLE OBJECT
Pie = new Pie
{
    Id = 1,
    Description =
        "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
    InStock = true,
    AvailableFromDate = new DateTime(2018, 12, 1),
    PieName = "Apple pie",
    Price = 20.95
};
this.BindingContext = Pie;
#endregion
```
Der tilføjes nogle Styles til App.xaml og billedet patternwide.png kopiereres til Android og iOS projekterne.

I App.xaml.cs sættes startupPage til PieDetailPage.

Sæt et breakpoint i eventhandleren, prøv at ændre nogle properties og undersøg om ændringerne er blevet overført til Pie-objektet.

&nbsp;

### #2 Binding to Properties
For at kunne demonstrere Binding via Properties, skal der tilføjes et ekstra niveau i klasse-hierakiet.
Opret klassen PieDetailViewModel:
```c#
public class PieDetailViewModel
{
    public Pie Pie { get; set; }
    public string UserName { get; set; }
}
```

Nu skal Pie-objektet flyttes ind i PieDetailViewModel-objektet, således at der opstår et ekstra niveau i bindingen:
```c#
#region #2 BINDING TO PROPERTIES
PieDetailViewModel = new PieDetailViewModel()
{
    Pie = new Pie
    {
        Id = 1,
        Description =
            "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
        InStock = true,
        AvailableFromDate = new DateTime(2018, 12, 1),
        PieName = "Apple pie",
        Price = 20.95
    },
    UserName = "Bethany"
};
this.BindingContext = this;
#endregion
```

Nu er det nødvendigt at navigere igennem to ekstra properties i alle bindings:
```xml
<!--#2 Binding to Properties-->
<ScrollView>
    <Grid Padding="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="150"></RowDefinition>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="200"></RowDefinition>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="50"></RowDefinition>
            <RowDefinition Height="*"></RowDefinition>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width=".4*"></ColumnDefinition>
            <ColumnDefinition Width=".6*"></ColumnDefinition>
        </Grid.ColumnDefinitions>
        <Label x:Name="TitleLabel" 
            Text="Edit pie"
            Grid.Row="0" 
            Grid.Column="0" 
            Grid.ColumnSpan="2" 
            Style="{StaticResource TitleLabelStyle}"></Label>
        <Image x:Name="PieImage" 
            Grid.Column="0"
            Grid.Row="1" 
            Grid.ColumnSpan="2"
            Source="{Binding PieDetailViewModel.Pie.ImageUrl}"
            Margin="10" 
            WidthRequest="200" 
            HeightRequest="200" 
            HorizontalOptions="Center" 
            VerticalOptions="Center"></Image>
        <Label Text="Pie name" 
            Grid.Row="2" 
            Grid.Column="0"
            Style="{StaticResource SmallLabelStyle}"></Label>
        <Entry Grid.Row="2"
            Grid.Column="1"
            Text="{Binding PieDetailViewModel.Pie.PieName, Mode=TwoWay}" 
            Style="{StaticResource RegularEntry}"></Entry>
        <Label Text="Price" 
            Grid.Row="3" 
            Grid.Column="0"
            Style="{StaticResource SmallLabelStyle}"></Label>
        <Entry Grid.Row="3"
            Grid.Column="1"
            Text="{Binding PieDetailViewModel.Pie.Price, Mode=TwoWay}" 
            Style="{StaticResource RegularEntry}"></Entry>
        <Label Text="Description" 
            Grid.Row="4" 
            Grid.Column="0"
            Style="{StaticResource SmallLabelStyle}"></Label>
        <Editor Grid.Row="4"
            Grid.Column="1"
            Text="{Binding PieDetailViewModel.Pie.Description, Mode=TwoWay}" 
            Style="{StaticResource RegularEditorStyle}"></Editor>
        <Label Text="In stock?" 
            Grid.Row="5" 
            Grid.Column="0"
            Style="{StaticResource SmallLabelStyle}"></Label>
        <Switch Grid.Row="5"
            Grid.Column="1"
            IsToggled="{Binding PieDetailViewModel.Pie.InStock, Mode=TwoWay}"></Switch>
        <Label Text="Available date" 
            Grid.Row="6" 
            Grid.Column="0"
            Style="{StaticResource SmallLabelStyle}"></Label>
        <DatePicker Grid.Row="6"
            Grid.Column="1"
            Date="{Binding PieDetailViewModel.Pie.AvailableFromDate, Mode=TwoWay}"></DatePicker>
        <Button x:Name="SavePieButton" 
            Clicked="SavePieButton_OnClicked" 
            Text="Save Pie" 
            Style="{StaticResource RegularButtonStyle}" 
            Grid.Row="7" 
            Grid.Column="0"
            Grid.ColumnSpan="2"></Button>
    </Grid>
</ScrollView>
```

---

