﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateConverter.DCS.Tools
{
    /// <summary>
    /// A form to ask the user a question with two choices
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormAskBinaryQuestion : Form
    {
        /// <summary>
        /// Gets a value indicating the result of the question.
        /// </summary>
        /// <value>
        ///   <c>true</c> if answered positive; otherwise, <c>false</c>.
        /// </value>
        public bool Result { get; private set; } = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormAskBinaryQuestion"/> class.
        /// </summary>
        /// <param name="question">The question to be asked, will be the title of the form.</param>
        /// <param name="yesButtonText">The yes button text.</param>
        /// <param name="noButtonText">The no button text.</param>
        /// <param name="questionText">A more detailed question text to be displayed in the form itself. If <c>null</c>, then <paramref name="question"/> will be used.</param>
        /// <exception cref="System.ArgumentNullException">
        /// If <paramref name="question"/>, <paramref name="yesButtonText"/> or <paramref name="noButtonText"/> is null
        /// </exception>
        public FormAskBinaryQuestion(string question, string yesButtonText = "Yes", string noButtonText = "No", string questionText = null)
        {
            // Check arguments
            if (string.IsNullOrEmpty(question))
            {
                throw new ArgumentNullException(nameof(question) + " must not be null or empty");
            }
            if (string.IsNullOrEmpty(yesButtonText))
            {
                throw new ArgumentNullException(nameof(yesButtonText) + " must not be null or empty");
            }
            if (string.IsNullOrEmpty(noButtonText))
            {
                throw new ArgumentNullException(nameof(noButtonText) + " must not be null or empty");
            }

            // Build the form
            InitializeComponent();

            // Set texts
            Text = question;
            lbl_QuestionText.Text = questionText ?? question;
            btn_Affirm.Text = yesButtonText;
            btn_Deny.Text = noButtonText;

            // Form will auto size to fit everything.

            // Adjust positions, button X positions will be set by means of the anchor
            btn_Affirm.Location = new Point(btn_Affirm.Location.X, lbl_QuestionText.Bottom + 4);
            btn_Deny.Location = new Point(btn_Deny.Location.X, lbl_QuestionText.Bottom + 4);
        }

        private void Btn_Deny_Click(object sender, EventArgs e)
        {
            Result = false;
            Close();
        }

        private void Btn_Affirm_Click(object sender, EventArgs e)
        {
            Result = true;
            Close();
        }
    }
}