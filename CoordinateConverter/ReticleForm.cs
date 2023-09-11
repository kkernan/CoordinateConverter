﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateConverter
{
    /// <summary>
    /// A Form that has magenta as the transparency key and is placed at the center of a screen. An image of a reticle is loaded.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReticleForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReticleForm"/> class.
        /// </summary>
        public ReticleForm()
        {
            InitializeComponent();
        }
    }
}