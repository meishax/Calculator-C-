using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();
        }

        //清除输入行与输出行
        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textAns.Text = "";

        }
        
        //输入行
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //分析行（输出行）
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //输入7
        private void button14_Click(object sender, EventArgs e)
        {
            textInput.Text += "7";
        }

        //输入1
        private void button8_Click(object sender, EventArgs e)
        {
            textInput.Text += "1";
        }

        //输入0
        private void button17_Click(object sender, EventArgs e)
        {
            textInput.Text += "0";
        }
 
        //输入2
        private void button9_Click(object sender, EventArgs e)
        {
            textInput.Text += "2";
        }

        //输入3
        private void button10_Click(object sender, EventArgs e)
        {
            textInput.Text += "3";
        }

        //输入4
        private void button11_Click(object sender, EventArgs e)
        {
            textInput.Text += "4";
        }

        //输入5
        private void button12_Click(object sender, EventArgs e)
        {
            textInput.Text += "5";
        }

        //输入6
        private void button13_Click(object sender, EventArgs e)
        {
            textInput.Text += "6";
        }

        //输入8
        private void button15_Click(object sender, EventArgs e)
        {
            textInput.Text += "8";
        }

        //输入9
        private void button16_Click(object sender, EventArgs e)
        {
            textInput.Text += "9";
        }

        //加法运算
        private void button3_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%" && str != "/")
                    textInput.Text += "+";
            }
        }

        //减法运算
        private void button4_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                    textInput.Text += "-";
            }

        }

        //取模（取余）运算
        private void button7_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                    textInput.Text += "%";
            }
        }

        //乘法运算
        private void button5_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                    textInput.Text += "*";
            }
        }

        //开平方
        private void button6_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length == 0)
                textInput.Text += "√";
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "√")
                    textInput.Text += "√";
            }
        }

        //除法运算
        private void button2_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                    textInput.Text += "/";
            }
        }

        //退格（将输入行删除一个）
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
                textInput.Text = textInput.Text.Substring(0, textInput.Text.Length - 1);
        }

        //输入小数点（.）
        private void button18_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length == 0)
                textInput.Text += "0.";
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                {
                    textInput.Text += ".";
                }
                if (str == "+" || str == "-" || str == "*" || str == "/" || str == "%")
                {
                    textInput.Text += "0.";
                }
            }
        }

        //输入右括号
        private void button20_Click(object sender, EventArgs e)
        {
            textInput.Text += ")";
        }

        //在输入行与输出行显示制作者姓名
        private void button23_Click(object sender, EventArgs e)
        {
            textInput.Text = "郭子杨";
            textAns.Text = "郭子杨";
        }

        //输入一个左括号
        private void button21_Click(object sender, EventArgs e)
        {
            textInput.Text += "(";
        }

        //取模（取余）
        private void button24_Click(object sender, EventArgs e)
        {
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str != "+" && str != "-" && str != "*" && str != "/" && str != "%")
                    textInput.Text += "%";
            }
        }

        //栈外优先数
        static int icp(char ch)
        {
            switch (ch)
            {
                case '#':
                    return 0;
                case '(':
                    return 10;
                case '+':
                case '-':
                    return 2;
                case '*':
                case '/':
                case '%':
                    return 4;
                case '√':
                case 't':
                case 's':
                case 'c':
                case 'L':
                case '^':
                    return 8;
                case ')':
                    return 1;
            }
            return -1;
        }
        //栈内优先数
        static int isp(char ch)
        {
            switch (ch)
            {
                case '#':
                    return 0;
                case '(':
                    return 1;
                case '+':
                case '-':
                    return 3;
                case '*':
                case '/':
                case '%':
                    return 5;
                case '√':
                case 't':
                case 's':
                case 'c':
                case 'L':
                case '^':
                    return 9;
                case ')':
                    return 10;
            }
            return -1;
        }
        //判断操作符
        static bool isOperator(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '%':
                case '(':
                case ')':
                case '√':
                case 't':
                case 's':
                case 'c':
                case 'L':
                case '^':
                    return true;
                default:
                    return false;
            }
        }
        //中缀转后缀
        static void postfix(string e, char[] post)
        {
            int i = 0;
            int j = 0;
            Stack<char> st = new Stack<char>();
            st.Push('#');                                           //将‘#’结束标识符塞入栈底    
            while (e[i] != '#')
            {
                if ((e[i] >= '0' && e[i] <= '9') || e[i] == '.')    //遇到数字和小数点直接写入后缀表达式
                {
                    post[j++] = e[i];
                }
                else if (isOperator(e[i]))
                {
                    post[j++] = ' ';                                // 用空格分开操作数
                    while (isp(st.Peek()) > icp(e[i]))
                    {
                        post[j++] = st.Pop();
                    }
                    if (isp(st.Peek()) == icp(e[i]))
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(e[i]);
                    }
                }
                i++;
            }
            while (!st.Count().Equals(0))                                       // 将所有的操作符加入后缀表达式  
            {
                post[j++] = st.Pop();
            }

        }
        //获取数字
        static double readNumber(char[] str, ref int i)
        {
            double x = 0.0;                                                     //用于返回数字
            int k = 0;                                                          //有小数时，用于确定除以10的个数
            while (str[i] >= '0' && str[i] <= '9')
            {
                x = x * 10 + (str[i] - '0');
                i++;
            }
            if (str[i] == '.')
            {
                i++;
                while (str[i] >= '0' && str[i] <= '9')
                {
                    x = x * 10 + (str[i] - '0');
                    k++;
                    i++;
                }
            }
            while (k != 0)
            {
                x /= 10;
                k--;
            }
            return x;
        }
        //计算
        static double postfixValue(char[] post)
        {
            Stack<double> num = new Stack<double>();
            int i = 0;
            double x1, x2;                                                        //两个操作数

            while (post[i] != '#')
            {
                if (post[i] >= '0' && post[i] <= '9')
                    num.Push(readNumber(post, ref i));
                else if (post[i] == ' ')
                    i++;
                else if (post[i] == '+')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    num.Push(x1 + x2);
                    i++;
                }
                else if (post[i] == '-')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    num.Push(x1 - x2);
                    i++;
                }
                else if (post[i] == '*')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    num.Push(x1 * x2);
                    i++;
                }
                else if (post[i] == '/')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    try
                    {
                        if (x2 == 0) throw new System.DivideByZeroException();
                        num.Push(x1 / x2);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("被除数不能为0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                    i++;
                }
                else if (post[i] == '%')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    try
                    {
                        if (x2 == 0) throw new System.DivideByZeroException();
                        num.Push(x1 % x2);
                    }
                    catch (DivideByZeroException e)
                    {
                        MessageBox.Show("被除数不能为0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    i++;
                }
                else if (post[i] == '^')
                {
                    x2 = num.Pop();
                    x1 = num.Pop();
                    num.Push(Math.Pow(x1, x2));
                    i++;
                }
                else if (post[i] == 'L')
                {
                    x1 = num.Pop();
                    num.Push(Math.Log(x1));
                    i++;
                }
                else if (post[i] == 'c')
                {
                    x1 = num.Pop();
                    num.Push(Math.Cos(x1));
                    i++;
                }
                else if (post[i] == 't')
                {
                    x1 = num.Pop();
                    num.Push(Math.Tan(x1));
                    i++;
                }
                else if (post[i] == 's')
                {
                    x1 = num.Pop();
                    num.Push(Math.Sin(x1));
                    i++;
                }
                else if (post[i] == '√')
                {
                    x1 = num.Pop();
                    try
                    {
                        if (x1 < 0) throw new System.DivideByZeroException();
                        num.Push(Math.Pow(x1, 0.5));
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("请输入正数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }

                    i++;
                }
                else
                {
                    MessageBox.Show("请仔细检查表达式，如：括号对应等", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }
            try
            {
                return num.Peek();
            }
            catch (Exception)
            {
                MessageBox.Show("请仔细检查表达式，如：括号对应等", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        //等于（求结果）
        private void button19_Click(object sender, EventArgs e)
        {
            //计算

            char[] post = new char[100];
            if (textInput.Text.Length > 0)
            {
                string str = textInput.Text.Substring(textInput.Text.Length - 1);
                if (str == "+" || str == "-" || str == "*" || str == "/" || str == "(" || str == "%" || str == "√" || str == "t" || str == "s" || str == "c" || str == "L" || str == "^")
                    textInput.Text = textInput.Text.Substring(0, textInput.Text.Length - 1);
            }
            string s = textInput.Text;
            postfix(s + '#', post);
            textAns.Text = postfixValue(post).ToString();

        }

        //求1/x
        private void button22_Click(object sender, EventArgs e)
        {
            textInput.Text += "1/";
        }
        //求tan
        private void button24_Click_1(object sender, EventArgs e)
        {
            textInput.Text += "t";
        }
        //求sin
        private void button25_Click(object sender, EventArgs e)
        {
            textInput.Text += "s";
        }
        //求cos
        private void button26_Click(object sender, EventArgs e)
        {
            textInput.Text += "c";
        }
        //求ln
        private void button27_Click(object sender, EventArgs e)
        {
            textInput.Text += "L";
        }
        //求次方
        private void button28_Click(object sender, EventArgs e)
        {
            textInput.Text += "^";
        }

        private void Form1_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
