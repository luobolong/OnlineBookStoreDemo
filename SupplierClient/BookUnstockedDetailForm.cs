using Helper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierClient
{
    public partial class BookUnstockedDetailForm : Form
    {
        public BookUnstockedDetailForm()
        {
            InitializeComponent();
        }

        public void ShowNewBookDetail(SupplyNewBookInfoModel book)
        {
            textBoxISBN.Text = book.Book_ISBN;
            textBoxTitle.Text = book.Book_Title;
            textBoxAuthor.Text = book.Book_Author;
            textBoxPublisher.Text = book.Book_Publisher;
            if (book.Publication_Date != null)
            {
                textBoxPublicationDate.Text = ((DateTime)book.Publication_Date).ToString("yyyy-MM-dd");
            }
            textBoxGenre.Text = book.Genre.ToString();
            textBoxPrice.Text = book.Book_Price.ToString();
            textBoxIntroduction.Text = book.Introduction;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void ReviewsOfBookForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
