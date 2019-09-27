namespace SwitchProjectWinForms
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
            this.labelD = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonCH = new System.Windows.Forms.Button();
            this.labelW = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.buttonW = new System.Windows.Forms.Button();
            this.textBoxDMC = new System.Windows.Forms.TextBox();
            this.textBox_CB = new System.Windows.Forms.TextBox();
            this.textBox_CZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.ForeColor = System.Drawing.Color.Blue;
            this.labelD.Location = new System.Drawing.Point(13, 22);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(225, 22);
            this.labelD.TabIndex = 0;
            this.labelD.Text = "Расшифровка дня недели";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM.ForeColor = System.Drawing.Color.Blue;
            this.labelM.Location = new System.Drawing.Point(13, 61);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(190, 22);
            this.labelM.TabIndex = 1;
            this.labelM.Text = "Расшифровка месяца";
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCH.ForeColor = System.Drawing.Color.Blue;
            this.labelCH.Location = new System.Drawing.Point(13, 103);
            this.labelCH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(318, 22);
            this.labelCH.TabIndex = 2;
            this.labelCH.Text = "Выполнение операций над числами";
            this.labelCH.Click += new System.EventHandler(this.LabelCH_Click);
            // 
            // buttonD
            // 
            this.buttonD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonD.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonD.Location = new System.Drawing.Point(725, 4);
            this.buttonD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(165, 51);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "Выполнить";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // buttonM
            // 
            this.buttonM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonM.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonM.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonM.Location = new System.Drawing.Point(725, 61);
            this.buttonM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(165, 51);
            this.buttonM.TabIndex = 4;
            this.buttonM.Text = "Выполнить";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.ButtonM_Click);
            // 
            // buttonCH
            // 
            this.buttonCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCH.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonCH.Location = new System.Drawing.Point(725, 118);
            this.buttonCH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCH.Name = "buttonCH";
            this.buttonCH.Size = new System.Drawing.Size(165, 45);
            this.buttonCH.TabIndex = 5;
            this.buttonCH.Text = "Выполнить";
            this.buttonCH.UseVisualStyleBackColor = false;
            this.buttonCH.Click += new System.EventHandler(this.ButtonCH_Click);
            // 
            // labelW
            // 
            this.labelW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelW.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelW.Location = new System.Drawing.Point(15, 168);
            this.labelW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(63, 22);
            this.labelW.TabIndex = 6;
            this.labelW.Text = "Выход";
            // 
            // labelO
            // 
            this.labelO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelO.ForeColor = System.Drawing.Color.Blue;
            this.labelO.Location = new System.Drawing.Point(940, 61);
            this.labelO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(0, 22);
            this.labelO.TabIndex = 7;
            // 
            // buttonW
            // 
            this.buttonW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonW.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonW.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonW.ForeColor = System.Drawing.Color.Maroon;
            this.buttonW.Location = new System.Drawing.Point(123, 146);
            this.buttonW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(165, 46);
            this.buttonW.TabIndex = 10;
            this.buttonW.Text = "Выполнить";
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.ButtonW_Click);
            // 
            // textBoxDMC
            // 
            this.textBoxDMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDMC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDMC.Location = new System.Drawing.Point(409, 33);
            this.textBoxDMC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDMC.Name = "textBoxDMC";
            this.textBoxDMC.Size = new System.Drawing.Size(274, 30);
            this.textBoxDMC.TabIndex = 11;
            // 
            // textBox_CB
            // 
            this.textBox_CB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CB.Location = new System.Drawing.Point(409, 84);
            this.textBox_CB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_CB.Name = "textBox_CB";
            this.textBox_CB.Size = new System.Drawing.Size(274, 30);
            this.textBox_CB.TabIndex = 12;
            // 
            // textBox_CZ
            // 
            this.textBox_CZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CZ.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CZ.Location = new System.Drawing.Point(409, 144);
            this.textBox_CZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_CZ.Name = "textBox_CZ";
            this.textBox_CZ.Size = new System.Drawing.Size(274, 30);
            this.textBox_CZ.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 202);
            this.Controls.Add(this.textBox_CZ);
            this.Controls.Add(this.textBox_CB);
            this.Controls.Add(this.textBoxDMC);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.buttonCH);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.labelCH);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelD);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1462, 654);
            this.MinimumSize = new System.Drawing.Size(1132, 258);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonCH;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.TextBox textBoxDMC;
        private System.Windows.Forms.TextBox textBox_CB;
        private System.Windows.Forms.TextBox textBox_CZ;
    }
}

