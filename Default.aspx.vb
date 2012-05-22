Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Resources
Imports System.Reflection



Partial Class _Default
    Inherits System.Web.UI.Page

    Private rm As ResourceManager

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ci As CultureInfo

        If Not Page.IsPostBack Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            'get the culture info to set the language
            rm = New ResourceManager("Resources.Strings", System.Reflection.Assembly.Load("App_GlobalResources"))
            ci = Thread.CurrentThread.CurrentCulture
            LoadStrings(ci)
        Else
            'get the culture info to set the language
            rm = New ResourceManager("Resources.Strings", System.Reflection.Assembly.Load("App_GlobalResources"))
            ci = Thread.CurrentThread.CurrentCulture
            LoadStrings(ci)
        End If

    End Sub

    Private Sub LoadStrings(ByVal ci As CultureInfo)

        lbl1.Text = rm.GetString("BirdInfo", ci)
        lbl2.Text = rm.GetString("CatInfo", ci)
        lbl3.Text = rm.GetString("DogInfo", ci)
        lbl4.Text = rm.GetString("TravelInfo", ci)
        lbl5.Text = rm.GetString("WaterInfo", ci)
        lbl6.Text = rm.GetString("WeatherInfo", ci)

    End Sub


    Protected Sub ibtSpain_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtSpain.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
        LoadStrings(Thread.CurrentThread.CurrentCulture)
    End Sub


    Protected Sub ibtUSA_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtUSA.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        LoadStrings(Thread.CurrentThread.CurrentCulture)
    End Sub


    Protected Sub ibtFrance_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtFrance.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
        LoadStrings(Thread.CurrentThread.CurrentCulture)
    End Sub


    Protected Sub ibtGermany_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtGermany.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("de-DE")
        LoadStrings(Thread.CurrentThread.CurrentCulture)
    End Sub
End Class


