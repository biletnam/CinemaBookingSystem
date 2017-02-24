using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema_Booking_System1
{
    public partial class moviesForm : Form
    {
        private Movie tmpMovie;
        public moviesForm()
        {
            InitializeComponent();
        }

        private void moviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingsystemDBDataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.bookingsystemDBDataSet1.Movie); //loading the data

            cbxGenre.Items.AddRange(Enum.GetNames(typeof(Genre))); //filling the combo boxes with enum
            cbxRating.Items.AddRange(Enum.GetNames(typeof(Rating)));
            tmpMovie = new Movie();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateCheck()) //if there are no warnings
            {
                tmpMovie.Name = txtMovieName.Text; //filling the variables with data
                Genre genre = (Genre)Enum.Parse(typeof(Genre), cbxGenre.SelectedItem.ToString());
                Rating rating = (Rating)Enum.Parse(typeof(Rating), cbxRating.SelectedItem.ToString());

                tmpMovie = new Movie(tmpMovie.Name, genre, rating); //creating the movie
                movieTableAdapter.Insert(tmpMovie.Name, genre.ToString(), rating.ToString()); //inserting the movie into the table

                this.movieTableAdapter.Fill(this.bookingsystemDBDataSet1.Movie);//loading the table

                MessageBox.Show("Succesfully Added A New Movie" + "/n" + tmpMovie.GetInfo());
            }
         
        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = (string)cbxMovie.SelectedValue; //storing the movie name into a variable

            movieTableAdapter.DeleteQuery(name); //deleting the variable
            this.movieTableAdapter.Fill(this.bookingsystemDBDataSet1.Movie); //loading the table
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu();//doing a new form
            this.Hide();
            main.ShowDialog();
        }
        private bool ValidateCheck()
        {
            errorProvider.Clear();
            bool check = true;

            if (txtMovieName.Text == string.Empty && txtMovieName.Enabled)
            {
                errorProvider.SetError(txtMovieName, "Required");
                check = false;
            }
            if (cbxGenre.SelectedItem == null && cbxGenre.Enabled)
            {
                errorProvider.SetError(cbxGenre, "Required");
                check = false;
            }
            if (cbxRating.SelectedItem == null && cbxRating.Enabled)
            {
                errorProvider.SetError(cbxRating, "Required");
                check = false;
            }
            return check;
        }
    }
}
