using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Parts_Entry
{
    public partial class Form1 : Form
        
    {
        public PartNumber partItem = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Part Number = {partNumberTextBox.Text}");
                sb.AppendLine($"Part Description = {partDescriptionTextBox.Text}");
                sb.AppendLine($"Item Class = {itemClassComboBox.Text}");
                sb.AppendLine($"Units On Hand = {unitsOnHandTextBox.Text}");
                sb.AppendLine($"Unit Price = {unitPriceTextBox.Text:C}");
                sb.AppendLine($"Total Cost = {totalInventoryCostTextBox.Text:C}");
                sb.AppendLine($"Lead Time = {leadTimeTextBox.Text}");
                sb.AppendLine($"Daily Usage = {dailyUsageTextBox.Text}");
                sb.AppendLine($"Reorder Point = {reorderPointTextBox.Text}");
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("Please correct entry errors.", "Entry Errors",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            partNumberTextBox.Clear();
            partDescriptionTextBox.Clear();
            itemClassComboBox.Items.Clear();
            unitsOnHandTextBox.Clear();
            unitPriceTextBox.Clear();
            totalInventoryCostTextBox.Clear();
            leadTimeTextBox.Clear();
            dailyUsageTextBox.Clear();
            reorderPointTextBox.Clear();
            partNumberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (partNumberTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partNumberTextBox, "Part Number is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partNumberTextBox, "");
                e.Cancel = false;
            }
        }

        private void partDescriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (partDescriptionTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partDescriptionTextBox, "Part Description is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partDescriptionTextBox, "");
                e.Cancel = false;
            }
        }

        private void itemClassComboBox_Validating(object sender, CancelEventArgs e)
        {
            string itemClass = itemClassComboBox.Text;
            if (itemClass.Length > -1)
            {
                errorProvider.SetError(itemClassComboBox, "Item Class is required.");
                e.Cancel = true;
            }
            else if (!(itemClass == "AP" || itemClass == "HW" || itemClass == "SG"))
            {
                errorProvider.SetError(itemClassComboBox, "Invalid Item Class.  Valid values (AP, HW, SG)");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(itemClassComboBox, "");
                e.Cancel = false;
            }
        }

        private void unitsOnHandTextBox_Validating(object sender, CancelEventArgs e)
        {
            double unitPrice;
            double unitsOnHand;
            if (ValidateNumericTextBoxes<double>(unitsOnHandTextBox, "Units On Hand", out unitsOnHand, e))
            {
                if (double.TryParse(unitPriceTextBox.Text, out unitPrice))
                    this.totalInventoryCostTextBox.Text = (unitPrice * unitsOnHand).ToString("C");
            }
        }

        private void unitPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            double unitPrice;
            double unitsOnHand;
            if (ValidateNumericTextBoxes<double>(unitPriceTextBox, "Unit Price", out unitPrice, e))
            {
                if (double.TryParse(unitsOnHandTextBox.Text, out unitsOnHand))
                    this.totalInventoryCostTextBox.Text = (unitPrice * unitsOnHand).ToString("C");
            }
        }

        private void leadTimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            int leadTimeInDays = 0;
            int dailyUsage = 0;
            if (ValidateNumericTextBoxes<int>(leadTimeTextBox, "Lead Time in Days", out leadTimeInDays, e))
            {
                if (int.TryParse(dailyUsageTextBox.Text, out dailyUsage))
                    this.reorderPointTextBox.Text = Convert.ToString(leadTimeInDays * dailyUsage);
            }
        }

        private void dailyUsageTextBox_Validating(object sender, CancelEventArgs e)
        {
            int dailyUsage = 0;
            int leadTimeInDays = 0;
            if (ValidateNumericTextBoxes(dailyUsageTextBox, "Daily Usage", out dailyUsage, e))
            {
                if (int.TryParse(leadTimeTextBox.Text, out leadTimeInDays))
                    this.reorderPointTextBox.Text = Convert.ToString(dailyUsage * leadTimeInDays);
            }
        }

        private bool ValidateNumericTextBoxes<T>(TextBox textBox, string fieldIdentifier, out T outValue, CancelEventArgs e)
        {
            string message;
            outValue = default;

            bool valid = Utility.ValidateIsNumeric<T>(textBox.Text, fieldIdentifier, out message, out outValue);
            errorProvider.SetError(textBox, message);
            e.Cancel = !valid;

            return valid;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            itemClassComboBox.DataSource = Enum.GetValues(typeof(ItemClass));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell.RowIndex < partNumberList.Count)
                {
                    itemClassComboBox.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
            }
        }

    }
}


