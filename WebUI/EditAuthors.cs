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
    public partial class EditAuthors : Form
    {
        private IAuthorService _authorService;

        public EditAuthors()
        {
           _authorService = InstanceFactory.GetInstance<IAuthorService>();
            InitializeComponent();
        }

        private void EditAuthors_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            dgwAuthors.DataSource = _authorService.GetAll();
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Add(new Author()
                {
                   Name = tbxAuthorNameAdd.Text,
                   Nationality = tbxNationalityAdd.Text,
                   BookCount = Convert.ToInt32(nudBookCountAdd.Text)
                });
                MessageBox.Show("New author added!", "Message");
                LoadAuthors();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {
            _authorService.Update(new Author()
            {
                AuthorId = Convert.ToInt32(dgwAuthors.CurrentRow.Cells[0].Value), 
                Name = tbxAuthorNameUpdate.Text,
                Nationality = tbxNationalityUpdate.Text,
                BookCount = Convert.ToInt32(nudBookCountUpdate.Text)
            });
            MessageBox.Show("The author updated!", "Message");
            LoadAuthors();
        }

        private void dgwAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dgwAuthors.CurrentRow.Cells;
            tbxAuthorNameUpdate.Text = temp[1].Value.ToString();
            tbxNationalityUpdate.Text = temp[2].Value.ToString();
            nudBookCountUpdate.Text = temp[3].Value.ToString();
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            _authorService.Delete(new Author()
            {
                AuthorId = Convert.ToInt32(dgwAuthors.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("The author deleted!", "Message");
            LoadAuthors();
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
