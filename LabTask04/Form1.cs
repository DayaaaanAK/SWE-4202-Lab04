using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask04
{
    public partial class Form1 : Form
    {
        List<StudyBook> books = new List<StudyBook>();
        List<ReasearchArticle> reasearchArticles = new List<ReasearchArticle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddOnClick_StudyBook(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(S_BookID_Input.Text);
            int quantity = Convert.ToInt32(S_BookQuantity_Input.Text);
            string author = S_BookAuthor_Input.Text;
            string title = S_BookTitle_Input.Text;
            string publisher = S_BookPublisher_Input.Text;
            string isbn = S_BookISBN_Input.Text;
            string genre = S_BookGenre_Input.Text;

            StudyBook dummy_book = new StudyBook(id, quantity, title, publisher, author, isbn, genre);
            books.Add(dummy_book);
            MessageBox.Show("The book has been added successfully");

            S_BookAuthor_Input.Clear();
            S_BookTitle_Input.Clear();
            S_BookGenre_Input.Clear();
            S_BookISBN_Input.Clear();
            S_BookID_Input.Clear();
            S_BookQuantity_Input.Clear();
            S_BookPublisher_Input.Clear();
        }

        private void AddOnClick_Article(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Article_ID_Input.Text);
            int quantity = Convert.ToInt32(Article_Quantity_Input.Text);
            string author = Article_Author_Input.Text;
            string title = Article_Title_Input.Text;
            string publisher = Article_Publisher_Input.Text;
            string doi = Article_DOI_Input.Text;
            string date = Article_Date_Input.Text;
            string cj = Article_Type_Input.Text;

            ReasearchArticle dummy_article = new ReasearchArticle(id, quantity, title, publisher, author, doi, date, cj);
            reasearchArticles.Add(dummy_article);
            MessageBox.Show("The article has been added successfully");

            Article_Author_Input.Clear();
            Article_Title_Input.Clear();
            Article_Date_Input.Clear();
            Article_DOI_Input.Clear();
            Article_ID_Input.Clear();
            Article_Publisher_Input.Clear();
            Article_Quantity_Input.Clear();
            Article_Type_Input.Clear();
        }

        private void BorrowOnClick_Book(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Book_ID_Borrow.Text);

            foreach(StudyBook dummy in books)
            {
                if(id == dummy.getID())
                {
                    if (dummy.getQuantity() > 0)
                        dummy.decrease();
                    else MessageBox.Show("Error");
                }
            }
        }

        private void BorrowOnClick_Article(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Book_ID_Borrow.Text);

            foreach (ReasearchArticle dummy in reasearchArticles)
            {
                if (id == dummy.getID())
                {
                    if (dummy.getQuantity() > 0)
                        dummy.decrease();
                    else MessageBox.Show("Error");
                }
            }
        }

        private void ShowOnClick_Book(object sender, EventArgs e)
        {
            Book_List.Items.Clear();

            foreach(StudyBook dummy in books)
            {
                Book_List.Items.Add(dummy.getInfo_Book());
            }
        }

        private void ShowOnClick_Article(object sender, EventArgs e)
        {
            Article_List.Items.Clear();

            foreach (ReasearchArticle dummy in reasearchArticles)
            {
                Article_List.Items.Add(dummy.getInfo_Article());
            }
        }
    }
}
