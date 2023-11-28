using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;
using System.Xml.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Globalization;
using System.IO;

namespace LineNotificationApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var data = new[]
                {
                    new KeyValuePair<string, string>("message", "11538"),
                  //  new KeyValuePair<string, string>("stickerId", "51626495"),
                };

        var httpClient = new HttpClient();
        var url = $"https://notify-api.line.me/api/notify";
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "IHJ6nXcYDwfIcBq2xs4ssVOpqvB2QkyzS4kVN5Xid8J");
        var contentmsg = new Dictionary<string, string>();
        var asdasd = "11538";
        var asdasd2 = "51626495";
        contentmsg.Add("message", "123456");
        contentmsg.Add("stickerPackageId", asdasd);
        contentmsg.Add("stickerId", asdasd2);
        var content = new FormUrlEncodedContent(contentmsg);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        Task.Factory.StartNew(async () =>
        {
              var re= await httpClient.PostAsync("https://notify-api.line.me/api/notify", content);
            //foreach (var item in content)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        content[item.Key] = content[item.Key] + $"{i}";
            //        var re= await httpClient.PostAsync("https://notify-api.line.me/api/notify", new FormUrlEncodedContent(content)).ConfigureAwait(false);
            //        content[item.Key] = content[item.Key].Remove(content[item.Key].Length - 1);
            //    }
            //}

            //foreach (var item in content)  multipart/form-data
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        content[item.Key] = content[item.Key] + $"{i}";
            //        var re= await httpClient.PostAsync("https://notify-api.line.me/api/notify", new FormUrlEncodedContent(content));
            //        content[item.Key] = content[item.Key].Remove(content[item.Key].Length - 1);
            //    }
            //}
        });

    }
}