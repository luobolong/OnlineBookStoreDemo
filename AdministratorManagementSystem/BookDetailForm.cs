using Helper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorManagementSystem
{
    public partial class BookDetailForm : Form
    {
        
        public BookDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDetail(FullBookModel book)
        {
            textBoxISBN.Text = book.ISBN;
            textBoxTitle.Text = book.Title;
            textBoxAuthor.Text = book.Author;
            textBoxPublisher.Text = book.Publisher;
            if (book.Publication_Date != null)
            {
                textBoxPublicationDate.Text = ((DateTime)book.Publication_Date).ToString("yyyy-MM-dd");
            }
            
            textBoxGenre.Text = book.Genre.ToString();
            textBoxRate.Text = book.Book_Rate.ToString();
            textBoxPrice.Text = book.Price.ToString();
            textBoxQuantity.Text = book.Quantity.ToString();
            textBoxIntroduction.Text = book.Introduction;
            textBoxIsOnSale.Text = book.Is_On_Sale ? "是" : "否";
        }

        // 解决闪屏问题
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
