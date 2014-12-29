using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLibraryApp
{
    public partial class StudentLibrary : Form
    {
        public StudentLibrary()
        {
            InitializeComponent();
        }

        private Student aStudent;
        private void saveButton_Click(object sender, EventArgs e)
        {
            
                aStudent = new Student();
                Library aLibrary = new Library();

                aStudent.Name = studentNameTextBox.Text;
                aStudent.Id = studentIdTextBox.Text;
                aStudent.Department = studentDeptTextBox.Text;
                aStudent.LibrayAccount = aLibrary;
                aLibrary.BookNane = bookNameTextBox.Text;
                aLibrary.Isbn = bookIsbnTextBox.Text;
                aLibrary.AuthorName = aurtherNameTextBox.Text;
                aLibrary.BorrowDate = borrowDateTextBox.Text;
                aStudent.BorrowBook();
         
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
                List<string> StudentLibrary = new List<string>();
                StudentLibrary = aStudent.SearchBook(searchTextBox.Text);
                showListView.Clear();
                ListViewItem myView = new ListViewItem(StudentLibrary[0]);
                for (int i = 1; i < 4; i++)
                {
                    myView.SubItems.Add(StudentLibrary[i]);
                }
                showListView.Items.Add(myView);
           
        }
    }
}
