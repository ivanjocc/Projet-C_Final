using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        private Biblioteca biblioteca = new Biblioteca();
        private List<Libro> librosPrestados = new List<Libro>();

        public Form1()
        {
            InitializeComponent();

            // Initialize the DateTimePicker control for selecting publication date
            dateTimePickerPublicationDate.Format = DateTimePickerFormat.Short;
            dateTimePickerPublicationDate.Value = DateTime.Today;

            // Bind data to DataGridViews
            dataGridViewLibrary.DataSource = biblioteca.Libros;
            dataGridViewBorrowed.DataSource = librosPrestados;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create a new book using the input values
            Libro newLibro = new Libro
            {
                Title = textBoxTitle.Text,
                Author = textBoxAuthor.Text,
                PublicationDate = dateTimePickerPublicationDate.Value
            };

            // Add the book to the library
            biblioteca.AddLibro(newLibro);

            // Refresh the DataGridView to reflect the changes
            dataGridViewLibrary.DataSource = null;
            dataGridViewLibrary.DataSource = biblioteca.Libros;

            // Clear input fields
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibrary.SelectedRows.Count > 0)
            {
                // Get the selected book
                Libro selectedLibro = (Libro)dataGridViewLibrary.SelectedRows[0].DataBoundItem;

                // Remove the book from the library
                biblioteca.RemoveLibro(selectedLibro);

                // Refresh the DataGridView to reflect the changes
                dataGridViewLibrary.DataSource = null;
                dataGridViewLibrary.DataSource = biblioteca.Libros;
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibrary.SelectedRows.Count > 0)
            {
                // Get the selected book
                Libro selectedLibro = (Libro)dataGridViewLibrary.SelectedRows[0].DataBoundItem;

                // Add the selected book to the borrowed list
                librosPrestados.Add(selectedLibro);

                // Remove the book from the library
                biblioteca.RemoveLibro(selectedLibro);

                // Refresh both DataGridViews to reflect the changes
                RefreshDataGridViews();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrowed.SelectedRows.Count > 0)
            {
                // Get the selected book
                Libro selectedLibro = (Libro)dataGridViewBorrowed.SelectedRows[0].DataBoundItem;

                // Add the selected book back to the library
                biblioteca.AddLibro(selectedLibro);

                // Remove the book from the borrowed list
                librosPrestados.Remove(selectedLibro);

                // Refresh both DataGridViews to reflect the changes
                RefreshDataGridViews();
            }
        }

        private void RefreshDataGridViews()
        {
            dataGridViewLibrary.DataSource = null;
            dataGridViewLibrary.DataSource = biblioteca.Libros;

            dataGridViewBorrowed.DataSource = null;
            dataGridViewBorrowed.DataSource = librosPrestados;
        }
    }
}
