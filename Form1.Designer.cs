namespace NotesApp
{
    partial class notes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleBox = new TextBox();
            noteBox = new TextBox();
            Title = new Label();
            label1 = new Label();
            previousNotes = new DataGridView();
            btnRead = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNewNote = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(325, 36);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(413, 23);
            titleBox.TabIndex = 0;
            titleBox.TextChanged += textBox1_TextChanged;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(325, 99);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(456, 323);
            noteBox.TabIndex = 1;
            noteBox.TextChanged += textBox2_TextChanged;
            // 
            // Title
            // 
            Title.Font = new Font("Cooper Black", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            Title.Location = new Point(325, -1);
            Title.Name = "Title";
            Title.Size = new Size(413, 34);
            Title.TabIndex = 2;
            Title.Text = "Title";
            Title.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(325, 62);
            label1.Name = "label1";
            label1.Size = new Size(444, 34);
            label1.TabIndex = 3;
            label1.Text = "Note :";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(2, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(317, 347);
            previousNotes.TabIndex = 4;
            previousNotes.CellContentClick += previousNotes_CellContentClick;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.Location = new Point(12, 365);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(212, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(212, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNewNote
            // 
            btnNewNote.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewNote.Location = new Point(12, 399);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(104, 23);
            btnNewNote.TabIndex = 9;
            btnNewNote.Text = "New Note";
            btnNewNote.UseVisualStyleBackColor = true;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(793, 434);
            Controls.Add(btnNewNote);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(previousNotes);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "notes";
            Text = "Notes";
            Load += notes_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label Title;
        private Label label1;
        private DataGridView previousNotes;
        private Button btnRead;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNewNote;
    }
}