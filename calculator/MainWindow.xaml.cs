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
        private int Add(int num1, int num2)
        {      
            return num1+num2;

        }
        private float Div (int num1, int num2)
        {
            return num1 / num2;
        }
        private float Mod(int num1, int num2)
        {
            return num1 % num2;
        }
        private float Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        private float Substraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public float getResult(string op, int num1, int num2)
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
        private string operationHappened;
        private string firstNum;
        private bool buttonOperationOn = false;
        private bool start = false;
        float result;
        Operation getValue = new Operation();
        
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
            numDisplay.Text = getDisplayValue() + "0";
            buttonOperationOn = false;
        }

        private void clickClear(object sender, RoutedEventArgs e)
        {
            btnEquals.IsEnabled = true;
            numDisplay.Text = "0";

        }

        private void clickAdd(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Add";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Add";
            
            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();
            
            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;


        }

        private void clickMod(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Add";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Mod";

            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();

            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;
        }

        private void clickMinus(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Substract";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Substract";

            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();

            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;
        }

        private void clickDivide(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Div";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Div";

            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();

            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;


        }
    

        private void clickTimes(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Multiply";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Multiply";

            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();

            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;
        }

        private void clickSubstract(object sender, RoutedEventArgs e)
        {
            buttonOperationOn = true;
            if (start == false)
            {
                operation = "Substract";
                result = int.Parse(numDisplay.Text);
            }
            else
            {
                result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            }
            numDisplay.Text = result.ToString();
            start = true;
            operation = "Substract";

            tesResult.Text = result.ToString();
            tesstart.Text = start.ToString();

            testOperation.Text = operation;
            testOperation_Copy.Text = operationHappened;
        }

        private void clickEquals(object sender, RoutedEventArgs e)
        {
            result = getValue.getResult(operation, (int)result, int.Parse(getDisplayValue()));
            numDisplay.Text = result.ToString();
        }

        private void clickDel(object sender, RoutedEventArgs e)
        {

        }

        private void clickPoint(object sender, RoutedEventArgs e)
        {

        }
    }
}
