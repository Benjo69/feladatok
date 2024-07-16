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

namespace StoringImages
{
    public partial class DisplayImages : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataGridView dataGridView;
        private PictureBox pictureBox;
        private ContextMenuStrip contextMenuStrip;

        public DisplayImages()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }

        private void InitializeDatabase()
        {
            string connectionString = "your_connection_string_here";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM YourTable", connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            dataTable = new DataTable();
        }

        private void LoadData()
        {
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataRowView rowView = (DataRowView)dataGridView.SelectedRows[0].DataBoundItem;
                byte[] imageData = (byte[])rowView["ImageColumn"];
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip.Show(dataGridView, e.Location);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement Save functionality
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataRowView rowView = (DataRowView)dataGridView.SelectedRows[0].DataBoundItem;
                rowView.Row.Delete();
                adapter.Update(dataTable);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement Save As functionality
        }
    }
}