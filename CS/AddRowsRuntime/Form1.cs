using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Rows;

namespace AddRowsRuntime {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            propertyGridControl1.AutoGenerateRows = false;
            CreateRows();
            Person person = new Person();
            person.LastName = "Doe";
            person.FirstName = "John";
            propertyGridControl1.SelectedObject = person;
        }

        private void CreateRows() {
            EditorRow rowLastName = new EditorRow("LastName");
            rowLastName.Properties.Caption = "Last name";
            propertyGridControl1.Rows.Add(rowLastName);
            CategoryRow rowCategory = new CategoryRow("Address");
            propertyGridControl1.Rows.Add(rowCategory);
            EditorRow rowAddressLine1 = new EditorRow("AddressLine1");
            rowAddressLine1.Properties.Caption = "Address Line 1";
            rowCategory.ChildRows.Add(rowAddressLine1);
            EditorRow rowZip = new EditorRow("Zip");
            rowZip.Properties.Caption = "Zip Code";
            rowCategory.ChildRows.Add(rowZip);
        }
    }

    public class Person {
        private string _FirstName;
        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _AddressLine1;
        public string AddressLine1 {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        private string _Zip;
        public string Zip {
            get { return _Zip; }
            set { _Zip = value; }
        }
    }
}
