using System.ComponentModel;

namespace DrogsorDie.Forms.GUI
{
    partial class Patientenbesuch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Patientenbesuch));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxStatus = new System.Windows.Forms.TextBox();
            this.dateTimePickerEinliferungszeitpunk = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 198);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grund des Besuches";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(244, 456);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(94, 25);
            this.buttonSpeichern.TabIndex = 4;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // textboxStatus
            // 
            this.textboxStatus.Location = new System.Drawing.Point(174, 47);
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.Size = new System.Drawing.Size(105, 23);
            this.textboxStatus.TabIndex = 6;
            // 
            // dateTimePickerEinliferungszeitpunk
            // 
            this.dateTimePickerEinliferungszeitpunk.Location = new System.Drawing.Point(34, 118);
            this.dateTimePickerEinliferungszeitpunk.Name = "dateTimePickerEinliferungszeitpunk";
            this.dateTimePickerEinliferungszeitpunk.Size = new System.Drawing.Size(83, 23);
            this.dateTimePickerEinliferungszeitpunk.TabIndex = 7;
            // 
            // Patientenbesuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(377, 507);
            this.Controls.Add(this.dateTimePickerEinliferungszeitpunk);
            this.Controls.Add(this.textboxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Patientenbesuch";
            this.Text = "Patientenbesuch";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerEinliferungszeitpunk;
    }
}