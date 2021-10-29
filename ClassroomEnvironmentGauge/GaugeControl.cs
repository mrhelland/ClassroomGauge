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

        private int imageCount = 80;
        public int ImageCount {
            get { return imageCount; }
            set {
                imageCount = value;
                UpdateImage();
            }
        }

        private static Image[] images;
        private static Image disabledImage;

        private float maxValue = 100;
        public float MaxValue {
            get { return maxValue; }
            set { 
                maxValue = value;
                this.value = Math.Min(maxValue, this.value);
                UpdateImage(); 
            }
        }

        private float minValue = 0;
        public float MinValue {
            get { return minValue; }
            set {
                minValue = value;
                this.value = Math.Max(minValue, this.value);
                UpdateImage();
            }
        }


        private int imageIndex = 0;
        private float value = 100;
        public float Value {
            get { return this.value; }
            set {
                this.value = value;
                this.value = Math.Min(maxValue, this.value);
                this.value = Math.Max(minValue, this.value);
                UpdateImage();
            }
        
        }


        public GaugeControl() {
            if(images == null) {
                LoadResources();
            }
            InitializeComponent();
            UpdateImage();
        }

        private void LoadResources() {
            images = new Image[imageCount];
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Starting now...");
            foreach(String resourceName in assembly.GetManifestResourceNames()) {
                Stream stream = assembly.GetManifestResourceStream(resourceName);
                ResourceReader reader = new ResourceReader(stream);
                foreach(DictionaryEntry entry in reader) {
                    string keyName = entry.Key.ToString();
                    if(keyName.StartsWith("_0")) {
                        int number = int.Parse(keyName.Replace("_0", "")) - 1;
                        Image img = (Image)entry.Value;
                        images[number] = img;
                    } else if(keyName.Contains("disable")) {
                        disabledImage = (Image)entry.Value;
                    }

                }
            }
        }

        private void UpdateImage() {
            if(this.Enabled) {
                float range = maxValue - minValue;
                imageIndex = (int)((this.value - minValue) / range * imageCount) - 1;
                imageIndex = Math.Max(imageIndex, 0);
                pbGauge.Image = images[imageIndex];
            } else {
                pbGauge.Image = disabledImage;
            }

        }

        public float Increment(float value = 1.0f) {
            this.value += value;
            return this.value;
        }

        public float Decrement(float value = 1.0f) {
            this.value -= value;
            return this.value;
        }
    }
}
