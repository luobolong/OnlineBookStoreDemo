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
    public partial class BookAdderForm : Form
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

        public BookAdderForm()
        {
            InitializeComponent();
            GetGenres();
            InitializeComboBoxGenre();
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
            _quantity = int.Parse(textBoxQuantity.Text);
            _introduction = textBoxIntroduction.Text;
            _isIntroductionNull = textBoxIntroduction.Text.Length == 0 ? true : false;
            _is_on_sale = checkBoxIsOnSale.Checked;
        }

        private bool CheckValues()
        {
            if (_isbn.Length <= 20 && _isbn.Length > 0 &&
                _title.Length <= 200 && _title.Length > 0 &&
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
            textBoxISBN.Text = "";
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxIntroduction.Text = "";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SetValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (CheckValues())
            {
                try
                {
                    if (BookDataAccess.IsBookExisted(_isbn))
                    {
                        MessageBox.Show("无法添加，图书已存在");
                        return;
                    }
                    BookDataAccess.InsertBook(_isbn, _title, _price, _author, _publisher, _genre, _quantity, _publicationDate, _introduction, _is_on_sale, _isAuthorNull, _isPublisherNull, _isPublicationDateNull, _isIntroductionNull);
                    MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("输入内容不符合规范");
            }
        }

        private void BookAdderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
