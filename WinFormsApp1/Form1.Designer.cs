namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnBuscar = new Button();
            txtSearch = new TextBox();
            listView1 = new ListView();
            Nombre = new ColumnHeader();
            asunto = new ColumnHeader();
            lblSeleccion = new Label();
            txtSeleccion = new TextBox();
            btnGuardar = new Button();
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            emailRepositoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            listBox1.Location = new Point(72, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 259);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(307, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(72, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nombre, asunto });
            listView1.Location = new Point(295, 140);
            listView1.Name = "listView1";
            listView1.Size = new Size(149, 259);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(84, 457);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(57, 15);
            lblSeleccion.TabIndex = 4;
            lblSeleccion.Text = "Seleccion";
            // 
            // txtSeleccion
            // 
            txtSeleccion.Location = new Point(84, 475);
            txtSeleccion.Name = "txtSeleccion";
            txtSeleccion.Size = new Size(239, 23);
            txtSeleccion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(86, 514);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(468, 140);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(145, 256);
            checkedListBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column2 });
            dataGridView1.Location = new Point(645, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(317, 259);
            dataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "nombredg";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            Column2.HeaderText = "asunto dg";
            Column2.Name = "Column2";
            // 
            // emailRepositoryBindingSource
            // 
            emailRepositoryBindingSource.DataSource = typeof(App.Core.Data.EmailRepository);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 586);
            Controls.Add(dataGridView1);
            Controls.Add(checkedListBox1);
            Controls.Add(btnGuardar);
            Controls.Add(txtSeleccion);
            Controls.Add(lblSeleccion);
            Controls.Add(listView1);
            Controls.Add(txtSearch);
            Controls.Add(btnBuscar);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnBuscar;
        private TextBox txtSearch;
        private ListView listView1;
        private Label lblSeleccion;
        private TextBox txtSeleccion;
        private Button btnGuardar;
        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private ColumnHeader Nombre;
        private ColumnHeader asunto;
        private BindingSource emailRepositoryBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
    }
}