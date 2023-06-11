using System.Drawing;

namespace WFListNote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.fname_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.phone1_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phone2_tb = new System.Windows.Forms.TextBox();
            this.phone1_tb = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.phone2_lb = new System.Windows.Forms.Label();
            this.title_lb = new System.Windows.Forms.Label();
            this.btn_gb = new System.Windows.Forms.GroupBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.btn_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(15, 18);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(106, 23);
            this.fname_lb.TabIndex = 0;
            this.fname_lb.Text = "First Name";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(199, 18);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(105, 23);
            this.lname_lb.TabIndex = 1;
            this.lname_lb.Text = "Last Name";
            // 
            // phone1_lb
            // 
            this.phone1_lb.AutoSize = true;
            this.phone1_lb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1_lb.Location = new System.Drawing.Point(385, 18);
            this.phone1_lb.Name = "phone1_lb";
            this.phone1_lb.Size = new System.Drawing.Size(156, 23);
            this.phone1_lb.TabIndex = 2;
            this.phone1_lb.Text = "Phone Number 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.phone2_tb);
            this.panel1.Controls.Add(this.phone1_tb);
            this.panel1.Controls.Add(this.lname_tb);
            this.panel1.Controls.Add(this.fname_tb);
            this.panel1.Controls.Add(this.phone2_lb);
            this.panel1.Controls.Add(this.fname_lb);
            this.panel1.Controls.Add(this.phone1_lb);
            this.panel1.Controls.Add(this.lname_lb);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 299);
            this.panel1.TabIndex = 3;
            // 
            // phone2_tb
            // 
            this.phone2_tb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone2_tb.Location = new System.Drawing.Point(590, 85);
            this.phone2_tb.Name = "phone2_tb";
            this.phone2_tb.Size = new System.Drawing.Size(166, 30);
            this.phone2_tb.TabIndex = 7;
            // 
            // phone1_tb
            // 
            this.phone1_tb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1_tb.Location = new System.Drawing.Point(389, 85);
            this.phone1_tb.Name = "phone1_tb";
            this.phone1_tb.Size = new System.Drawing.Size(162, 30);
            this.phone1_tb.TabIndex = 6;
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(203, 85);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(153, 30);
            this.lname_tb.TabIndex = 5;
            // 
            // fname_tb
            // 
            this.fname_tb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tb.Location = new System.Drawing.Point(19, 85);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(144, 30);
            this.fname_tb.TabIndex = 4;
            // 
            // phone2_lb
            // 
            this.phone2_lb.AutoSize = true;
            this.phone2_lb.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone2_lb.Location = new System.Drawing.Point(586, 18);
            this.phone2_lb.Name = "phone2_lb";
            this.phone2_lb.Size = new System.Drawing.Size(156, 23);
            this.phone2_lb.TabIndex = 3;
            this.phone2_lb.Text = "Phone Number 2";
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.Location = new System.Drawing.Point(208, 16);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(213, 42);
            this.title_lb.TabIndex = 4;
            this.title_lb.Text = "Phone Book";
            // 
            // btn_gb
            // 
            this.btn_gb.Controls.Add(this.del_btn);
            this.btn_gb.Controls.Add(this.add_btn);
            this.btn_gb.Controls.Add(this.find_btn);
            this.btn_gb.Controls.Add(this.show_btn);
            this.btn_gb.Location = new System.Drawing.Point(12, 390);
            this.btn_gb.Name = "btn_gb";
            this.btn_gb.Size = new System.Drawing.Size(776, 57);
            this.btn_gb.TabIndex = 5;
            this.btn_gb.TabStop = false;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.del_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(573, 13);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(197, 35);
            this.del_btn.TabIndex = 3;
            this.del_btn.Text = "DELETE";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(385, 13);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(182, 37);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.find_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.Location = new System.Drawing.Point(189, 13);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(190, 38);
            this.find_btn.TabIndex = 1;
            this.find_btn.Text = "FIND";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.show_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.ForeColor = System.Drawing.Color.Black;
            this.show_btn.Location = new System.Drawing.Point(6, 13);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(177, 38);
            this.show_btn.TabIndex = 0;
            this.show_btn.Text = "SHOW";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gb);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // show_panel
            //
            this.show_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.show_panel.Size = new System.Drawing.Size(776, 240);
            this.show_panel.Location = new System.Drawing.Point(0, 55);

        }

        #endregion

        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label phone1_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label phone2_lb;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox phone1_tb;
        private System.Windows.Forms.TextBox phone2_tb;
        private System.Windows.Forms.GroupBox btn_gb;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.FlowLayoutPanel show_panel;
    }
}

