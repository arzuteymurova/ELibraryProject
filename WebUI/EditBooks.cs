using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace WebUI
{
    public partial class EditBooks : Form
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        public EditBooks()
        {
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            InitializeComponent();
        }

        private void EditBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
            LoadAuthors();
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookService.GetBookDetails();

        }
        private void LoadCategories()
        {
            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
            cbxCategoryAdd.Text = "Choose category";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
            cbxCategoryUpdate.Text = "Choose category";
            

        }
        private void LoadAuthors()
        {
            cbxAuthorAdd.DataSource = _authorService.GetAll();
            cbxAuthorAdd.DisplayMember = "Name";
            cbxAuthorAdd.ValueMember = "AuthorId";
            cbxAuthorAdd.Text = "Choose author";

            cbxAuthorUpdate.DataSource = _authorService.GetAll();
            cbxAuthorUpdate.DisplayMember = "Name";
            cbxAuthorUpdate.ValueMember = "AuthorId";
            cbxAuthorUpdate.Text = "Choose author";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    BookTitle = tbxBookTitleAdd.Text,
                    AuthorId = Convert.ToInt32(cbxAuthorAdd.SelectedValue), 
                    CategoryId=Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                    Language = tbxLanguageAdd.Text,
                   Count = Convert.ToInt32(nudCountAdd.Text),
                    Price = Convert.ToDecimal(tbxPriceAdd.Text)
                });
                MessageBox.Show("New book added!", "Message");
                LoadBooks();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book()
            {
                BookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                BookTitle = tbxBookTitleUpdate.Text,
                AuthorId = Convert.ToInt32(cbxAuthorUpdate.SelectedValue),
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                Language = tbxLanguageUpdate.Text,
                Count = Convert.ToInt32(nudCountUpdate.Text),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text)

            });
            MessageBox.Show("The book updated!", "Message");
            LoadBooks();
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dgwBooks.CurrentRow.Cells;
            tbxBookTitleUpdate.Text = temp[1].Value.ToString();
            cbxAuthorUpdate.Text = temp[2].Value.ToString();
            cbxCategoryUpdate.Text = temp[3].Value.ToString();
            tbxLanguageUpdate.Text = temp[4].Value.ToString();
            nudCountUpdate.Text = temp[5].Value.ToString();
            tbxPriceUpdate.Text = temp[6].Value.ToString();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            _bookService.Delete(new Book()
            {
                BookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("The book deleted!", "Message");
            LoadBooks();

        }
    }
}
