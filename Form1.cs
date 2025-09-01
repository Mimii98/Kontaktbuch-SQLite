using Microsoft.Data.Sqlite; //Damit k�nnen wir in C# SQL- Befehle schreiben (�bersetzt C# Methoden in SQL)
using SQLitePCL; //SQLitePCL ist eine Bibliothek, die zb Dateien �ffnet, SQL ausf�hrt, Daten speichert etc
using System.Configuration;



namespace KontaktbuchVersuch1000_oder_so
{
    public partial class Form1 : Form
    {
        private SqliteConnection connection; //Klassenvariable (jetzt �berall in Form1 nutzbar)

        //Konstruktor
        public Form1()
        {
            InitializeComponent(); //Baut die Benutzeroberfl�che
            connection = new SqliteConnection("Data Source=kontaktbuch.db");//Erstellt eine Verbindung zur SQLite-Datenbank "kontaktbuch.db"
            connection.Open(); //�ffnet die Verbindung zur Datenbank

            var cmd = connection.CreateCommand(); //Erstellt ein SQL-Kommando
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Kontakte " + "(Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Name TEXT, " +
                "Tel TEXT, " +
                "Email TEXT)";//SQL-Befehl zum Erstellen der Tabelle "Kontakte", falls sie nicht existiert
            cmd.ExecuteNonQuery(); //F�hrt das SQL-Kommando aus, um die Tabelle zu erstellen

            connection.Close(); //Verbindug schlie�en (wichtig)

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Logik f�r den Button "Speichern"
        private void Btnsave_Click(object sender, EventArgs e)
        {
           

            //Variablen zum Speichern der Informationen
            var name = txtBoxName.Text; //Name des Kontakts
            var tel = txtBoxTel.Text;
            var email = txtBoxEmail.Text;

           
           
            //Falls nichts eingeben wurde
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Bitte f�lle alle Felder aus");
                return;//Beendet die Methode, wenn eines der Felder leer ist
            }
            
            connection.Open(); //�ffnet die Verbindung zur Datenbank
            var insertcmd = connection.CreateCommand();//Erstellt ein SQL-Kommando f�r das Einf�gen von Daten
            insertcmd.CommandText = @"INSERT INTO Kontakte (name, tel, email) VALUES (@name, @tel, @email)";//SQL-Befehl zum Einf�gen von Daten in die Tabelle "Kontakte"
            insertcmd.Parameters.AddWithValue("@name", name);//Parameter f�r den Namen
            insertcmd.Parameters.AddWithValue("@tel", tel);//Parameter f�r die Telefonnummer
            insertcmd.Parameters.AddWithValue("@email", email);//Parameter f�r die E-Mail-Adresse

            insertcmd.ExecuteNonQuery(); //F�hrt das SQL-Kommando aus, um die Daten in die Datenbank einzuf�gen
            connection.Close(); //Schlie�t die Verbindung zur Datenbank
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
