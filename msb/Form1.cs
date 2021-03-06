﻿using Microsoft.Data.Sqlite;
using SQLiteWithEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            DatabaseContext context = new DatabaseContext();
            Console.WriteLine("Enter Employee name");
            string name = "duc 2";
            EmployeeMaster employee = new EmployeeMaster()
            {
                EmpName = name
            };
            context.EmployeeMaster.Add(employee);
            context.SaveChanges();

            var data = context.EmployeeMaster.ToList();
            var history = context.History.ToList();
            foreach (var item in data)
            {
                Console.Write(string.Format("ID : {0}  Name : {1}  Salary : {2}", item.ID, item.EmpName, Environment.NewLine));
            }

        }
    }
}
