﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    enum CalcState
    {
        Zero,
        AccumulateDigit,
        Compute,
        Compute2,
        Result,
       
    }

   public delegate void MyDelegate(string text);

   public class Brain
    {
        MyDelegate displayMsg;
        CalcState calcState = CalcState.Zero;
        string tempNumber;
        string resultNumber;
        string operation;

        public Brain(MyDelegate displayMsg)
        {
            this.displayMsg = displayMsg;
            tempNumber = "";
            resultNumber = "";
            operation = "";
        }

        public void Process(string msg)
        {
            switch (calcState)
            {
                case CalcState.Zero:
                    Zero(false, msg);
                    break;
                case CalcState.AccumulateDigit:
                    AccumulateDigit(false, msg);
                    break;
                case CalcState.Compute:
                    Compute(false, msg);
                    break;
                case CalcState.Compute2:
                    Compute2(false, msg);
                    break;
                case CalcState.Result:
                    Result(false, msg);
                    break;
               
                default:
                    break;
            }
        }

        void Zero(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Zero;
            }
            else
            {
                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
            }
        }
        void AccumulateDigit(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.AccumulateDigit;
                tempNumber += msg;
                displayMsg(tempNumber);
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
                else if (Rules.IsOperator(msg))
                {
                    Compute(true, msg);
                }
                else if (Rules.IsEqualSign(msg))
                {
                    Result(true, msg);
                }
                else if(Rules.IsStrange(msg))
                {
                    Compute2(true, msg);
                }

                
            }
        }
        void Compute(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Compute;

                if (operation.Length > 0 )
                {
                    Calculate();

                    displayMsg(resultNumber);
                }
                              
                else
                {
                    resultNumber = tempNumber;
                }
                
                tempNumber = "";
                operation = msg;
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
            }
        }
        void Compute2(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Compute2;
                resultNumber = tempNumber;
                tempNumber = "";
                operation = msg;
                Calculate();

                displayMsg(resultNumber);
                
            }
            else
            
            if (Rules.IsNonZeroDigit(msg))
            {
                AccumulateDigit(true, msg);
            }
            else if (Rules.IsZero(msg))
            {
                Zero(true, msg);
            }
            else if (Rules.IsOperator(msg))
            {
                operation = "";
                tempNumber = resultNumber;
                Compute(true, msg);
            }
            else if (Rules.IsStrange(msg))
            {
                operation = "";
                tempNumber = resultNumber;
                Compute2(true, msg);
            }
        }
    void Result(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Result;
                Calculate();
                displayMsg(resultNumber);
            }
            else
            {

                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
                else if (Rules.IsZero(msg))
                {
                    Zero(true, msg);
                }
                else if (Rules.IsOperator(msg))
                {
                    operation = "";
                    tempNumber = resultNumber;
                    Compute(true, msg);
                }
                else if (Rules.IsStrange(msg))
                {
                    operation = "";
                    tempNumber = resultNumber;
                    Compute2(true, msg);
                }

            }
        }
        void Result2(bool isInput, string msg)
        {
            if (isInput)
            {
                calcState = CalcState.Result;
                displayMsg(resultNumber);
            }
            else
            {

                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigit(true, msg);
                }
                else if (Rules.IsZero(msg))
                {
                    Zero(true, msg);
                }
                else if (Rules.IsOperator(msg))
                {
                    operation = "";
                    tempNumber = resultNumber;
                    Compute(true, msg);
                }
                else if (Rules.IsStrange(msg))
                {
                    operation = "";
                    tempNumber = resultNumber;
                    Compute2(true, msg);
                }

            }
        }
        void Calculate()
        {
            if (operation == "+")
            {
                resultNumber = (int.Parse(resultNumber) + int.Parse(tempNumber)).ToString();
            }
            else if (operation == "-")
            {
                resultNumber = (int.Parse(resultNumber) - int.Parse(tempNumber)).ToString();
            }
            else if (operation == "*")
            {
                resultNumber = (int.Parse(resultNumber) * int.Parse(tempNumber)).ToString();
            }
            else if (operation == "/")
            {
                resultNumber = (double.Parse(resultNumber) / double.Parse(tempNumber)).ToString();
            }
            else if (operation == "√")
            {
                if (double.Parse(resultNumber) >= 0)
                {
                    resultNumber = Math.Sqrt(double.Parse(resultNumber)).ToString();
                }
                else
                {
                 resultNumber="mistake";
                }
            }
            else if(operation == "±")
            {
                resultNumber = ((-1) * (double.Parse(resultNumber))).ToString();
            }
        }
    }
    public class Rules
    {
        static bool Check(char[] arr, string msg)
        {
            return arr.Contains(msg[0]);
        }
        public static bool IsNonZeroDigit(string msg)
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return Check(arr, msg);
        }
        public static bool IsDigit(string msg)
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return Check(arr, msg);
        }
        public static bool IsZero(string msg)
        {
            char[] arr = { '0' };
            return Check(arr, msg);
        }
        public static bool IsOperator(string msg)
        {
            char[] arr = { '+', '-', '/', '*',};
            return Check(arr, msg);
        }
        public static bool IsEqualSign(string msg)
        {
            char[] arr = { '=' };
            return Check(arr, msg);
        }
        public static bool IsStrange(string msg)
        {
            char[] arr = { '√', '±' };
            return Check(arr, msg);
        }

    }
}
