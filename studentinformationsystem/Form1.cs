using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();  // Formun bileşenlerini başlatır
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);  // Bu, kaynakları serbest bırakır
    }

    private void ConnectToDatabase()
    {
        string connectionString = "Server=localhost; Database=studentdb; Uid=root; Pwd=yourpassword;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            MessageBox.Show("Veritabanına başarılı bir şekilde bağlanıldı!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Bağlantı hatası: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ConnectToDatabase();  // Form yüklendiğinde bağlantıyı kur
    }
}


