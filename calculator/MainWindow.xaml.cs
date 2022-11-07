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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class Operation{
        public Operation(){
            
        }
        private float Add(float num1, float num2)
        {      
            return num1+num2;

        }
        private float Div (float num1, float num2)
        {
            if(num2 == 0)
            {
                return float.NaN;
            }
            return num1 / num2;
        }
        private float Mod(float num1, float num2)
        {
            return num1 % num2;
        }
        private float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }
        private float Substraction(float num1, float num2)
        {
            return num1 - num2;
        }

        public float getResult(string op, float num1, float num2)
        {
            if (op == "Add")
            {
                return this.Add(num1, num2);
            }
            if(op == "Div")
            {
                return this.Div(num1, num2);
            }
            if (op == "Mod")
            {
                return this.Mod(num1, num2);
            }
            if (op == "Multiply")
            {
                return this.Multiplication(num1, num2);
            }
            if(op == "Substract")
            {
                return this.Substraction(num1, num2);
            }
            return 0;
        }
}

public partial class MainWindow : Window
    {
        private string operation;
        private bool buttonOperationOn = false;
        private bool start = false;
        float result;
        Operation getValue = new Operation();
        bool pointOn = false;
        
        public MainWindow()
        {
            InitializeComponent();
            numDisplay.Text = "0";
             
        }

        private string getDisplayValue()
        {

            string number = numDisplay.Text;
            return number;
        }

        private void click1(object sender, RoutedEventArgs e)
        {   
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "1";
            buttonOperationOn = false;
        }

        private void click2(object sender, RoutedEventArgs e)
        {
           
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "2";
            buttonOperationOn=false;
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "3";
            buttonOperationOn = false;
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "4";
            buttonOperationOn = false;
        }

        private void click5(object sender, RoutedEventArgs e)
        {
           
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "5";
            buttonOperationOn = false;
        }

        private void click6(object sender, RoutedEventArgs e)
        {
           
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "6";
            buttonOperationOn = false;
        }

        private void click7(object sender, RoutedEventArgs e)
        {
            
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "7";
            buttonOperationOn = false;
        }

        private void click8(object sender, RoutedEventArgs e)
        {
            
            if (getDisplayValue() == "0" || buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "8";
            buttonOperationOn = false;
        }

        private void click9(object sender, RoutedEventArgs e)
        {
            
            if (getDisplayValue() == "0"||buttonOperationOn) { numDisplay.Text = ""; }
            numDisplay.Text = getDisplayValue() + "9";
            buttonOperationOn = false;
        }

        private void click0(object sender, RoutedEventArgs e)
        {
            if (buttonOperationOn == true)
            {
                numDisplay.Text = "";
            }
            if (getDisplayValue() == "0")
            {
                numDisplay.Text = "0";
            }
            else
            {
                numDisplay.Text = getDisplayValue() + "0";
                buttonOperationOn = false;
            }
            
        }

        private void clickClear(object sender, RoutedEventArgs e)
        {
            result = 0;
            numDisplay.Text = "0";
            start = false;

        }

        private void clickAdd(object sender, RoutedEventArgs e)
        {
            operatingAndDisplayValue("Add");

        }

        private void clickMod(object sender, RoutedEventArgs e)
        {
            operatingAndDisplayValue("Mod");
        }

        private void clickMinus(object sender, RoutedEventArgs e)
        {
            if (Equals(getDisplayValue()[0].ToString(),"-"))
            {
                numDisplay.Text = getDisplayValue().Substring(1).ToString();
            }
            else
            {
                numDisplay.Text = "-" + getDisplayValue();

            }
        }

        private void clickDivide(object sender, RoutedEventArgs e)
        {
            operatingAndDisplayValue("Div");


        }
    

        private void clickTimes(object sender, RoutedEventArgs e)
        {
            operatingAndDisplayValue("Multiply");
        }

        private void clickSubstract(object sender, RoutedEventArgs e)
        {
            operatingAndDisplayValue("Substract");
        }

        private void clickEquals(object sender, RoutedEventArgs e)
        {
            result = getValue.getResult(operation, (float)result, float.Parse(getDisplayValue()));
            numDisplay.Text = result.ToString();
            start = false;
        }

        private void clickDel(object sender, RoutedEventArgs e)
        {
            numDisplay.Text = getDisplayValue().Substring(0,getDisplayValue().Length - 1).ToString();
            if(getDisplayValue().Length == 0)
            {
                numDisplay.Text = "0";
            }
        }

        private void clickPoint(object sender, RoutedEventArgs e)
        {
            if(pointOn == false)
            {
                numDisplay.Text = getDisplayValue() + ".";
                pointOn = true;
            }
            else
            {
                numDisplay.Text =  getDisplayValue().Substring(0, getDisplayValue().Length - 1);
                pointOn = false;
            }
        }

        private void operatingAndDisplayValue(string stringOperator)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = stringOperator;
                result = float.Parse(numDisplay.Text);
    }
            else
            {
                result = getValue.getResult(operation, (float)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = stringOperator;

            tesResult.Text = result.ToString();
            tesstart.Text = "start"+start.ToString();

            testOperation.Text = operation;
        }
    }
}

