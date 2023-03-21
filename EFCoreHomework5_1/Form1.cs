using EFCoreHomework5_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace EFCoreHomework5_1
{
    public partial class Form1 : Form
    {
        EFCoreHomework3Context db = new EFCoreHomework3Context();
        int selectedRow = -1;
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.dataGridView2.CellClick += dataGridView2_CellClick;
            this.dataGridView3.CellClick += dataGridView3_CellClick;
            this.dataGridView4.CellClick += dataGridView4_CellClick;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("snsdkndknd");
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            var currentTab = tabControl1.SelectedTab.Name;
            if (currentTab == "tabPage3")
            {
                
            }
            switch (currentTab)
            {
                case "tabPage1":
                    ShowCategories();
                    break;
                case "tabPage2":
                    ShowProducts();
                    break;
                case "tabPage3":
                    ShowWords();
                    break;
                case "tabPage4":
                    ShowBackUps();
                    break;
            }

            //MessageBox.Show(tabControl1.SelectedTab.Name);
        }


        async void ShowCategories()
        {
            var categories = await SelectCategories();
            dataGridView1.DataSource = categories;
        }

        private void BtnAddCategories_Click(object sender, EventArgs e)
        {
            if (textBoxCategories.Text != "")
            {
                Categories newCategory = new Categories();
                newCategory.Id = Guid.NewGuid();
                newCategory.Name = textBoxCategories.Text;

                db.Categories.Add(newCategory);
                db.SaveChanges();
                textBoxCategories.Text = "";
                ShowCategories();
            }
        }

        private void BtnDelCategories_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                //dataGridView1.Rows.RemoveAt(selectedRow);
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                var guid = row.Cells[0].Value.ToString();
                

                db.Categories.DeleteByKey(guid);
                db.SaveChanges();
                ShowCategories();

            }
        }

        private void BtnUpdCategories_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                Guid id = (Guid)row.Cells[0].Value;
                
                var entity = db.Categories.FirstOrDefault(item => item.Id == id);

                entity.Name = textBoxCategories.Text;

                db.Categories.Update(entity);
                db.SaveChanges();
                textBoxCategories.Text = "";
                ShowCategories();
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBoxCategories.Text = row.Cells[1].Value.ToString();
            //MessageBox.Show(selectedRow.ToString());
        }



        async void ShowProducts()
        {
            var products = await SelectProducts();
            dataGridView2.DataSource = products;
        }

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            if (textBoxProducts.Text != "")
            {
                Products newProduct = new Products();
                newProduct.Id = Guid.NewGuid();
                newProduct.Name = textBoxProducts.Text;
                
                var c1 = db.Categories.Where(p => p.Name == "TV").Select(p => new { Id = p.Id }).FirstOrDefault().Id;
                newProduct.CategoryId = c1; //default category


                db.Products.Add(newProduct);
                db.SaveChanges();
                textBoxProducts.Text = "";
                ShowProducts();
            }
        }

        private void BtnUpdProducts_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                Guid id = (Guid)row.Cells[0].Value;

                var entity = db.Products.FirstOrDefault(item => item.Id == id);

                entity.Name = textBoxProducts.Text;

                db.Products.Update(entity);
                db.SaveChanges();
                textBoxProducts.Text = "";
                ShowProducts();
            }
        }

        private void BtnDelProducts_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                var guid = row.Cells[0].Value.ToString();


                db.Products.DeleteByKey(guid);
                db.SaveChanges();
                ShowProducts();
            }

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRow];
            textBoxProducts.Text = row.Cells[1].Value.ToString();
            //MessageBox.Show(selectedRow.ToString());
        }




        async void ShowWords()
        {
            var words = await SelectWords();
            dataGridView3.DataSource = words;
        }


        private void BtnAddWords_Click(object sender, EventArgs e)
        {
            if (textBoxWords.Text != "")
            {
                Words newWord = new Words();
                newWord.Id = Guid.NewGuid();
                newWord.KeyWord = textBoxWords.Text;

                db.Words.Add(newWord);
                db.SaveChanges();
                textBoxWords.Text = "";
                ShowWords();
            }
        }

        private void BtnUpdWords_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];
                Guid id = (Guid)row.Cells[0].Value;

                var entity = db.Words.FirstOrDefault(item => item.Id == id);

                entity.KeyWord = textBoxWords.Text;

                db.Words.Update(entity);
                db.SaveChanges();
                textBoxWords.Text = "";
                ShowWords();
            }
        }

        private void BtnDelWords_Click(object sender, EventArgs e)
        {
            if (selectedRow != -1)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                var guid = row.Cells[0].Value.ToString();


                db.Words.DeleteByKey(guid);
                db.SaveChanges();
                ShowWords();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[selectedRow];
            textBoxWords.Text = row.Cells[2].Value.ToString();
            //MessageBox.Show(selectedRow.ToString());
        }






        static public async Task<IEnumerable<Words>> SelectWords()
        {
            using (EFCoreHomework3Context db = new EFCoreHomework3Context())
            {
                return await db.Words.ToListAsync();
            }
        }

        static public async Task<IEnumerable<Categories>> SelectCategories()
        {
            using (EFCoreHomework3Context db = new EFCoreHomework3Context())
            {
                return await db.Categories.ToListAsync();
            }
        }


        static public async Task<IEnumerable<Products>> SelectProducts()
        {
            using (EFCoreHomework3Context db = new EFCoreHomework3Context())
            {
                return await db.Products.ToListAsync();
            }
        }


        DataTable DbDataTable = new DataTable();

        async void ShowBackUps()
        {
            if (DbDataTable.Columns.Count == 0)
            {
                DbDataTable.Columns.Add("Folder");
                DbDataTable.Columns.Add("DbName");
                DbDataTable.Columns.Add("Extension");
            }
            

            if (textBox1.Text != "")
            {
                DbDataTable.Clear();
                var dirInfo = new DirectoryInfo(textBox1.Text);
                FileInfo[] info = dirInfo.GetFiles("*.bak");
                foreach (FileInfo f in info)
                {
                    DbDataTable.Rows.Add(f.Directory, Path.GetFileNameWithoutExtension(f.Name), f.Extension);
                }
                dataGridView4.DataSource = DbDataTable;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                //MessageBox.Show("You selected: " + dialog.FileName);
                textBox1.Text = dialog.FileName;
                ShowBackUps();
            }

        }

        private void btnCreateBackUp_Click(object sender, EventArgs e)
        {
            string dbname; //db.Database.Connection.Database;
            dbname = db.Database.GetDbConnection().Database;

           // MessageBox.Show("You selected: " + dbname);

            string sqlCommand = $"BACKUP DATABASE [{dbname}] TO  DISK = N'{textBox1.Text}\\{dbname+DateTime.Now.Day + DateTime.Now.Second}.bak' WITH NOFORMAT, NOINIT,  NAME = N' data ', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            
            db.Database.ExecuteSqlCommand(sqlCommand);
            ShowBackUps();

        }

        string DBForRestore;
        string PathForRestore;
        string BackUpExtension;

        private void btnRestoreDB_Click(object sender, EventArgs e)
        {
            if (DBForRestore == null)
            {
                MessageBox.Show("Selected db for restore ");
            }
            else
            {
                //MessageBox.Show("Selected db for restore "+ DBForRestore);
                string sqlCommand = $"USE [master]" +
                   $"RESTORE DATABASE [{DBForRestore}] FROM  DISK = N'{textBox1.Text}\\{DBForRestore}{BackUpExtension}' WITH  FILE = 1,  MOVE N'{DBForRestore}' TO N'{textBox1.Text}\\{DBForRestore}.mdf',  MOVE N'{DBForRestore}_log' TO N'{textBox1.Text}\\{DBForRestore}_log.ldf',  NOUNLOAD,  STATS = 5";

                

                try
                {
                    db.Database.ExecuteSqlCommand(sqlCommand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }






        }


        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView4.Rows[selectedRow];
            PathForRestore = row.Cells[0].Value.ToString();
            DBForRestore = row.Cells[1].Value.ToString();
            BackUpExtension = row.Cells[2].Value.ToString();
        }

    }
}
