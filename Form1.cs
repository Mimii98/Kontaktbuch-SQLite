using Microsoft.Data.Sqlite; //Damit können wir in C# SQL- Befehle schreiben (übersetzt C# Methoden in SQL)
using SQLitePCL; //SQLitePCL ist eine Bibliothek, die zb Dateien öffnet, SQL ausführt, Daten speichert etc
using System.Configuration;



namespace KontaktbuchVersuch1000_oder_so
{
    public partial class Form1 : Form
    {
        private SqliteConnection connection; //Klassenvariable (jetzt überall in Form1 nutzbar)

        //Konstruktor
        public Form1()
        {
            InitializeComponent(); //Baut die Benutzeroberfläche
            connection = new SqliteConnection("Data Source=kontaktbuch.db");//Erstellt eine Verbindung zur SQLite-Datenbank "kontaktbuch.db"
            connection.Open(); //Öffnet die Verbindung zur Datenbank

            var cmd = connection.CreateCommand(); //Erstellt ein SQL-Kommando
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Kontakte " + "(Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Name TEXT, " +
                "Tel TEXT, " +
                "Email TEXT)";//SQL-Befehl zum Erstellen der Tabelle "Kontakte", falls sie nicht existiert
            cmd.ExecuteNonQuery(); //Führt das SQL-Kommando aus, um die Tabelle zu erstellen

            connection.Close(); //Verbindug schließen (wichtig)

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Logik für den Button "Speichern"
        private void Btnsave_Click(object sender, EventArgs e)
        {
           

            //Variablen zum Speichern der Informationen
            var name = txtBoxName.Text; //Name des Kontakts
            var tel = txtBoxTel.Text;
            var email = txtBoxEmail.Text;

           
           
            //Falls nichts eingeben wurde
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Bitte fülle alle Felder aus");
                return;//Beendet die Methode, wenn eines der Felder leer ist
            }
            
            connection.Open(); //Öffnet die Verbindung zur Datenbank
            var insertcmd = connection.CreateCommand();//Erstellt ein SQL-Kommando für das Einfügen von Daten
            insertcmd.CommandText = @"INSERT INTO Kontakte (name, tel, email) VALUES (@name, @tel, @email)";//SQL-Befehl zum Einfügen von Daten in die Tabelle "Kontakte"
            insertcmd.Parameters.AddWithValue("@name", name);//Parameter für den Namen
            insertcmd.Parameters.AddWithValue("@tel", tel);//Parameter für die Telefonnummer
            insertcmd.Parameters.AddWithValue("@email", email);//Parameter für die E-Mail-Adresse

            insertcmd.ExecuteNonQuery(); //Führt das SQL-Kommando aus, um die Daten in die Datenbank einzufügen
            connection.Close(); //Schließt die Verbindung zur Datenbank
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
