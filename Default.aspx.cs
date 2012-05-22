using System;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
Partial;
class _Default : System.Web.UI.Page {
    
    private ResourceManager rm;
    
    protected void Page_Load(object sender, System.EventArgs e) {
//code from VB.Net to C# converted using http://www.carlosag.net/tools/codetranslator/
        CultureInfo ci;
        if (!Page.IsPostBack) {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            // get the culture info to set the language
            rm = new ResourceManager("Resources.Strings", System.Reflection.Assembly.Load("App_GlobalResources"));
            ci = Thread.CurrentThread.CurrentCulture;
            LoadStrings(ci);
        }
        else {
            // get the culture info to set the language
            rm = new ResourceManager("Resources.Strings", System.Reflection.Assembly.Load("App_GlobalResources"));
            ci = Thread.CurrentThread.CurrentCulture;
            LoadStrings(ci);
        }
    }
    
    private void LoadStrings(CultureInfo ci) {
        lbl1.Text = rm.GetString("BirdInfo", ci);
        lbl2.Text = rm.GetString("CatInfo", ci);
        lbl3.Text = rm.GetString("DogInfo", ci);
        lbl4.Text = rm.GetString("TravelInfo", ci);
        lbl5.Text = rm.GetString("WaterInfo", ci);
        lbl6.Text = rm.GetString("WeatherInfo", ci);
    }
    
    protected void ibtSpain_Click(object sender, System.Web.UI.ImageClickEventArgs e) {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
        LoadStrings(Thread.CurrentThread.CurrentCulture);
    }
    
    protected void ibtUSA_Click(object sender, System.Web.UI.ImageClickEventArgs e) {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        LoadStrings(Thread.CurrentThread.CurrentCulture);
    }
    
    protected void ibtFrance_Click(object sender, System.Web.UI.ImageClickEventArgs e) {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
        LoadStrings(Thread.CurrentThread.CurrentCulture);
    }
    
    protected void ibtGermany_Click(object sender, System.Web.UI.ImageClickEventArgs e) {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
        LoadStrings(Thread.CurrentThread.CurrentCulture);
    }
}