using System;
using System.Collections.Generic;
using System.IO;  // Per leggere il file
using System.Linq; // Per utilizzare LINQ
using System.Windows.Forms;
using System.Diagnostics; // Using per aprire i link nel browser

namespace Open_data
{
    public partial class Form1 : Form
    {
        private List<F1Driver> drivers = new List<F1Driver>();

        public Form1()
        {
            InitializeComponent();

            // Configura le colonne della ListView
            ListViewPiloti.View = View.Details;
            ListViewPiloti.Columns.Add("Driver", 100);
            ListViewPiloti.Columns.Add("Nationality", 100);
            ListViewPiloti.Columns.Add("Seasons", 100);
            ListViewPiloti.Columns.Add("Championships", 100);
            ListViewPiloti.Columns.Add("Race Entries", 100);
            ListViewPiloti.Columns.Add("Race Starts", 100);
            ListViewPiloti.Columns.Add("Pole Positions", 100);
            ListViewPiloti.Columns.Add("Race Wins", 100);
            ListViewPiloti.Columns.Add("Podiums", 100);
            ListViewPiloti.Columns.Add("Fastest Laps", 100);
            ListViewPiloti.Columns.Add("Points", 100);
            ListViewPiloti.Columns.Add("Active", 50);
            ListViewPiloti.Columns.Add("Championship Years", 100);
            ListViewPiloti.Columns.Add("Decade", 100);
            ListViewPiloti.Columns.Add("Pole Rate", 100);
            ListViewPiloti.Columns.Add("Start Rate", 100);
            ListViewPiloti.Columns.Add("Win Rate", 100);
            ListViewPiloti.Columns.Add("Podium Rate", 100);
            ListViewPiloti.Columns.Add("Fast Lap Rate", 100);
            ListViewPiloti.Columns.Add("Points Per Entry", 100);
            ListViewPiloti.Columns.Add("Years Active", 100);
            ListViewPiloti.Columns.Add("Champion", 100);

            // Aggiungi opzioni alla ComboBox
            ComboBoxPilota.Items.Add("Nationality");
            ComboBoxPilota.Items.Add("Active");
            ComboBoxPilota.Items.Add("Champion");
            ComboBoxPilota.SelectedIndex = 0; // Imposta il valore predefinito

            // Imposta la ComboBox True/False
            ComboBoxTrueFalse.Items.Add("True");
            ComboBoxTrueFalse.Items.Add("False");
            ComboBoxTrueFalse.Visible = false; // Nascondila inizialmente
        }

        // Evento che si attiva quando il form viene caricato
        private void Form1_Load(object sender, EventArgs e)
        {
            // Chiama la funzione per caricare i dati dal file
            LoadDataFromFile("F1DriversData.txt");
        }

        // Funzione per caricare i dati dal file
        private void LoadDataFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Il file non esiste.");
                return;
            }

            // Legge tutte le righe del file
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                // Dividi ogni linea in base alla virgola
                string[] values = line.Split(',');

