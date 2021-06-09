using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using WebUI.Helpers;

namespace WebUI
{
    public partial class MainMenu : Form
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        public MainMenu()
        {
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService=InstanceFactory.GetInstance<ICategoryService>();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            InitializeComponent();
        }

        private Utilities _utilities = new Utilities();

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
            LoadAuthors();
        }

        private void LoadBooks()
        {
            dgwBooksMainMenu.DataSource = _bookService.GetBookDetails();
        }
        private void LoadCategories()
        {
            cbxSearchByCategory.DataSource = _categoryService.GetAll();
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "CategoryId";
            cbxSearchByCategory.Text = "Choose category";
           
        }

        private void LoadAuthors()
        {
            cbxSearchByAuthor.DataSource = _authorService.GetAll();
            cbxSearchByAuthor.DisplayMember = "Name";
            cbxSearchByAuthor.ValueMember = "AuthorId";
            cbxSearchByAuthor.Text = "Choose author";

        }

        private void tbxSearchByBookTitle_TextChanged(object sender, EventArgs e)
        {
            var text = tbxSearchByBookTitle.Text;
            _utilities.Check(_utilities.IsNullOrEmpty, text, () =>
            {
                dgwBooksMainMenu.DataSource = _bookService.GetByBookTitle(text);
            }, LoadBooks);
        }

        private void cbxSearchByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooksMainMenu.DataSource = _bookService.GetByCategory(Convert.ToInt32(cbxSearchByCategory.SelectedValue));
               
            }
            catch 
            {
                
            }
        }

        private void cbxSearchByAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooksMainMenu.DataSource = _bookService.GetByAuthor(Convert.ToInt32(cbxSearchByAuthor.SelectedValue));
            }
            catch 
            {
                
            }
        }


        private void tbxSearchByLanguage_TextChanged(object sender, EventArgs e)
        {
            var text = tbxSearchByLanguage.Text;
            _utilities.Check(_utilities.IsNullOrEmpty,text, () =>
            {
                dgwBooksMainMenu.DataSource = _bookService.GetByLanguage(text);
            },LoadBooks);
           
        }

        private void LoadByPrice()
        {
            decimal min = 0;
            decimal max = 1000;
            var minPrice = tbxMinPrice.Text;
            var maxPrice = tbxMaxPrice.Text;
            _utilities.Check(_utilities.IsNullOrEmpty, minPrice, () => { min = Convert.ToDecimal(minPrice); });
            _utilities.Check(_utilities.IsNullOrEmpty, maxPrice, () => { max = Convert.ToDecimal(maxPrice); });
            dgwBooksMainMenu.DataSource = _bookService.GetByPrice(min, max);
        }

        private void tbxMinPrice_TextChanged(object sender, EventArgs e)
        {
            _utilities.Check(_utilities.IsNullOrEmpty,tbxMinPrice.Text,LoadByPrice,LoadBooks);
        }

        private void tbxMaxPrice_TextChanged(object sender, EventArgs e)
        {
            _utilities.Check(_utilities.IsNullOrEmpty, tbxMaxPrice.Text, LoadByPrice, LoadBooks);
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editBooks = new EditBooks();
            editBooks.ShowDialog();
            this.Close();
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editCategories = new EditCategories();
            editCategories.ShowDialog();
            this.Close();
        }

        private void btnEditAuthors_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editAuthors = new EditAuthors();
            editAuthors.ShowDialog();
            this.Close();
        }

        



        //private void tbxSearchByAuthor_TextChanged(object sender, EventArgs e)
        //{
        //    dgwBooksHomepage.DataSource = _bookService.GetByAuthorName(tbxSearchByAuthor.Text);
        //}
    }
}
