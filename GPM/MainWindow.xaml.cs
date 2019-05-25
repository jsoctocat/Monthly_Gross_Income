using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace MTM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int day_counter = 1;

        int[] daily_gross = new int[32];
        int[] massages = new int[32];
        int[] cash = new int[32];
        int[] credit_card = new int[32];
        int[] ic_payout = new int[32];
        int[] house_payout = new int[32];
        float[] tips = new float[32];
        float[] house_tip_fee = new float[32];
        float[] total_ic_tip = new float[32];
        float[] total_ic_payout = new float[32];

        public MainWindow()
        {
            InitializeComponent();

            //initialize all arrays to zero
            Array.Clear(daily_gross, 0, daily_gross.Length);
            Array.Clear(massages, 0, massages.Length);
            Array.Clear(cash, 0, cash.Length);
            Array.Clear(credit_card, 0, credit_card.Length);
            Array.Clear(ic_payout, 0, ic_payout.Length);
            Array.Clear(house_payout, 0, house_payout.Length);
            Array.Clear(tips, 0, tips.Length);
            Array.Clear(house_tip_fee, 0, house_tip_fee.Length);
            Array.Clear(total_ic_tip, 0, total_ic_tip.Length);
            Array.Clear(total_ic_payout, 0, total_ic_payout.Length);
        }

        private void Previous_Day_Button_Click(object sender, EventArgs e)
        {
            if (day_counter > 1)
            {
                //reset current day data
                daily_gross[day_counter] = 0;
                massages[day_counter] = 0;
                cash[day_counter] = 0;
                credit_card[day_counter] = 0;
                ic_payout[day_counter] = 0;
                house_payout[day_counter] = 0;
                tips[day_counter] = 0;
                house_tip_fee[day_counter] = 0;
                total_ic_tip[day_counter] = 0;
                total_ic_payout[day_counter] = 0;

                day_counter--;
                //reset previous day data
                daily_gross[day_counter] = 0;
                massages[day_counter] = 0;
                cash[day_counter] = 0;
                credit_card[day_counter] = 0;
                ic_payout[day_counter] = 0;
                house_payout[day_counter] = 0;
                tips[day_counter] = 0;
                house_tip_fee[day_counter] = 0;
                total_ic_tip[day_counter] = 0;
                total_ic_payout[day_counter] = 0;

                //update to the previous date
                Day.Text = "Day " + Convert.ToString(day_counter);

                //output the day before previous data         
                Previous_Day_Output.Text = Convert.ToString(day_counter - 1);
                Daily_Gross_Output.Text = daily_gross[day_counter - 1].ToString();
                Massages_Output.Text = massages[day_counter - 1].ToString();
                Cash_Output.Text = cash[day_counter - 1].ToString();
                Credit_Card_Output.Text = credit_card[day_counter - 1].ToString();
                IC_Pay_Out_Output.Text = ic_payout[day_counter - 1].ToString();
                House_Pay_Out_Output.Text = house_payout[day_counter - 1].ToString();
                Tips_Output.Text = tips[day_counter - 1].ToString();
                House_Tip_Fee_Output.Text = house_tip_fee[day_counter - 1].ToString();
                Total_IC_Tip_Output.Text = total_ic_tip[day_counter - 1].ToString();
                Total_IC_Pay_Out_Output.Text = total_ic_payout[day_counter - 1].ToString();
            }
            else
            {
                Error_Output.Text = "Day of the month cannot go below 1";
            }
        }

        private void Next_Day_Button_Click(object sender, EventArgs e)
        {
            int massage_counter = 0;

            //cash calculation
            foreach (Control textbox in Cash_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox) && textbox != null)
                {
                    string resultString = Regex.Match(textbox.ToString(), @"\d+").Value;

                    if (String.IsNullOrEmpty(resultString) != true)
                    {
                        int result = Int32.Parse(resultString);
                        massage_counter++;

                        switch (result)
                        {
                            case 40:
                                cash[day_counter] += 40;
                                ic_payout[day_counter] += 10;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 50:
                                cash[day_counter] += 50;
                                ic_payout[day_counter] += 20;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 60:
                                cash[day_counter] += 60;
                                ic_payout[day_counter] += 20;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 70:
                                cash[day_counter] += 70;
                                ic_payout[day_counter] += 30;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 80:
                                cash[day_counter] += 80;
                                ic_payout[day_counter] += 30;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 90:
                                cash[day_counter] += 90;
                                ic_payout[day_counter] += 35;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 100:
                                cash[day_counter] += 100;
                                ic_payout[day_counter] += 40;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 110:
                                cash[day_counter] += 110;
                                ic_payout[day_counter] += 45;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 120:
                                cash[day_counter] += 120;
                                ic_payout[day_counter] += 50;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            case 140:
                                cash[day_counter] += 140;
                                ic_payout[day_counter] += 60;
                                house_payout[day_counter] += cash[day_counter] - ic_payout[day_counter];
                                break;
                            default:
                                Error_Output.Text = "error: one of the input(s) for cash amount  is wrong!";
                                break;
                        }
                    }
                }
            }

            //credit card calculation
            foreach (Control textbox in Credit_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox) && textbox != null)
                {
                    string resultString = Regex.Match(textbox.ToString(), @"\d+").Value;

                    if (String.IsNullOrEmpty(resultString) != true)
                    {
                        int result = Int32.Parse(resultString);
                        massage_counter++;

                        switch (result)
                        {
                            case 40:
                                credit_card[day_counter] += 40;
                                ic_payout[day_counter] += 10;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 50:
                                credit_card[day_counter] += 50;
                                ic_payout[day_counter] += 20;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 60:
                                credit_card[day_counter] += 60;
                                ic_payout[day_counter] += 20;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 70:
                                credit_card[day_counter] += 70;
                                ic_payout[day_counter] += 30;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 80:
                                credit_card[day_counter] += 80;
                                ic_payout[day_counter] += 30;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 90:
                                credit_card[day_counter] += 90;
                                ic_payout[day_counter] += 35;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 100:
                                credit_card[day_counter] += 100;
                                ic_payout[day_counter] += 40;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 110:
                                credit_card[day_counter] += 110;
                                ic_payout[day_counter] += 45;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 120:
                                credit_card[day_counter] += 120;
                                ic_payout[day_counter] += 50;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            case 140:
                                credit_card[day_counter] += 140;
                                ic_payout[day_counter] += 60;
                                house_payout[day_counter] += credit_card[day_counter] - ic_payout[day_counter];
                                break;
                            default:
                                Error_Output.Text = "error: one of the input(s) for credit amount is wrong!";
                                break;
                        }
                    }
                }
            }

            //tips calculation
            foreach (Control textbox in Tip_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox) && textbox != null)
                {
                    string resultString = Regex.Match(textbox.ToString(), @"\d+").Value;

                    if (String.IsNullOrEmpty(resultString) != true)
                    {
                        float result = float.Parse(resultString);

                        tips[day_counter] += result;
                    }
                }
            }

            //calculations & saving data
            daily_gross[day_counter] = cash[day_counter] + credit_card[day_counter];
            massages[day_counter] = massage_counter;
            house_tip_fee[day_counter] = tips[day_counter] * 0.1f;
            total_ic_tip[day_counter] = tips[day_counter] * 0.9f;
            total_ic_payout[day_counter] = ic_payout[day_counter] + total_ic_tip[day_counter];


            //output previous data
            Previous_Day_Output.Text = Convert.ToString(day_counter);
            Daily_Gross_Output.Text = daily_gross[day_counter].ToString();
            Massages_Output.Text = massages[day_counter].ToString();
            Cash_Output.Text = cash[day_counter].ToString();
            Credit_Card_Output.Text = credit_card[day_counter].ToString();
            IC_Pay_Out_Output.Text = ic_payout[day_counter].ToString();
            House_Pay_Out_Output.Text = house_payout[day_counter].ToString();
            Tips_Output.Text = tips[day_counter].ToString();
            House_Tip_Fee_Output.Text = house_tip_fee[day_counter].ToString();
            Total_IC_Tip_Output.Text = total_ic_tip[day_counter].ToString();
            Total_IC_Pay_Out_Output.Text = total_ic_payout[day_counter].ToString();
            day_counter++;

            //update to the next date
            Day.Text = "Day " + Convert.ToString(day_counter);
            //Error_Output.Text = daily_gross[day_counter].ToString();

            //clear text boxes
            foreach (Control textbox in Cash_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox))
                    ((TextBox)textbox).Clear();
            }
            foreach (Control textbox in Credit_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox))
                    ((TextBox)textbox).Clear();
            }
            foreach (Control textbox in Tip_Panel.Children)
            {
                if (textbox.GetType() == typeof(TextBox))
                    ((TextBox)textbox).Clear();
            }
        }

        private void Output_Data_Button_Click(object sender, EventArgs e)
        {
            string current_running_directory = System.AppDomain.CurrentDomain.BaseDirectory;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(current_running_directory + Month.Text +".txt", true))
            {
                file.WriteLine("Name: " + Name.Text);
                for (int counter = 1; counter < 32; counter++)
                {
                    file.WriteLine("Daily Gross: {0,5}\t # of Massages: {1,5}\t Cash: {2,5}\t Credit Card: {3,5}\t IC Massage Pay Out: {4,5}\t House Massage Pay Out: {5,5}\t IC Tips: {6,5}\t House Tip Fee: {7,5}\t Total IC Tip: {8,5}\t Total IC Pay Out: {9,5}", 
                        daily_gross[counter], massages[counter], cash[counter], credit_card[counter], ic_payout[counter],
                        house_payout[counter], tips[counter], house_tip_fee[counter], total_ic_tip[counter], total_ic_payout[counter]);
                }
            }
        }

        private void TB_Cash_1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    TB_Credit_1.Focus();
                    e.Handled = true;
                    break;
                case Key.S:
                    TB_Credit_2.Focus();
                    e.Handled = true;
                    break;
                case Key.A:
                    TB_Credit_3.Focus();
                    e.Handled = true;
                    break;
                case Key.D:
                    TB_Credit_4.Focus();
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }


    }
}

/*
\d+ is the regex for an integer number. So

require this library: System.Text.RegularExpressions.Regex
resultString = Regex.Match(subjectString, @"\d+").Value;
returns a string containing the first occurrence of a number in subjectString.

Int32.Parse(resultString) will then give you the number.
*/