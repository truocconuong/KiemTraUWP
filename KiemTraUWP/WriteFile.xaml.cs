using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace KiemTraUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WriteFile : Page
    {
        public WriteFile()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var note = this.note.Text;
            var path = DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt";
            Debug.WriteLine(path);
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = storageFolder.CreateFileAsync(path,
                Windows.Storage.CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();
             Windows.Storage.FileIO.WriteTextAsync(sampleFile,note).GetAwaiter().GetResult();
        }
    }
}
