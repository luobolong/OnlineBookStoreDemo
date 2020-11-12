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
    public partial class BookUnstockedDetailForm : Form
    {
        public BookUnstockedDetailForm()
        {
            InitializeComponent();
        }

        public void ShowNewBookDetail(SupplyNewBookInfoModel new_book)
        {
            textBoxISBN.Text = new_book.Book_ISBN;
            textBoxTitle.Text = new_book.Book_Title;
            textBoxAuthor.Text = new_book.Book_Author;
            textBoxPublisher.Text = new_book.Book_Publisher;
            if (new_book.Publication_Date != null)
            {
                textBoxPublicationDate.Text = ((DateTime)new_book.Publication_Date).ToString("yyyy-MM-dd");
            }
            textBoxGenre.Text = new_book.Genre.ToString();
            textBoxPrice.Text = new_book.Book_Price.ToString();
            textBoxAmount.Text = new_book.Supplier_Order.Amount.ToString();
            textBoxIntroduction.Text = new_book.Introduction;
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
