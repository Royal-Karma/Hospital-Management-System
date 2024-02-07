using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System;

public partial class Diagnosis : Form
{
    public Diagnosis()
    {
        InitializeComponent();
        DisplayDiagnosis();
    }
    readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\OsiyoComputers\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");
    private void DisplayDiagnosis()
    {
        try
        {
            Con.Open();
            string Qurry = "Select * from Diagnosis";
            SqlDataAdapter sda = new SqlDataAdapter(Qurry, Con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Con.Close();
        }
    }
    private void AddBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (textBox1.Text == " " || comboBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "insert into Diagnosis Values(' " + textBox1.Text + " ', ' " + comboBox1.Text + " ', ' " + textBox2.Text + " ', ' " + textBox3.Text + " ', ' " + textBox4.Text + " ', ' " + textBox5.Text + " ')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Record Extered Successfully");
                DisplayDiagnosis();
            }
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            Con.Close();
        }
    }

    private void UpdateBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (textBox1.Text == " " || comboBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "update Patient Set PatientId = @PPatientId, PatientName = @PatientName, Symptoms = @Symptoms, DiagnosoticTest = @DiagnosticTest, Medicines = @Medicines, where DId = @DId";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Sumptoms", textBox3.Text);
                cmd.Parameters.AddWithValue("@DiagnosticTest", textBox4.Text);
                cmd.Parameters.AddWithValue("@Medicines", textBox5.Text);
                cmd.Parameters.AddWithValue("@PId", textBox1.Text);


                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Record Extered Successfully");
                DisplayDiagnosis();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Con.Close();
        }
    }   
        
    }
}

