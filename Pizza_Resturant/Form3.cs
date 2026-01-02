using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Resturant
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                Size.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                Size.Text = "Medium";
                return;
            }

            if (rbLarg.Checked)
            {
                Size.Text = "Large";
                return;
            }
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";
            if (chbExtraChees.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chbGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (chbOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chbMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chbOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chbTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == " ")
            {
                sToppings = "No Toppings";
            }
            Toppings.Text = sToppings;
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbCrustThin.Checked)
            {
                CrustType.Text = "Thin Crust";
                return;
            }
            if (rbCrustThick.Checked)
            {
                CrustType.Text = "Thick Crust";
                return;
            }
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                WhereToEat.Text = "Eat In.";
                return;
            }
            if (rbTakeOut.Checked)
            {
                WhereToEat.Text = "Take Out.";
                return;
            }
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            else 
            {
                return Convert.ToSingle(rbLarg.Tag);

            }

        }
        float CalculateToppingsPrice ()
        {
            float ToppingsTotalPrice = 0;
            if (chbGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbGreenPeppers.Tag);
            }
            if (chbExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbExtraChees.Tag);
            }
            if (chbOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbMushrooms.Tag);
            }

            if (chbOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbTomatoes.Tag);
            }

            return ToppingsTotalPrice;

        }
        float GetSelectedCrustPrice()
        {
            if (rbCrustThin.Checked)
            {
                return Convert.ToSingle(rbCrustThin.Tag);
            }
            else 

            {
                return Convert.ToSingle(rbCrustThick.Tag);
            }
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
        void  UpdateTotalPrice()
        {
            TotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        } 
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        void ResetForm()
        {

            btnOrderPizza.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWherToEat.Enabled = true;
            grCrustType.Enabled = true;

            rbMeduim.Checked = true;

            rbCrustThin.Checked = true;
            rbEatIn.Checked = true;

            chbExtraChees.Checked = false;
            chbGreenPeppers.Checked = false;
            chbMushrooms.Checked = false;
            chbOlives.Checked = false;
            chbOnion.Checked = false;
            chbTomatoes.Checked = false;
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                grCrustType.Enabled = false;
                gbWherToEat.Enabled = false;
            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void rbSmall_CheckedChanged(object sender, EventArgs e)                                                                                                                                                                                                               
        {
            if (rbSmall.Checked)
            {
                UpdateSize();
            }
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMeduim.Checked)
            {
                UpdateSize();
            }
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarg.Checked)
            {
                UpdateSize();
            }
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if(chbExtraChees.Checked)
            {
                UpdateToppings();
            }
        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMushrooms.Checked)
            {
                UpdateToppings();
            }
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTomatoes.Checked)
            {
                UpdateToppings();
            }
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnion.Checked)
            {
                UpdateToppings();
            }
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOlives.Checked)
            {
                UpdateToppings();
            }
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGreenPeppers.Checked)
            {
                UpdateToppings();
            }
        }

        private void rbCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCrustThin.Checked)
            {
                UpdateCrust();
            }
        }

        private void rbCrustThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCrustThick.Checked)
            {
                UpdateCrust();
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }
        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

    }
}
