using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace WebUI
{
    public partial class EditCategories : Form
    {
        private ICategoryService _categoryService;

        public EditCategories()
        {
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            InitializeComponent();
        }
        
        private void EditCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgwCategories.DataSource = _categoryService.GetAll();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category()
                {
                    CategoryName = tbxCategoryNameAdd.Text,
                    BookCount = Convert.ToInt32(nudBookCountAdd.Text)
                });
                MessageBox.Show("New category added!", "Message");
                LoadCategories();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category()
            {
                CategoryId = Convert.ToInt32(dgwCategories.CurrentRow.Cells[0].Value),
                CategoryName = tbxCategoryNameUpdate.Text,
                BookCount = Convert.ToInt32(nudBookCountUpdate.Text)
            });
            MessageBox.Show("The category updated!", "Message");
            LoadCategories();
        }

        private void dgwCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dgwCategories.CurrentRow.Cells;
            tbxCategoryNameUpdate.Text = temp[1].Value.ToString();
            nudBookCountUpdate.Text = temp[2].Value.ToString();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category()
            {
                CategoryId = Convert.ToInt32(dgwCategories.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("The category deleted!", "Message");
            LoadCategories();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
