﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestForm {
    public partial class Form2 : Form {
        Form opener2;

        public Form2(Form parentForm) {
            InitializeComponent();
            opener2   = ParentForm;
        }

        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}
