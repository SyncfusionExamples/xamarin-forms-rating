# Xamarin Rating (SfRating) 

This section explains how to configure a SfRating control in a real-time scenario and also provides a walk-through on some of the customization features available in SfRating control.

For know more details about Rating: https://www.syncfusion.com/xamarin-ui-controls/xamarin-rating

Rating user guide documentation: https://help.syncfusion.com/xamarin/rating/getting-started

## Assembly deployment
After installing Essential Studio for Xamarin, you can find all the required assemblies in the installation folders, {Syncfusion Essential Studio Installed location} \Essential Studio\{Version #}\Xamarin\lib.

## Adding SfRating reference
You can add SfRating reference using one of the following methods:

### Method 1: Adding SfRating reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfRating to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.SfRating, and then install it.

### Method 2: Adding SfRating reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfRating control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

### Method 3: Adding SfRating assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

Location: {Installed location}/{version}/Xamarin/lib
## Adding namespace
Add the following namespace.

**[XAML]**

```
<xmlns:rating="clr-namespace:Syncfusion.SfRating.XForms;assembly=Syncfusion.SfRating.XForms"/>

```

**[C#]**

```
using Syncfusion.SfRating.XForms;
```
## Initialize Rating
Now, add the SfRating control with a required optimal name using the included namespace.

**[XAML]**

```
<rating:SfRating x:Name="rating" />
```

**[C#]**

```
SfRating rating;
public MainPage()
{
    InitializeComponent();
    rating = new SfRating();
    this.Content = rating;
}

```
## How to run this application?

To run this application, you need to first clone the xamarin-forms-rating repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.