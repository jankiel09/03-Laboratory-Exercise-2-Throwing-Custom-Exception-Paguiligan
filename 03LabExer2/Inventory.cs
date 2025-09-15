using System.Text.RegularExpressions;

namespace _03LabExer2
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = {
            "Beverages",
            "Bread/Bakery",
            "Canned/Jarred Goods",
            "Dairy",
            "Frozen Goods",
            "Meat",
            "Personal Care",
            "Other"
            };
            // Add categories to ComboBox using foreach
            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }
        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new ArgumentException("Product name must contain only letters.");
            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new ArgumentException("Quantity must be a positive integer.");
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new ArgumentException("Selling price must be a valid number.");
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }
    }
}

