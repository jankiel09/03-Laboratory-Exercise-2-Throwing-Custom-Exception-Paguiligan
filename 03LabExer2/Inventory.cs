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

        public frmAddProduct()
        {

            InitializeComponent();
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
    }
    }

