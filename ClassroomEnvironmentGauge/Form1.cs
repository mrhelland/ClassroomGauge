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
    public partial class MainForm : Form {

        private WeeklySummaryCollection summaryCollection;


        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Starting now...");
            foreach(String resourceName in assembly.GetManifestResourceNames()) {
                Stream stream = assembly.GetManifestResourceStream(resourceName);
                ResourceReader reader = new ResourceReader(stream);
                foreach(DictionaryEntry entry in reader) {
                    Console.WriteLine("key = {0}", entry.Key);
                    Console.WriteLine("value = {0}", entry.Value.ToString());
                }
            }

            //ResourceManager manager = Properties.Resources.ResourceManager;
            //ResourceSet set = manager.GetResourceSet(CultureInfo.CurrentCulture, true, false);
            //foreach(DictionaryEntry entry in set) {
            //    Console.WriteLine("key = {0}", entry.Key);
            //    Console.WriteLine("value = {0}", entry.Value.ToString());
            //}
            Console.WriteLine("Ending Now");

        }

        private void courseSelector1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            CourseEditor ce = new CourseEditor();
            ce.ShowDialog();
        }
    }
}
