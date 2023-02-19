using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1ApiUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //istek atmak için
        WebClient client = new WebClient();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Season.Text.Length != 4)
            {
                MessageBox.Show("You must enter a four digit number for the season");
                return;
            }// sezon bilgisinin 4 rakam olup olmadığını kontrol ederiz

            if (Race.Text.Length < 1 || Race.Text.Length > 2)
            {
                MessageBox.Show("You must enter a one or two digit number for the race");
                return;
            }// race bilgisinin 1 veya 2 haneli olup olmadığını kontrol ederiz.


            string url = "https://ergast.com/api/f1/";
            url = url + Season.Text;
            url = url + "/";
            url = url + Race.Text;
            url = url + "/results.json";

            //yazılar bozuk gelmemesi için
            client.Encoding = Encoding.UTF8;

            //json indirmek için
            string json = client.DownloadString(url);

            //json to c#
            var results = JsonConvert.DeserializeObject<TopThreeResult>(json);

            //eğer yarış yok ise
            if (results.MRData.RaceTable.Races.Count == 0)
            {
                MessageBox.Show("There not has race at " + Season.Text + " season " + Race.Text + ". round", "Error !");
                return;
            }

            var race = results.MRData.RaceTable.Races[0];

            //ilk 3'ü getir.
            var topThree = race.Results.Take(3).ToList();

            RaceGrid.Rows.Clear();

            foreach (var item in topThree)
            {
                RaceGrid.Rows.Add(item.Constructor.name, item.Driver.givenName + " " + item.Driver.familyName, item.Time.time, item.points, item.positionText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SeasonForPitSpot.Text.Length != 4)
            {
                MessageBox.Show("You must enter a four digit number for the season");
                return;
            }

            if (RaceForPitSpot.Text.Length < 1 || RaceForPitSpot.Text.Length > 2)
            {
                MessageBox.Show("You must enter a one or two digit number for the race");
                return;
            }

            if (Stop.Text.Length != 1)
            {
                MessageBox.Show("You must enter a one digit number for the stop");
                return;
            }

            string url = "https://ergast.com/api/f1/";
            url = url + SeasonForPitSpot.Text;
            url = url + "/";
            url = url + RaceForPitSpot.Text;
            url = url + "/";
            url = url + "pitstops";
            url = url + "/";
            url = url + Stop.Text;
            url = url + ".json";

            client.Encoding = Encoding.UTF8;

            string json = client.DownloadString(url);

            var pitResult = JsonConvert.DeserializeObject<PitStopResult>(json);

            if (pitResult.MRData.RaceTable.Races.Count == 0)
            {
                MessageBox.Show("There not has race at " + SeasonForPitSpot.Text + ", season " + RaceForPitSpot.Text + ", stop " + Stop.Text, "Error !");
                return;
            }

            var race = pitResult.MRData.RaceTable.Races[0];


            if (race.PitStops == null)
            {
                MessageBox.Show("There not has pit stop at " + SeasonForPitSpot.Text + " season " + RaceForPitSpot.Text + " round " + Stop.Text + " stop", "Error !");
                return;
            }

            PitStop.Rows.Clear();

            foreach (var item in race.PitStops)
            {
                PitStop.Rows.Add(item.driverId, item.stop, item.lap, item.time, item.duration);
            }
        }
    }
}


// PitStop 2011 den sonraki yıllarda çalışır.