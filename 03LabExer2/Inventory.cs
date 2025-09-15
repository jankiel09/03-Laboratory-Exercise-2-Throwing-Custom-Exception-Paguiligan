using System;
using System.Text.RegularExpressions;

namespace _03LabExer2
{
    public partial class frmAddProduct : Form
    {
        //priv variables
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        // for dataGridView
        private BindingSource showProductList;
        public frmAddProduct()
        {
            InitializeComponent();
            //instantiate binding source
            showProductList = new BindingSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            //array for product categories
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

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class InputFormatException : Exception
        {
            public InputFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }

        private string Product_Name(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new InputFormatException("Product name cannot be empty or only contain a whitespace.");
                }
                if (name.Length < 3)
                {
                    throw new InputFormatException("Product name must be at least 3 characters long.");
                }
                return name.Trim();
            }

            catch (InputFormatException ex)
            {
                MessageBox.Show("String Format Error: " + ex.Message, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw; //re-throw 
            }

            finally
            {
                Console.WriteLine("Product Name Validation completed.");
            }

        }
        private int Quantity(string quantity)
        {
            int qty;

            try
            {
                if (string.IsNullOrWhiteSpace(quantity))
                {
                    throw new NumberFormatException("Quantity cannot be empty.");
                }

                if (!int.TryParse(quantity, out qty))
                {
                    throw new NumberFormatException("Quantity must be a valid integer.");
                }

                if (qty <= 0)
                {
                    throw new NumberFormatException("Quantity must be greater than zero.");
                }
                return qty;
            }

            catch (NumberFormatException ex)
            {
                MessageBox.Show("Number Format Error: " + ex.Message, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw; // Re-throw
            }

            finally
            {
                Console.WriteLine("Quantity Validation completed.");
            }
        }

        private double SellingPrice(string price)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(price))
                {
                    throw new CurrencyFormatException("Selling price cannot be empty.");
                }

                double sellPrice;
                if (!double.TryParse(price, out sellPrice))
                {
                    throw new CurrencyFormatException("Selling price must be a valid decimal number.");
                }

                if (sellPrice <= 0)
                {
                    throw new CurrencyFormatException("Selling price must be greater than zero.");
                }
                return sellPrice;
            }

            catch (CurrencyFormatException ex)
            {
                MessageBox.Show("Currency Format Error: " + ex.Message, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw; // Re-throw
            }

            finally
            {
                Console.WriteLine("Selling price validation completed.");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                // validation for category selection
                if (string.IsNullOrEmpty(_Category))
                {
                    throw new InputFormatException("Please select a category.");
                }

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                    _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;

                //helper method to clear form
                ClearForm();

                MessageBox.Show("Product added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InputFormatException ex)
            {
                Console.WriteLine("String format error occurred: " + ex.Message);
            }
            catch (NumberFormatException ex)
            {
                Console.WriteLine("Number format error occurred: " + ex.Message);
            }
            catch (CurrencyFormatException ex)
            {
                Console.WriteLine("Currency format error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                // any unexpected exceptions
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Add product operation completed.");
            }
        }

        // Automatic na na cclear yung form after input :>
        private void ClearForm()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            txtSellPrice.Clear();
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now.AddDays(30);
            richTxtDescription.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }//partial class
} //namespace
    


