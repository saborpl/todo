using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLog;
using RecipeApp2.Properties;

namespace RecipeApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static readonly Logger m_Log = LogManager.GetCurrentClassLogger();

        private void Form1_Load(object sender, EventArgs e)
        {
            m_Log.Trace("Form1_Load()");

            using (TodoListEntities context = new TodoListEntities())
            {
                m_Log.Trace("App Connection string: {0}",context.Database.Connection.ConnectionString);
            }

            SelectData();
            groupBox1.Visible = true;
            // TODO: dodac obsluge godziny
            dateTimePickerTime.Visible = false;
        }

        private void SelectData()
        {
            m_Log.Trace("SelectData() - ladowanie contentu do tabeli...");

            labelFilterDate.Text = Resources.txtTimeItemsFrom;
            labelTodoItemsDate.Text = Resources.txtAllTimeItems;

            try
            {

                using (TodoListEntities contextt = new TodoListEntities())
                {
                    var todoList = (from b in contextt.TodoLists
                                    orderby b.TodoDate descending
                                    select b).ToArray();

                    dataGridViewRecipes.DataSource = todoList;

                }
            }
            catch (Exception ex)
            {
                m_Log.Error(ex);
                MessageBox.Show(string.Format("{0}", ex));
            }
        }

        private void AddData()
        {
            try
            {
                m_Log.Trace("AddData({0})", textBoxShow.Text);
                using (TodoListEntities context = new TodoListEntities())
                {
                    TodoList todoList = new TodoList();
                    {
                        todoList.Name = textBoxShow.Text;
                        todoList.TodoDate = Convert.ToDateTime(dateTimePickerDate.Text);
                        // TODO: dodac obsluge godziny
                        //TodoDate = Convert.ToDateTime(string.Format("{0} {1}", dateTimePickerDate.Text, dateTimePickerTime.Text)),
                        todoList.Descpription = richTextBoxRecipes.Text;
                    };
                    m_Log.Trace("AddData({0})", todoList);
                    context.TodoLists.Add(todoList);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                m_Log.Error(ex);
            }

        }

        private void EditData()
        {
            m_Log.Trace("EditData()");
            using (TodoListEntities contextt = new TodoListEntities())
            {
                TodoList todoList = contextt.TodoLists.FirstOrDefault(r => r.Name == FormInfo.TextBoxShowValue);
                if (todoList != null)
                {
                    todoList.Name = textBoxShow.Text;
                    todoList.TodoDate = Convert.ToDateTime(dateTimePickerDate.Text);
                    todoList.Descpription = richTextBoxRecipes.Text;
                }
                contextt.SaveChanges();
            }

        }

        private void DeleteData()
        {
            m_Log.Trace("DeleteData({0})", FormInfo.TextBoxShowValue);
            using (TodoListEntities contextt = new TodoListEntities())
            {
                TodoList todoList = contextt.TodoLists.FirstOrDefault(r => r.Name == FormInfo.TextBoxShowValue);
                if (todoList != null)
                {
                    contextt.TodoLists.Remove(todoList);
                    contextt.SaveChanges();
                }
            }

        }

        private void ReloadForm()
        {
            m_Log.Trace("ReloadForm()");
            textBoxShow.Text = String.Empty;
            richTextBoxRecipes.Text = String.Empty;
            dateTimePickerDate.Text = DateTime.Now.ToString(FormInfo.DateFormatDate);
            dateTimePickerFilter.Text = DateTime.Now.ToString(FormInfo.DateFormatDate);
            dateTimePickerTime.Text = DateTime.Now.ToString(FormInfo.DateFormatTime);


            recipe2DataSet.Reset();
            SelectData();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            m_Log.Trace("buttonAdd_Click()");
            if (String.IsNullOrEmpty(textBoxShow.Text))
            {
                MessageIfEmptyTextbox();
                return;
            }
            AddData();
            ReloadForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            m_Log.Trace("buttonEdit_Click()");
            if (String.IsNullOrEmpty(textBoxShow.Text))
            {
                MessageIfEmptyTextbox();
                return;
            }
            EditData();
            ReloadForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            m_Log.Trace("buttonDelete_Click()");
            if (String.IsNullOrEmpty(textBoxShow.Text))
            {
                MessageIfEmptyTextbox();
                return;
            }
            DeleteData();
            ReloadForm();
        }

        private static void MessageIfEmptyTextbox()
        {
            MessageBox.Show(
                Resources.messageTextBoxNameEmpty,
                Resources.titleTextBoxNameEmpty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        private void dataGridViewRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < 0) return;
                DataGridViewRow selectedRow = dataGridViewRecipes.Rows[index];
                dateTimePickerDate.Text = selectedRow.Cells[0].Value.ToString();

                string dateTimePickerDateTemp = selectedRow.Cells[0].Value.ToString();
                string dateTimePickerDateTime = dateTimePickerDateTemp.Substring(dateTimePickerDateTemp.Length - 8, 5);
                dateTimePickerTime.Text = dateTimePickerDateTime;

                textBoxShow.Text = selectedRow.Cells[1].Value.ToString();
                FormInfo.TextBoxShowValue = textBoxShow.Text;
                richTextBoxRecipes.Text = !String.IsNullOrEmpty(selectedRow.Cells[2].Value.ToString()) ? selectedRow.Cells[2].Value.ToString() : String.Empty;
            }
            catch (Exception ex)
            {
                m_Log.Error(ex);
            }
        }

        private void dataGridViewRecipes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool flag = false;
            foreach (DataGridViewRow myrow in dataGridViewRecipes.Rows)
            {
                if (Convert.ToDateTime(myrow.Cells[0].Value) < DateTime.Now.Date)
                {
                    //dataGridViewRecipes.Columns[0].Name
                    myrow.DefaultCellStyle.ForeColor = FormInfo.TodoExpiredColor;
                }
                else if (Convert.ToDateTime(myrow.Cells[0].Value).AddDays(-1) == DateTime.Now.Date)
                {
                    myrow.DefaultCellStyle.ForeColor = FormInfo.TodoSoonColor;
                }
                else if (Convert.ToDateTime(myrow.Cells[0].Value) == DateTime.Now.Date)
                {
                    myrow.DefaultCellStyle.ForeColor =FormInfo.TodoTodayColor;
                    flag = true;
                }
            }

        }


        //private void SelectData3()
        //{
        //    m_Log.Trace("SelectData() - ladowanie contentu do tabeli...");

        //    labelFilterDate.Text = Resources.txtTimeItemsFrom;
        //    labelTodoItemsDate.Text = Resources.txtAllTimeItems;

        //    DataTable dt = new DataTable();
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString =
        //        ConfigurationManager.ConnectionStrings[FormInfo.ConnectionStringName]
        //            .ConnectionString;
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand myCmd = new SqlCommand("SelectTodo", conn);
        //        myCmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        //        m_Log.Trace("{0}",da);
        //        da.Fill(dt);
        //        dataGridViewRecipes.DataSource = dt;
        //        //dataGridViewRecipes.DataBind();
        //        //recipesTableAdapter.Fill(recipe2DataSet.Recipes);
        //    }
        //    catch (Exception ex)
        //    {
        //        m_Log.Error(ex);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            m_Log.Trace("dateTimePickerDate_ValueChanged()");
            FormInfo.DateTimePickerDateValue = dateTimePickerDate.Value.ToString(FormInfo.DateFormatDate);
        }

        private void dateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            m_Log.Trace("dateTimePickerTime_ValueChanged()");
            FormInfo.DateTimePickerTimeValue = dateTimePickerTime.Value.ToString(FormInfo.DateFormatTime);
        }

        //private void dateTimePickerFilter_ValueChanged(object sender, EventArgs e)
        //{
        //    m_Log.Trace("dateTimePickerFilter_ValueChanged()");

        //    labelTodoItemsDate.Text = dateTimePickerFilter.Text;
            
        //    DataTable dt = new DataTable();
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString =
        //        ConfigurationManager.ConnectionStrings[FormInfo.ConnectionStringName]
        //            .ConnectionString;

        //    DateTime dateTimePickerFilterDate = Convert.ToDateTime(dateTimePickerFilter.Text);

        //    try
        //    {
        //        conn.Open();
        //        SqlCommand myCmd = new SqlCommand("SelectTodo", conn);
        //        myCmd.CommandType = CommandType.StoredProcedure;
        //        //myCmd.Parameters.AddWithValue("@TodoDate", "%" + dateTimePickerFilterDate.ToString(FormInfo.DateFormatDate) + "%");
        //        //myCmd.Parameters.Add("@TodoDate", SqlDbType.NVarChar).Value = "%" + dateTimePickerFilterDate.ToString(FormInfo.DateFormatDate) + "%";
        //        myCmd.Parameters.Add("@TodoDate", SqlDbType.NVarChar).Value = dateTimePickerFilterDate.ToString(FormInfo.DateFormatDate);
        //        m_Log.Trace("dateTimePickerFilterDate.ToString(FormInfo.DateFormatDate): {0}", dateTimePickerFilterDate.ToString(FormInfo.DateFormatDate));
        //        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        //        da.Fill(dt);
        //        dataGridViewRecipes.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        m_Log.Error(ex);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        private void dateTimePickerFilter_ValueChanged(object sender, EventArgs e)
        {
            m_Log.Trace("dateTimePickerFilter_ValueChanged()");

            labelTodoItemsDate.Text = dateTimePickerFilter.Text;

            {
                try
                {
                    DateTime dt = Convert.ToDateTime(dateTimePickerFilter.Text);
                    using (TodoListEntities contextt = new TodoListEntities())
                    {
                        var todoList = contextt.TodoLists
                            .Where(t => t.TodoDate == dt).ToArray();
                        dataGridViewRecipes.DataSource = todoList;

                    }
                }
                catch (Exception ex)
                {
                    m_Log.Error(ex);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SelectData();
        }
    }

    public static class FormInfo
    {
        public static string TextBoxShowValue;
        public static string DateTimePickerDateValue;
        public static string DateTimePickerTimeValue;
        public static string RichTextBoxRecipesValue;
        public const string DateFormatDate = "yyyy-MM-dd";
        public const string DateFormatTime = "HH:MM";
        public static Color TodoExpiredColor = Color.Crimson;
        public static Color TodoSoonColor = Color.Goldenrod;
        public static Color TodoTodayColor = Color.RoyalBlue;
    }
}
