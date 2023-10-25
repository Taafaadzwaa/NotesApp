using System.Data;

namespace NotesApp
{
    public partial class notes : Form
    {

        DataTable note = new DataTable();
        bool editing = false;

        public notes()
        {
            InitializeComponent();
        }

        private void notes_Load(object sender, EventArgs e)
        {
            note.Columns.Add("Tittle");
            note.Columns.Add("Note");

            previousNotes.DataSource = note;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            titleBox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                note.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Note a valid note"); }


        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                note.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                note.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }

            else
            {
                note.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}