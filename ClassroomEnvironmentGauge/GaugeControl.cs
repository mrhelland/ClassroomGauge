using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Reflection;
using System.IO;

namespace ClassroomEnvironmentGauge {
    public partial class GaugeControl : UserControl {

        public const int IMAGE_COUNT = 80;
        public Image[] images;


        public GaugeControl() {
            if(images == null) {
                images = new Image[IMAGE_COUNT];
                Assembly assembly = Assembly.GetExecutingAssembly();
                Console.WriteLine("Starting now...");
                foreach(String resourceName in assembly.GetManifestResourceNames()) {
                    Stream stream = assembly.GetManifestResourceStream(resourceName);
                    ResourceReader reader = new ResourceReader(stream);
                    foreach(DictionaryEntry entry in reader) {
                        Console.WriteLine("key = {0}", entry.Key);
                        Console.WriteLine("value = {0}", entry.Value.ToString());
                        int number = int.Parse(entry.Key.ToString().Replace("_0", "")) - 1;
                        Image img = (Image)entry.Value;
                        images[number] = img;
                    }
                }
            }
            InitializeComponent();
            
        }
    }
}
