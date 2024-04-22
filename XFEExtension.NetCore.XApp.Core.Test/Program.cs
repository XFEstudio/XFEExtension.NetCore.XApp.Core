using XFEExtension.NetCore.StringExtension;
using XFEExtension.NetCore.XApp.Core;

internal class Program
{
    [SMTest]
    private static void MainTest()
    {
        var app = CreateXApp();
        app.X();
        var appString = app.Package();
        var unApp = XApp.UnPackage(appString);
        unApp.X();
    }
    static XApp CreateXApp()
    {
        var appInfo = new XAppInformation(string.Empty, "be98276c-48d6-451d-8a0a-a311d782d9d6", "第一个小程序", new Version(1, 0, 0), "这是第一个小程序", "XFE工作室室长", "4174240069", string.Empty, string.Empty, string.Empty, string.Empty);
        var codeFile = XAppCode.FromCode(XAppFileType.XFCS, "MainPage.cs", """"
            namespace XFEstudio;

            public partial class MainPage : ContentPage
            {
                public MainPage()
                {
                    this.LoadFromXaml("""
                        <?xml version="1.0" encoding="utf-8" ?>
                        <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                                     xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                                     x:Class="XFEstudio.MainPage"
                                     Title="我的第一个小程序">
                            <StackLayout>
                                <Label Text="这是一个小程序" FontSize="18"/>
                                <Label Text="这是一个小程序" FontSize="12"/>
                                <Label Text="这是一个小程序" FontSize="6"/>
                            </StackLayout>
                        </ContentPage>
                        """);
                }
            }
            """");
        var xApp = new XApp
        {
            AppInformation = appInfo
        };
        xApp.AppFiles.Add(codeFile);
        return xApp;
    }
}