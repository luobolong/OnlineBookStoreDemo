using Helper.Models;
using Helper.DataAccess;
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
    public partial class NewBookForm : Form
    {
        private int _amount { get; set; }
        private string _isbn { get; set; }
        private string _title { get; set; }
        private string _author { get; set; }
        private string _publisher { get; set; }
        private DateTime? _publicationDate { get; set; }
        private GenreModel _genre { get; set; }
        private decimal _price { get; set; }
        private string _introduction { get; set; }

        private bool _isAuthorNull { get; set; }
        private bool _isPublisherNull { get; set; }
        private bool _isPublicationDateNull { get; set; }
        private bool _isIntroductionNull { get; set; }

        private List<GenreModel> _genres { get; set; }

        public NewBookForm()
        {
            InitializeComponent();
            GetGenres();
            InitializeComboBoxGenre();
        }

        public void GetInfo(string isbn, int amount)
        {
            _isbn = isbn;
            _amount = amount;
            textBoxISBN.Text = _isbn;
        }

        private void GetGenres()
        {
            _genres = GenreDataAccess.GetAllGenres();
        }

        private void InitializeComboBoxGenre()
        {
            GetGenres();
            comboBoxGenre.Items.AddRange(_genres.ToArray());
            comboBoxGenre.SelectedIndex = -1;
        }

        private void SetValues()
        {
            _isbn = textBoxISBN.Text;
            _title = textBoxTitle.Text;
            _author = textBoxAuthor.Text;
            _isAuthorNull = textBoxAuthor.Text.Length == 0 ? true : false;
            _publisher = textBoxPublisher.Text;
            _isPublisherNull = textBoxPublisher.Text.Length == 0 ? true : false;
            _publicationDate = dateTimePickerPublicationDate.Value;
            _isPublicationDateNull = checkBoxIsNullDate.Checked;
            _genre = (GenreModel)comboBoxGenre.SelectedItem;
            _price = decimal.Parse(textBoxPrice.Text);
            _introduction = textBoxIntroduction.Text;
            _isIntroductionNull = textBoxIntroduction.Text.Length == 0 ? true : false;
        }

        private bool CheckValues()
        {
            if (_isbn.Length <= 20 && _isbn.Length > 0 &&
                _title.Length <= 200 && _title.Length > 0 &&
                _author.Length <= 200 &&
                _publisher.Length <= 200 &&
                _genre != null &&
                _price > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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


        private void Form_Resize(object sender, EventArgs e)
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

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                SetValues();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (CheckValues())
            {
                try
                {
                    NewBookInfoOfSupplierOrderDataAccess.InsertNewBook(SupplierInfo.supplier.Id, DateTime.Now, _amount, _isbn, _title, _price, _author, _publisher, _genre.Clc, _publicationDate, _introduction, _isAuthorNull, _isPublisherNull, _isPublicationDateNull, _isIntroductionNull);
                    MessageBox.Show("发货成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }
    }
}
