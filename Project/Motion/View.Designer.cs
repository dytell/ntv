namespace Motion
{
    partial class View
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
            this._RadioButtonUnidormMotion = new System.Windows.Forms.RadioButton();
            this._RadioButtonAscillatoryMotion = new System.Windows.Forms.RadioButton();
            this._RadioButtonOcillatoryMotion = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._TextboxOscillatoryMotion_X0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._TextboxOscillatoryMotion_F0 = new System.Windows.Forms.TextBox();
            this._TextboxOscillatoryMotion_W0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._TextboxOscillatoryMotion_VX0 = new System.Windows.Forms.TextBox();
            this._TextboxOscillatoryMotion_Time = new System.Windows.Forms.TextBox();
            this._GroupBoxOscillatoryMotion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._TextboxAcellerationMotion_V0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._TextboxAcellerationMotion_X0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._TextboxAcellerationMotion_AX0 = new System.Windows.Forms.TextBox();
            this._TextboxAcellerationMotion_Time = new System.Windows.Forms.TextBox();
            this._GroupBoxAcceleratedMotion = new System.Windows.Forms.GroupBox();
            this._TextboxUniformMotion_V0 = new System.Windows.Forms.TextBox();
            this._TextboxUniformMotion_X0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._TextboxUniformMotion_Time = new System.Windows.Forms.TextBox();
            this._GroupBoxUniformMotion = new System.Windows.Forms.GroupBox();
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this._GroupBoxOscillatoryMotion.SuspendLayout();
            this._GroupBoxAcceleratedMotion.SuspendLayout();
            this._GroupBoxUniformMotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // _RadioButtonUnidormMotion
            // 
            this._RadioButtonUnidormMotion.AutoSize = true;
            this._RadioButtonUnidormMotion.Location = new System.Drawing.Point(6, 20);
            this._RadioButtonUnidormMotion.Name = "_RadioButtonUnidormMotion";
            this._RadioButtonUnidormMotion.Size = new System.Drawing.Size(147, 17);
            this._RadioButtonUnidormMotion.TabIndex = 4;
            this._RadioButtonUnidormMotion.Text = "Равномерное движение";
            this._RadioButtonUnidormMotion.UseVisualStyleBackColor = true;
            this._RadioButtonUnidormMotion.CheckedChanged += new System.EventHandler(this._RadioButtonUnidormMotion_CheckedChanged);
            // 
            // _RadioButtonAscillatoryMotion
            // 
            this._RadioButtonAscillatoryMotion.AutoSize = true;
            this._RadioButtonAscillatoryMotion.Location = new System.Drawing.Point(6, 44);
            this._RadioButtonAscillatoryMotion.Name = "_RadioButtonAscillatoryMotion";
            this._RadioButtonAscillatoryMotion.Size = new System.Drawing.Size(162, 17);
            this._RadioButtonAscillatoryMotion.TabIndex = 5;
            this._RadioButtonAscillatoryMotion.TabStop = true;
            this._RadioButtonAscillatoryMotion.Text = "Равноускореное движение";
            this._RadioButtonAscillatoryMotion.UseVisualStyleBackColor = true;
            this._RadioButtonAscillatoryMotion.CheckedChanged += new System.EventHandler(this._RadioButtonAscillatoryMotion_CheckedChanged);
            // 
            // _RadioButtonOcillatoryMotion
            // 
            this._RadioButtonOcillatoryMotion.AutoSize = true;
            this._RadioButtonOcillatoryMotion.Location = new System.Drawing.Point(5, 68);
            this._RadioButtonOcillatoryMotion.Name = "_RadioButtonOcillatoryMotion";
            this._RadioButtonOcillatoryMotion.Size = new System.Drawing.Size(156, 17);
            this._RadioButtonOcillatoryMotion.TabIndex = 6;
            this._RadioButtonOcillatoryMotion.TabStop = true;
            this._RadioButtonOcillatoryMotion.Text = "Калебательное движение";
            this._RadioButtonOcillatoryMotion.UseVisualStyleBackColor = true;
            this._RadioButtonOcillatoryMotion.CheckedChanged += new System.EventHandler(this._RadioButtonOcillatoryMotion_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._RadioButtonUnidormMotion);
            this.groupBox1.Controls.Add(this._RadioButtonOcillatoryMotion);
            this.groupBox1.Controls.Add(this._RadioButtonAscillatoryMotion);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(98, 332);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "Отмена";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "X0";
            // 
            // _TextboxOscillatoryMotion_X0
            // 
            this._TextboxOscillatoryMotion_X0.Location = new System.Drawing.Point(36, 19);
            this._TextboxOscillatoryMotion_X0.Name = "_TextboxOscillatoryMotion_X0";
            this._TextboxOscillatoryMotion_X0.Size = new System.Drawing.Size(100, 20);
            this._TextboxOscillatoryMotion_X0.TabIndex = 1;
            this._TextboxOscillatoryMotion_X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxOscillatoryMotion_X0_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "W0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "F0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "VX0";
            // 
            // _TextboxOscillatoryMotion_F0
            // 
            this._TextboxOscillatoryMotion_F0.Location = new System.Drawing.Point(36, 71);
            this._TextboxOscillatoryMotion_F0.Name = "_TextboxOscillatoryMotion_F0";
            this._TextboxOscillatoryMotion_F0.Size = new System.Drawing.Size(100, 20);
            this._TextboxOscillatoryMotion_F0.TabIndex = 3;
            this._TextboxOscillatoryMotion_F0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxOscillatoryMotion_F0_KeyPress);
            // 
            // _TextboxOscillatoryMotion_W0
            // 
            this._TextboxOscillatoryMotion_W0.Location = new System.Drawing.Point(36, 45);
            this._TextboxOscillatoryMotion_W0.Name = "_TextboxOscillatoryMotion_W0";
            this._TextboxOscillatoryMotion_W0.Size = new System.Drawing.Size(100, 20);
            this._TextboxOscillatoryMotion_W0.TabIndex = 2;
            this._TextboxOscillatoryMotion_W0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxOscillatoryMotion_W0_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Time";
            // 
            // _TextboxOscillatoryMotion_VX0
            // 
            this._TextboxOscillatoryMotion_VX0.Location = new System.Drawing.Point(36, 97);
            this._TextboxOscillatoryMotion_VX0.Name = "_TextboxOscillatoryMotion_VX0";
            this._TextboxOscillatoryMotion_VX0.Size = new System.Drawing.Size(100, 20);
            this._TextboxOscillatoryMotion_VX0.TabIndex = 4;
            this._TextboxOscillatoryMotion_VX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxOscillatoryMotion_VX0_KeyPress);
            // 
            // _TextboxOscillatoryMotion_Time
            // 
            this._TextboxOscillatoryMotion_Time.Location = new System.Drawing.Point(36, 122);
            this._TextboxOscillatoryMotion_Time.Name = "_TextboxOscillatoryMotion_Time";
            this._TextboxOscillatoryMotion_Time.Size = new System.Drawing.Size(100, 20);
            this._TextboxOscillatoryMotion_Time.TabIndex = 5;
            this._TextboxOscillatoryMotion_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxOscillatoryMotion_Time_KeyPress);
            // 
            // _GroupBoxOscillatoryMotion
            // 
            this._GroupBoxOscillatoryMotion.Controls.Add(this._TextboxOscillatoryMotion_Time);
            this._GroupBoxOscillatoryMotion.Controls.Add(this._TextboxOscillatoryMotion_VX0);
            this._GroupBoxOscillatoryMotion.Controls.Add(this.label9);
            this._GroupBoxOscillatoryMotion.Controls.Add(this._TextboxOscillatoryMotion_W0);
            this._GroupBoxOscillatoryMotion.Controls.Add(this._TextboxOscillatoryMotion_F0);
            this._GroupBoxOscillatoryMotion.Controls.Add(this.label8);
            this._GroupBoxOscillatoryMotion.Controls.Add(this.label7);
            this._GroupBoxOscillatoryMotion.Controls.Add(this.label6);
            this._GroupBoxOscillatoryMotion.Controls.Add(this._TextboxOscillatoryMotion_X0);
            this._GroupBoxOscillatoryMotion.Controls.Add(this.label5);
            this._GroupBoxOscillatoryMotion.Location = new System.Drawing.Point(385, 12);
            this._GroupBoxOscillatoryMotion.Name = "_GroupBoxOscillatoryMotion";
            this._GroupBoxOscillatoryMotion.Size = new System.Drawing.Size(184, 156);
            this._GroupBoxOscillatoryMotion.TabIndex = 3;
            this._GroupBoxOscillatoryMotion.TabStop = false;
            this._GroupBoxOscillatoryMotion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X0";
            // 
            // _TextboxAcellerationMotion_V0
            // 
            this._TextboxAcellerationMotion_V0.Location = new System.Drawing.Point(42, 58);
            this._TextboxAcellerationMotion_V0.Name = "_TextboxAcellerationMotion_V0";
            this._TextboxAcellerationMotion_V0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_V0.TabIndex = 2;
            this._TextboxAcellerationMotion_V0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxAcellerationMotion_V0_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "V0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AX0";
            // 
            // _TextboxAcellerationMotion_X0
            // 
            this._TextboxAcellerationMotion_X0.Location = new System.Drawing.Point(42, 32);
            this._TextboxAcellerationMotion_X0.Name = "_TextboxAcellerationMotion_X0";
            this._TextboxAcellerationMotion_X0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_X0.TabIndex = 1;
            this._TextboxAcellerationMotion_X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxAcellerationMotion_X0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // _TextboxAcellerationMotion_AX0
            // 
            this._TextboxAcellerationMotion_AX0.Location = new System.Drawing.Point(42, 84);
            this._TextboxAcellerationMotion_AX0.Name = "_TextboxAcellerationMotion_AX0";
            this._TextboxAcellerationMotion_AX0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_AX0.TabIndex = 3;
            this._TextboxAcellerationMotion_AX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxAcellerationMotion_AX0_KeyPress);
            // 
            // _TextboxAcellerationMotion_Time
            // 
            this._TextboxAcellerationMotion_Time.Location = new System.Drawing.Point(42, 110);
            this._TextboxAcellerationMotion_Time.Name = "_TextboxAcellerationMotion_Time";
            this._TextboxAcellerationMotion_Time.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_Time.TabIndex = 4;
            this._TextboxAcellerationMotion_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxAcellerationMotion_Time_KeyPress);
            // 
            // _GroupBoxAcceleratedMotion
            // 
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_Time);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_AX0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label4);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_X0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label3);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label2);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_V0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label1);
            this._GroupBoxAcceleratedMotion.Location = new System.Drawing.Point(587, 69);
            this._GroupBoxAcceleratedMotion.Name = "_GroupBoxAcceleratedMotion";
            this._GroupBoxAcceleratedMotion.Size = new System.Drawing.Size(184, 156);
            this._GroupBoxAcceleratedMotion.TabIndex = 3;
            this._GroupBoxAcceleratedMotion.TabStop = false;
            this._GroupBoxAcceleratedMotion.Visible = false;
            // 
            // _TextboxUniformMotion_V0
            // 
            this._TextboxUniformMotion_V0.Location = new System.Drawing.Point(38, 46);
            this._TextboxUniformMotion_V0.Name = "_TextboxUniformMotion_V0";
            this._TextboxUniformMotion_V0.Size = new System.Drawing.Size(100, 20);
            this._TextboxUniformMotion_V0.TabIndex = 2;
            this._TextboxUniformMotion_V0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxUniformMotion_V0_KeyPress);
            // 
            // _TextboxUniformMotion_X0
            // 
            this._TextboxUniformMotion_X0.Location = new System.Drawing.Point(38, 21);
            this._TextboxUniformMotion_X0.Name = "_TextboxUniformMotion_X0";
            this._TextboxUniformMotion_X0.Size = new System.Drawing.Size(100, 20);
            this._TextboxUniformMotion_X0.TabIndex = 1;
            this._TextboxUniformMotion_X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxUniformMotion_X0_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "X0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "V0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Time";
            // 
            // _TextboxUniformMotion_Time
            // 
            this._TextboxUniformMotion_Time.Location = new System.Drawing.Point(38, 72);
            this._TextboxUniformMotion_Time.Name = "_TextboxUniformMotion_Time";
            this._TextboxUniformMotion_Time.Size = new System.Drawing.Size(100, 20);
            this._TextboxUniformMotion_Time.TabIndex = 3;
            this._TextboxUniformMotion_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._TextboxUniformMotion_Time_KeyPress);
            // 
            // _GroupBoxUniformMotion
            // 
            this._GroupBoxUniformMotion.Controls.Add(this._TextboxUniformMotion_Time);
            this._GroupBoxUniformMotion.Controls.Add(this.label12);
            this._GroupBoxUniformMotion.Controls.Add(this.label11);
            this._GroupBoxUniformMotion.Controls.Add(this.label10);
            this._GroupBoxUniformMotion.Controls.Add(this._TextboxUniformMotion_X0);
            this._GroupBoxUniformMotion.Controls.Add(this._TextboxUniformMotion_V0);
            this._GroupBoxUniformMotion.Location = new System.Drawing.Point(195, 111);
            this._GroupBoxUniformMotion.Name = "_GroupBoxUniformMotion";
            this._GroupBoxUniformMotion.Size = new System.Drawing.Size(168, 100);
            this._GroupBoxUniformMotion.TabIndex = 3;
            this._GroupBoxUniformMotion.TabStop = false;
            this._GroupBoxUniformMotion.Visible = false;
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(5, 182);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(220, 144);
            this.userControl1.TabIndex = 10;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 369);
       
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._GroupBoxAcceleratedMotion);
            this.Controls.Add(this._GroupBoxOscillatoryMotion);
            this.Controls.Add(this._GroupBoxUniformMotion);
            this.MaximizeBox = false;
            this.Name = "View";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._GroupBoxOscillatoryMotion.ResumeLayout(false);
            this._GroupBoxOscillatoryMotion.PerformLayout();
            this._GroupBoxAcceleratedMotion.ResumeLayout(false);
            this._GroupBoxAcceleratedMotion.PerformLayout();
            this._GroupBoxUniformMotion.ResumeLayout(false);
            this._GroupBoxUniformMotion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

   
        private System.Windows.Forms.RadioButton _RadioButtonAscillatoryMotion;
        private System.Windows.Forms.RadioButton _RadioButtonOcillatoryMotion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.RadioButton _RadioButtonUnidormMotion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _TextboxOscillatoryMotion_X0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _TextboxOscillatoryMotion_F0;
        private System.Windows.Forms.TextBox _TextboxOscillatoryMotion_W0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _TextboxOscillatoryMotion_VX0;
        private System.Windows.Forms.TextBox _TextboxOscillatoryMotion_Time;
        private System.Windows.Forms.GroupBox _GroupBoxOscillatoryMotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_V0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_X0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_AX0;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_Time;
        private System.Windows.Forms.GroupBox _GroupBoxAcceleratedMotion;
        private System.Windows.Forms.TextBox _TextboxUniformMotion_V0;
        private System.Windows.Forms.TextBox _TextboxUniformMotion_X0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _TextboxUniformMotion_Time;
        private System.Windows.Forms.GroupBox _GroupBoxUniformMotion;
        private System.Windows.Forms.UserControl userControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}