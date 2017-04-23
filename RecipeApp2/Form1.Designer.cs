using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RecipeApp2.Properties;
using RecipeApp2.Recipe2DataSetTableAdapters;

namespace RecipeApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxRecipes = new System.Windows.Forms.RichTextBox();
            this.labelDataGrid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelListBox = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectTodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipe2DataSet = new RecipeApp2.Recipe2DataSet();
            this.selectTodoTableAdapter = new RecipeApp2.Recipe2DataSetTableAdapters.SelectTodoTableAdapter();
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelFilterDate = new System.Windows.Forms.Label();
            this.labelTodoItemsDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxShow
            // 
            this.textBoxShow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxShow.Location = new System.Drawing.Point(132, 36);
            this.textBoxShow.MaxLength = 150;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(308, 17);
            this.textBoxShow.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(320, 274);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "NEW";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(183, 274);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 40);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(44, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(132, 213);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerDate.TabIndex = 5;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dateTimePickerTime);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.richTextBoxRecipes);
            this.groupBox1.Controls.Add(this.labelDataGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxShow);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(553, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 333);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todo List";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "HH:MM";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(350, 213);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(90, 20);
            this.dateTimePickerTime.TabIndex = 11;
            this.dateTimePickerTime.Value = new System.DateTime(2017, 4, 16, 23, 40, 0, 0);
            this.dateTimePickerTime.ValueChanged += new System.EventHandler(this.dateTimePickerTime_ValueChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(40, 88);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxRecipes
            // 
            this.richTextBoxRecipes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBoxRecipes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxRecipes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBoxRecipes.Location = new System.Drawing.Point(132, 88);
            this.richTextBoxRecipes.MaxLength = 255;
            this.richTextBoxRecipes.Name = "richTextBoxRecipes";
            this.richTextBoxRecipes.Size = new System.Drawing.Size(308, 96);
            this.richTextBoxRecipes.TabIndex = 8;
            this.richTextBoxRecipes.Text = "";
            // 
            // labelDataGrid
            // 
            this.labelDataGrid.AutoSize = true;
            this.labelDataGrid.Location = new System.Drawing.Point(70, 213);
            this.labelDataGrid.Name = "labelDataGrid";
            this.labelDataGrid.Size = new System.Drawing.Size(30, 13);
            this.labelDataGrid.TabIndex = 7;
            this.labelDataGrid.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Font = new System.Drawing.Font("04b11", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListBox.Location = new System.Drawing.Point(799, 22);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(221, 29);
            this.labelListBox.TabIndex = 7;
            this.labelListBox.Text = "TODO LIST";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(352, 34);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(67, 13);
            this.labelFilter.TabIndex = 12;
            this.labelFilter.Text = "Filter by date";
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.AllowUserToAddRows = false;
            this.dataGridViewRecipes.AllowUserToDeleteRows = false;
            this.dataGridViewRecipes.AutoGenerateColumns = false;
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewRecipes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewRecipes.DataSource = this.selectTodoBindingSource;
            this.dataGridViewRecipes.Location = new System.Drawing.Point(13, 84);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.ReadOnly = true;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(527, 426);
            this.dataGridViewRecipes.TabIndex = 13;
            this.dataGridViewRecipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipes_CellClick);
            this.dataGridViewRecipes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewRecipes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TodoDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "TodoDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descpription";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descpription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // selectTodoBindingSource
            // 
            this.selectTodoBindingSource.DataMember = "SelectTodo";
            this.selectTodoBindingSource.DataSource = this.recipe2DataSet;
            // 
            // recipe2DataSet
            // 
            this.recipe2DataSet.DataSetName = "Recipe2DataSet";
            this.recipe2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectTodoTableAdapter
            // 
            this.selectTodoTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilter.Location = new System.Drawing.Point(349, 54);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFilter.TabIndex = 14;
            this.dateTimePickerFilter.ValueChanged += new System.EventHandler(this.dateTimePickerFilter_ValueChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(259, 52);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "reset list";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelFilterDate
            // 
            this.labelFilterDate.AutoSize = true;
            this.labelFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilterDate.Location = new System.Drawing.Point(15, 60);
            this.labelFilterDate.Name = "labelFilterDate";
            this.labelFilterDate.Size = new System.Drawing.Size(124, 16);
            this.labelFilterDate.TabIndex = 18;
            this.labelFilterDate.Text = "Todo items from:";
            // 
            // labelTodoItemsDate
            // 
            this.labelTodoItemsDate.AutoSize = true;
            this.labelTodoItemsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTodoItemsDate.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelTodoItemsDate.Location = new System.Drawing.Point(138, 62);
            this.labelTodoItemsDate.Name = "labelTodoItemsDate";
            this.labelTodoItemsDate.Size = new System.Drawing.Size(71, 13);
            this.labelTodoItemsDate.TabIndex = 19;
            this.labelTodoItemsDate.Text = "2015.07.12";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1034, 522);
            this.Controls.Add(this.labelTodoItemsDate);
            this.Controls.Add(this.labelFilterDate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.dataGridViewRecipes);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo List Robert Łuczyński 2017 wersja: 0.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxShow;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private DateTimePicker dateTimePickerDate;
        private GroupBox groupBox1;
        private Label labelListBox;
        private Label label1;
        private Label labelDataGrid;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn todoDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descpriptionDataGridViewTextBoxColumn;
        private RichTextBox richTextBoxRecipes;
        private Label labelDescription;
        //private Recipe2DataSet recipe2DataSet;
        //private Recipe2DataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private Label labelFilter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DateTimePicker dateTimePickerTime;
        private DataGridView dataGridViewRecipes;
        private BindingSource selectTodoBindingSource;
        private Recipe2DataSet recipe2DataSet;
        private SelectTodoTableAdapter selectTodoTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DateTimePicker dateTimePickerFilter;
        private Button buttonReset;
        private Label labelFilterDate;
        private Label labelTodoItemsDate;
    }
}

