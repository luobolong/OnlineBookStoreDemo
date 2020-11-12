using Helper.DataAccess;
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
    public partial class BookEditorForm : Form
    {
        private string _isbn { get; set; }
        private string _title { get; set; }
        private string _author { get; set; }
        private string _publisher { get; set; }
        private DateTime? _publicationDate { get; set; }
        private GenreModel _genre { get; set; }
        private decimal _price { get; set; }
        private int _quantity { get; set; }
        private string _introduction { get; set; }
        private bool _is_on_sale { get; set; }
        
        private bool _isAuthorNull { get; set; }
        private bool _isPublisherNull { get; set; }
        private bool _isPublicationDateNull { get; set; }
        private bool _isIntroductionNull { get; set; }

        private List<GenreModel> _genres { get; set; }

        public BookEditorForm()
        {
            InitializeComponent();
            GetGenres();
        }

        public void GetValues(FullBookModel book)
        {
            _isbn = book.ISBN;
            _title = book.Title;
            _author = book.Author;
            _publisher = book.Publisher;
            _publicationDate = book.Publication_Date;
            _genre = book.Genre;
            _price = book.Price;
            _quantity = book.Quantity;
            _introduction = book.Introduction;
            _is_on_sale = book.Is_On_Sale;
        }

        private void GetGenres()
        {
            _genres = GenreDataAccess.GetAllGenres();
        }

        private void InitializeComponentValues()
        {
            textBoxISBN.Text = _isbn;
            textBoxTitle.Text = _title;
            textBoxAuthor.Text = _author;
            textBoxPublisher.Text = _publisher;
            if (_publicationDate != null)
            {
                dateTimePickerPublicationDate.Value = (DateTime)_publicationDate;
            }
            comboBoxGenre.Items.AddRange(_genres.ToArray());
            comboBoxGenre.SelectedItem = _genre;
            comboBoxGenre.Text = _genre.ToString();
            textBoxPrice.Text = _price.ToString();
            textBoxQuantity.Text = _quantity.ToString();
            textBoxIntroduction.Text = _introduction;
            checkBoxIsOnSale.Checked = _is_on_sale;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            InitializeComponentValues();
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
            _quantity = Int32.Parse(textBoxQuantity.Text);
            _introduction = textBoxIntroduction.Text;
            _isIntroductionNull = textBoxIntroduction.Text.Length == 0 ? true : false;
            _is_on_sale = checkBoxIsOnSale.Checked;
        }

        private bool CheckValues()
        {
            if (_title.Length <= 200 && _title.Length > 0 &&
                _author.Length <= 200 &&
                _publisher.Length <= 200 &&
                _genre != null &&
                _price > 0 &&
                _quantity > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxIntroduction.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
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
                    BookDataAccess.UpdateBook(_isbn, _title, _price, _author, _publisher, _genre, _quantity, _publicationDate, _introduction, _is_on_sale, _isAuthorNull, _isPublisherNull, _isPublicationDateNull, _isIntroductionNull);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改内容不符合规范");
            }
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
