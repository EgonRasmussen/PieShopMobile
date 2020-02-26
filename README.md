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
        <Grid>
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

Desuden oprettes et objekt af Pie, som bindes til PieDetailPage og tilsidst laves en eventhandler der �bner en alert pop-up.
```c#
#region #1 BINDING SINGLE OBJECT
Pie = new Pie
{
    Id = 1,
    Description =
        "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake drag�e carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
    InStock = true,
    AvailableFromDate = new DateTime(2018, 12, 1),
    PieName = "Apple pie",
    Price = 20.95
};
this.BindingContext = Pie;
#endregion
```
Der tilf�jes nogle Styles til App.xaml og billedet patternwide.png kopiereres til Android og iOS projekterne.

I App.xaml.cs s�ttes startupPage til PieDetailPage.

S�t et breakpoint i eventhandleren, pr�v at �ndre nogle properties og unders�g om �ndringerne er blevet overf�rt til Pie-objektet.

---

### #2 Binding to Properties
For at kunne demonstrere Binding via Properties, skal der tilf�jes et ekstra niveau i klasse-hierakiet.
Opret klassen PieDetailViewModel:
```c#
public class PieDetailViewModel
{
    public Pie Pie { get; set; }
    public string UserName { get; set; }
}
```

Nu skal Pie-objektet flyttes ind i PieDetailViewModel-objektet, s�ledes at der opst�r et ekstra niveau i bindingen:
```c#
#region #2 BINDING TO PROPERTIES
PieDetailViewModel = new PieDetailViewModel()
{
    Pie = new Pie
    {
        Id = 1,
        Description =
            "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake drag�e carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
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

Nu er det n�dvendigt at navigere igennem to ekstra properties i alle bindings:
```xml
<!--#2 Binding to Properties-->
<ScrollView>
    <Grid>
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

### #3 Using an indexer
For at demonstrere brugen af indexer i binding, skal vi have en List af Pies:
```c#
#region #3 BINDING TO COLLECTION
Pies = new List<Pie>
{
    new Pie
    {
        PieName = "Apple Pie",
        Price = 12.95,
        Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
        AvailableFromDate = new DateTime(2018, 12, 1),
        InStock = true,
    },
    new Pie
    {
        PieName = "Strawberry Cheese Cake", Price = 18.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
        AvailableFromDate = new DateTime(2018, 12, 1),
        InStock = false,
    },
    new Pie
    {
        PieName = "Strawberry Pie", Price = 15.95,
        Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
        InStock = true,
    },
    new Pie
    {
        PieName = "Rhubarb Pie", Price = 15.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
        InStock = true,
    },
    new Pie
    {
        PieName = "Blueberry Cheese Cake", Price = 18.95,
        Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
        InStock = true,
    },
    new Pie
    {
        PieName = "Cheese Cake", Price = 18.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
        InStock = true,
    },
    new Pie
    {
        PieName = "Cherry Pie", Price = 15.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
        InStock = true,
    },
    new Pie
    {
        PieName = "Christmas Apple Pie", Price = 13.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
        InStock = true
    },
    new Pie
    {
        PieName = "Cranberry Pie", Price = 17.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
        InStock = true
    },
    new Pie
    {
        PieName = "Peach Pie", Price = 15.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
        InStock = false,
    },
    new Pie
    {
        PieName = "Pumpkin Pie", Price = 12.95, Description =
            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie drag�e brownie. Lollipop cotton candy cake bear claw oat cake. Drag�e candy canes dessert tart. Marzipan drag�e gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake drag�e croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake drag�e gummies.",
        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
        InStock = true,
    }
};

this.BindingContext = Pies;
#endregion
```

Alle bindings skal nu �ndres, hvilket her s�ttes til element [0] i listen:
```xml