                // Assicurati che ci siano abbastanza colonne per creare un oggetto F1Driver
                if (values.Length >= 22)
                {
                    // Crea un nuovo oggetto F1Driver
                    F1Driver driver = new F1Driver(
                        values[0], // Driver
                        values[1], // Nationality
                        values[2], // Seasons
                        values[3], // Championships
                        values[4], // RaceEntries
                        values[5], // RaceStarts
                        values[6], // PolePositions
                        values[7], // RaceWins
                        values[8], // Podiums
                        values[9], // FastestLaps
                        values[10], // Points
                        values[11], // Active
                        values[12], // ChampionshipYears
                        values[13], // Decade
                        values[14], // PoleRate
                        values[15], // StartRate
                        values[16], // WinRate
                        values[17], // PodiumRate
                        values[18], // FastLapRate
                        values[19], // PointsPerEntry
                        values[20], // YearsActive
                        values[21]  // Champion
                    );  

                    // Aggiungi il driver alla lista
                    drivers.Add(driver);
                }
            }

            // Popola la ListView con i dati
            PopulateListView(drivers);
        }

        // Funzione per popolare la ListView
        private void PopulateListView(IEnumerable<F1Driver> driversToDisplay)
        {
            ListViewPiloti.Items.Clear(); // Pulisci la ListView

            foreach (var driver in driversToDisplay)
            {
                var item = new ListViewItem(driver.Driver);
                item.SubItems.Add(driver.Nationality);
                item.SubItems.Add(driver.Seasons.ToString());
                item.SubItems.Add(driver.Championships.ToString());
                item.SubItems.Add(driver.RaceEntries.ToString());
                item.SubItems.Add(driver.RaceStarts.ToString());
                item.SubItems.Add(driver.PolePositions.ToString());
                item.SubItems.Add(driver.RaceWins.ToString());
                item.SubItems.Add(driver.Podiums.ToString());
                item.SubItems.Add(driver.FastestLaps.ToString());
                item.SubItems.Add(driver.Points.ToString());
                item.SubItems.Add(driver.Active.ToString());
                item.SubItems.Add(driver.ChampionshipYears.ToString());
                item.SubItems.Add(driver.Decade.ToString());
                item.SubItems.Add(driver.PoleRate.ToString());
                item.SubItems.Add(driver.StartRate.ToString());
                item.SubItems.Add(driver.WinRate.ToString());
                item.SubItems.Add(driver.PodiumRate.ToString());
                item.SubItems.Add(driver.FastLapRate.ToString());
                item.SubItems.Add(driver.PointsPerEntry.ToString());
                item.SubItems.Add(driver.YearsActive.ToString());
                item.SubItems.Add(driver.Champion.ToString());

                ListViewPiloti.Items.Add(item);
            }
        }

        // Funzione per applicare tutti i filtri insieme
        private void ApplyFilters()
        {
            // Ottieni i termini di ricerca
            string searchTerm = SearchBoxPilota.Text.ToLower(); // Testo inserito nella SearchBoxPilota
            string searchNationality = NationalityBox.Text.ToLower(); // Testo inserito nella NationalityBox
            string selectedFilter = ComboBoxPilota.SelectedItem?.ToString();
            string searchTrueFalse = ComboBoxTrueFalse.SelectedItem?.ToString().ToLower(); // True/False selezionato dalla ComboBox

            // Inizia con tutti i piloti
            IEnumerable<F1Driver> filteredDrivers = drivers;

            // Filtra per nome pilota se c'è un testo inserito nella SearchBoxPilota
            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredDrivers = filteredDrivers.Where(d => d.Driver.ToLower().Contains(searchTerm));
            }

            // Filtra per nazionalità se c'è un testo inserito nella NationalityBox
            if (!string.IsNullOrEmpty(searchNationality))
            {
                filteredDrivers = filteredDrivers.Where(d => d.Nationality.ToLower().Contains(searchNationality));
            }

            // Filtra in base al filtro selezionato nella ComboBox
            if (!string.IsNullOrEmpty(selectedFilter))
            {
                switch (selectedFilter)
                {
                    case "Active":
                        if (!string.IsNullOrEmpty(searchTrueFalse))
                        {
                            filteredDrivers = filteredDrivers.Where(d => d.Active.ToLower() == searchTrueFalse);
                        }
                        break;

                    case "Champion":
                        if (!string.IsNullOrEmpty(searchTrueFalse))
                        {
                            filteredDrivers = filteredDrivers.Where(d => d.Champion.ToLower() == searchTrueFalse);
                        }
                        break;
                }
            }

            // Aggiorna la ListView con i risultati filtrati
            PopulateListView(filteredDrivers);
        }

        // Evento che si attiva quando cambia la selezione nella ComboBox ComboBoxPilota
        private void ComboBoxPilota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostra o nascondi la ComboBoxTrueFalse in base alla selezione
            if (ComboBoxPilota.SelectedItem.ToString() == "Active" || ComboBoxPilota.SelectedItem.ToString() == "Champion")
            {
                ComboBoxTrueFalse.Visible = true;
                label2.Visible = true;
            }
            else
            {
                ComboBoxTrueFalse.Visible = false;
                label2.Visible = false;
            }

            // Applica i filtri aggiornati
            ApplyFilters();
        }

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            // Resetta il testo nelle TextBox
            SearchBoxPilota.Text = string.Empty;
            NationalityBox.Text = string.Empty;

            // Resetta le ComboBox alla selezione predefinita
            ComboBoxPilota.SelectedIndex = 0; // Imposta la prima opzione di default
            ComboBoxTrueFalse.SelectedIndex = -1; // Deseleziona True/False

            // Nascondi la ComboBoxTrueFalse se necessario
            ComboBoxTrueFalse.Visible = false;
            label2.Visible = false;

            // Ripopola la ListView con tutti i piloti non filtrati
            PopulateListView(drivers);
        }
        private void ListLinkButton_Click(object sender, EventArgs e)
        {
            // Usa Process.Start per aprire il link nel browser
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.alvolante.it/formula1/piloti",
                UseShellExecute = true // Necessario per aprire l'URL nel browser predefinito
            });
        }
        // Evento che si attiva quando cambia il testo nella SearchBoxPilota (ricerca per nome pilota)
        private void SearchBoxPilota_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Applica i filtri aggiornati
        }

        // Evento che si attiva quando cambia la selezione nella ComboBox ComboBoxTrueFalse
        private void ComboBoxTrueFalse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Applica i filtri aggiornati
        }

        // Evento che si attiva quando cambia il testo nella TextBox NationalityBox
        private void NationalityBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Applica i filtri aggiornati
        }

        // Funzione per chiudere l'applicazione
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Classe che rappresenta un singolo pilota di F1 nel dataset
        public class F1Driver
        {
            public string Driver { get; set; }
            public string Nationality { get; set; }
            public string Seasons { get; set; }
            public string Championships { get; set; }
            public string RaceEntries { get; set; }
            public string RaceStarts { get; set; }
            public string PolePositions { get; set; }
            public string RaceWins { get; set; }
            public string Podiums { get; set; }
            public string FastestLaps { get; set; }
            public string Points { get; set; }
            public string Active { get; set; }
            public string ChampionshipYears { get; set; }
            public string Decade { get; set; }
            public string PoleRate { get; set; }
            public string StartRate { get; set; }
            public string WinRate { get; set; }
            public string PodiumRate { get; set; }
            public string FastLapRate { get; set; }
            public string PointsPerEntry { get; set; }
            public string YearsActive { get; set; }
            public string Champion { get; set; }

            public F1Driver(string driver, string nationality, string seasons, string championships, string raceEntries, string raceStarts,
                            string polePositions, string raceWins, string podiums, string fastestLaps, string points, string active,
                            string championshipYears, string decade, string poleRate, string startRate, string winRate,
                            string podiumRate, string fastLapRate, string pointsPerEntry, string yearsActive, string champion)
            {
                Driver = driver;
                Nationality = nationality;
                Seasons = seasons;
                Championships = championships;
                RaceEntries = raceEntries;
                RaceStarts = raceStarts;
                PolePositions = polePositions;
                RaceWins = raceWins;
                Podiums = podiums;
                FastestLaps = fastestLaps;
                Points = points;
                Active = active;
                ChampionshipYears = championshipYears;
                Decade = decade;
                PoleRate = poleRate;
                StartRate = startRate;
                WinRate = winRate;
                PodiumRate = podiumRate;
                FastLapRate = fastLapRate;
                PointsPerEntry = pointsPerEntry;
                YearsActive = yearsActive;
                Champion = champion;
            }
        }
    }
}
