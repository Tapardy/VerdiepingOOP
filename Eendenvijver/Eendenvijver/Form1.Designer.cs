﻿namespace Eendenvijver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxEendGeslacht = new System.Windows.Forms.ComboBox();
            this.ComboBoxSelectedEend = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonMaakEend = new System.Windows.Forms.Button();
            this.ListBoxGemaakteEenden = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComboBoxEendGeslacht
            // 
            this.ComboBoxEendGeslacht.FormattingEnabled = true;
            this.ComboBoxEendGeslacht.Items.AddRange(new object[] {
            "Mannetje",
            "Vrouwtje",
            "Wil_Ik_Niet_Zeggen"});
            this.ComboBoxEendGeslacht.Location = new System.Drawing.Point(0, 72);
            this.ComboBoxEendGeslacht.Name = "ComboBoxEendGeslacht";
            this.ComboBoxEendGeslacht.Size = new System.Drawing.Size(242, 40);
            this.ComboBoxEendGeslacht.TabIndex = 0;
            // 
            // ComboBoxSelectedEend
            // 
            this.ComboBoxSelectedEend.FormattingEnabled = true;
            this.ComboBoxSelectedEend.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ComboBoxSelectedEend.Location = new System.Drawing.Point(248, 72);
            this.ComboBoxSelectedEend.Name = "ComboBoxSelectedEend";
            this.ComboBoxSelectedEend.Size = new System.Drawing.Size(242, 40);
            this.ComboBoxSelectedEend.TabIndex = 1;
            this.ComboBoxSelectedEend.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedEend_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geslacht Eend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecteer Eend";
            // 
            // ButtonMaakEend
            // 
            this.ButtonMaakEend.Location = new System.Drawing.Point(87, 139);
            this.ButtonMaakEend.Name = "ButtonMaakEend";
            this.ButtonMaakEend.Size = new System.Drawing.Size(307, 46);
            this.ButtonMaakEend.TabIndex = 4;
            this.ButtonMaakEend.Text = "Verander geslacht eend";
            this.ButtonMaakEend.UseVisualStyleBackColor = true;
            this.ButtonMaakEend.Click += new System.EventHandler(this.ButtonMaakEend_Click);
            // 
            // ListBoxGemaakteEenden
            // 
            this.ListBoxGemaakteEenden.FormattingEnabled = true;
            this.ListBoxGemaakteEenden.ItemHeight = 32;
            this.ListBoxGemaakteEenden.Location = new System.Drawing.Point(505, 37);
            this.ListBoxGemaakteEenden.Name = "ListBoxGemaakteEenden";
            this.ListBoxGemaakteEenden.Size = new System.Drawing.Size(240, 228);
            this.ListBoxGemaakteEenden.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 647);
            this.Controls.Add(this.ListBoxGemaakteEenden);
            this.Controls.Add(this.ButtonMaakEend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxSelectedEend);
            this.Controls.Add(this.ComboBoxEendGeslacht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ComboBoxEendGeslacht;
        private ComboBox ComboBoxSelectedEend;
        private Label label1;
        private Label label2;
        private Button ButtonMaakEend;
        private ListBox ListBoxGemaakteEenden;
    }
}