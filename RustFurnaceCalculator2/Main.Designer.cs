namespace RustFurnaceCalculator2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFurnaces = new System.Windows.Forms.Label();
            this.lblStackSize = new System.Windows.Forms.Label();
            this.lblMetal = new System.Windows.Forms.Label();
            this.lblWoodPerFurnace = new System.Windows.Forms.Label();
            this.lblSulfur = new System.Windows.Forms.Label();
            this.lblWoodTotal = new System.Windows.Forms.Label();
            this.lblHQM = new System.Windows.Forms.Label();
            this.lblCharcoal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtFurnaces = new System.Windows.Forms.TextBox();
            this.txtMetal = new System.Windows.Forms.TextBox();
            this.txtSulfur = new System.Windows.Forms.TextBox();
            this.txtHQM = new System.Windows.Forms.TextBox();
            this.txtStackSize = new System.Windows.Forms.TextBox();
            this.txtWoodPerFurnace = new System.Windows.Forms.TextBox();
            this.txtWoodTotal = new System.Windows.Forms.TextBox();
            this.txtCharcoal = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtOrePerFurnace = new System.Windows.Forms.TextBox();
            this.lblOrePerFurnace = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblFurnaces, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrePerFurnace, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStackSize, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMetal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWoodPerFurnace, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSulfur, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblWoodTotal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHQM, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCharcoal, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFurnaces, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMetal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSulfur, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtHQM, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtStackSize, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtWoodPerFurnace, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtWoodTotal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCharcoal, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTime, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStartTimer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtOrePerFurnace, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFurnaces
            // 
            this.lblFurnaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFurnaces.AutoSize = true;
            this.lblFurnaces.Location = new System.Drawing.Point(39, 0);
            this.lblFurnaces.Name = "lblFurnaces";
            this.lblFurnaces.Size = new System.Drawing.Size(51, 26);
            this.lblFurnaces.TabIndex = 0;
            this.lblFurnaces.Text = "Furnaces";
            this.lblFurnaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStackSize
            // 
            this.lblStackSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStackSize.AutoSize = true;
            this.lblStackSize.Location = new System.Drawing.Point(296, 0);
            this.lblStackSize.Name = "lblStackSize";
            this.lblStackSize.Size = new System.Drawing.Size(58, 26);
            this.lblStackSize.TabIndex = 1;
            this.lblStackSize.Text = "Stack Size";
            this.lblStackSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetal
            // 
            this.lblMetal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMetal.AutoSize = true;
            this.lblMetal.Location = new System.Drawing.Point(35, 52);
            this.lblMetal.Name = "lblMetal";
            this.lblMetal.Size = new System.Drawing.Size(60, 26);
            this.lblMetal.TabIndex = 2;
            this.lblMetal.Text = "Total Metal";
            this.lblMetal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMetal.Click += new System.EventHandler(this.lblMetal_Click);
            // 
            // lblWoodPerFurnace
            // 
            this.lblWoodPerFurnace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWoodPerFurnace.AutoSize = true;
            this.lblWoodPerFurnace.Location = new System.Drawing.Point(276, 52);
            this.lblWoodPerFurnace.Name = "lblWoodPerFurnace";
            this.lblWoodPerFurnace.Size = new System.Drawing.Size(97, 26);
            this.lblWoodPerFurnace.TabIndex = 3;
            this.lblWoodPerFurnace.Text = "Wood Per Furnace";
            this.lblWoodPerFurnace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSulfur
            // 
            this.lblSulfur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSulfur.AutoSize = true;
            this.lblSulfur.Location = new System.Drawing.Point(34, 104);
            this.lblSulfur.Name = "lblSulfur";
            this.lblSulfur.Size = new System.Drawing.Size(61, 26);
            this.lblSulfur.TabIndex = 4;
            this.lblSulfur.Text = "Total Sulfur";
            this.lblSulfur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSulfur.Click += new System.EventHandler(this.lblSulfur_Click);
            // 
            // lblWoodTotal
            // 
            this.lblWoodTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWoodTotal.AutoSize = true;
            this.lblWoodTotal.Location = new System.Drawing.Point(293, 104);
            this.lblWoodTotal.Name = "lblWoodTotal";
            this.lblWoodTotal.Size = new System.Drawing.Size(63, 26);
            this.lblWoodTotal.TabIndex = 5;
            this.lblWoodTotal.Text = "Wood Total";
            this.lblWoodTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHQM
            // 
            this.lblHQM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblHQM.AutoSize = true;
            this.lblHQM.Location = new System.Drawing.Point(35, 156);
            this.lblHQM.Name = "lblHQM";
            this.lblHQM.Size = new System.Drawing.Size(59, 26);
            this.lblHQM.TabIndex = 6;
            this.lblHQM.Text = "Total HQM";
            this.lblHQM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHQM.Click += new System.EventHandler(this.lblHQM_Click);
            // 
            // lblCharcoal
            // 
            this.lblCharcoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCharcoal.AutoSize = true;
            this.lblCharcoal.Location = new System.Drawing.Point(300, 156);
            this.lblCharcoal.Name = "lblCharcoal";
            this.lblCharcoal.Size = new System.Drawing.Size(49, 26);
            this.lblCharcoal.TabIndex = 7;
            this.lblCharcoal.Text = "Charcoal";
            this.lblCharcoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(150, 156);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(89, 26);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time to Complete";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFurnaces
            // 
            this.txtFurnaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFurnaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtFurnaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFurnaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFurnaces.Location = new System.Drawing.Point(5, 26);
            this.txtFurnaces.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtFurnaces.Name = "txtFurnaces";
            this.txtFurnaces.Size = new System.Drawing.Size(120, 20);
            this.txtFurnaces.TabIndex = 9;
            this.txtFurnaces.Text = "1";
            this.txtFurnaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFurnaces.TextChanged += new System.EventHandler(this.txtFurnaces_TextChanged);
            // 
            // txtMetal
            // 
            this.txtMetal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtMetal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMetal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMetal.Location = new System.Drawing.Point(5, 78);
            this.txtMetal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtMetal.Name = "txtMetal";
            this.txtMetal.Size = new System.Drawing.Size(120, 20);
            this.txtMetal.TabIndex = 10;
            this.txtMetal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMetal.TextChanged += new System.EventHandler(this.txtMetal_TextChanged);
            // 
            // txtSulfur
            // 
            this.txtSulfur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSulfur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtSulfur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSulfur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSulfur.Location = new System.Drawing.Point(5, 130);
            this.txtSulfur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtSulfur.Name = "txtSulfur";
            this.txtSulfur.Size = new System.Drawing.Size(120, 20);
            this.txtSulfur.TabIndex = 11;
            this.txtSulfur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSulfur.TextChanged += new System.EventHandler(this.txtSulfur_TextChanged);
            // 
            // txtHQM
            // 
            this.txtHQM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHQM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtHQM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHQM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtHQM.Location = new System.Drawing.Point(5, 182);
            this.txtHQM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtHQM.Name = "txtHQM";
            this.txtHQM.Size = new System.Drawing.Size(120, 20);
            this.txtHQM.TabIndex = 12;
            this.txtHQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHQM.TextChanged += new System.EventHandler(this.txtHQM_TextChanged);
            // 
            // txtStackSize
            // 
            this.txtStackSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStackSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtStackSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStackSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtStackSize.Location = new System.Drawing.Point(265, 26);
            this.txtStackSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtStackSize.Name = "txtStackSize";
            this.txtStackSize.ReadOnly = true;
            this.txtStackSize.Size = new System.Drawing.Size(120, 20);
            this.txtStackSize.TabIndex = 13;
            this.txtStackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWoodPerFurnace
            // 
            this.txtWoodPerFurnace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWoodPerFurnace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtWoodPerFurnace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWoodPerFurnace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtWoodPerFurnace.Location = new System.Drawing.Point(265, 78);
            this.txtWoodPerFurnace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtWoodPerFurnace.Name = "txtWoodPerFurnace";
            this.txtWoodPerFurnace.ReadOnly = true;
            this.txtWoodPerFurnace.Size = new System.Drawing.Size(120, 20);
            this.txtWoodPerFurnace.TabIndex = 14;
            this.txtWoodPerFurnace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWoodTotal
            // 
            this.txtWoodTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWoodTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtWoodTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWoodTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtWoodTotal.Location = new System.Drawing.Point(265, 130);
            this.txtWoodTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtWoodTotal.Name = "txtWoodTotal";
            this.txtWoodTotal.ReadOnly = true;
            this.txtWoodTotal.Size = new System.Drawing.Size(120, 20);
            this.txtWoodTotal.TabIndex = 15;
            this.txtWoodTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCharcoal
            // 
            this.txtCharcoal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharcoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtCharcoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCharcoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCharcoal.Location = new System.Drawing.Point(265, 182);
            this.txtCharcoal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtCharcoal.Name = "txtCharcoal";
            this.txtCharcoal.ReadOnly = true;
            this.txtCharcoal.Size = new System.Drawing.Size(120, 20);
            this.txtCharcoal.TabIndex = 16;
            this.txtCharcoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtTime.Location = new System.Drawing.Point(135, 182);
            this.txtTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(120, 20);
            this.txtTime.TabIndex = 17;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(157, 52);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 26);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStartTimer.AutoSize = true;
            this.btnStartTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStartTimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTimer.Location = new System.Drawing.Point(157, 104);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 26);
            this.btnStartTimer.TabIndex = 19;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(157, 208);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblError, 3);
            this.lblError.Location = new System.Drawing.Point(3, 254);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(384, 13);
            this.lblError.TabIndex = 21;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // txtOrePerFurnace
            // 
            this.txtOrePerFurnace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrePerFurnace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtOrePerFurnace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrePerFurnace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtOrePerFurnace.Location = new System.Drawing.Point(135, 26);
            this.txtOrePerFurnace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtOrePerFurnace.Name = "txtOrePerFurnace";
            this.txtOrePerFurnace.ReadOnly = true;
            this.txtOrePerFurnace.Size = new System.Drawing.Size(120, 20);
            this.txtOrePerFurnace.TabIndex = 22;
            this.txtOrePerFurnace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrePerFurnace
            // 
            this.lblOrePerFurnace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOrePerFurnace.AutoSize = true;
            this.lblOrePerFurnace.Location = new System.Drawing.Point(152, 0);
            this.lblOrePerFurnace.Name = "lblOrePerFurnace";
            this.lblOrePerFurnace.Size = new System.Drawing.Size(85, 26);
            this.lblOrePerFurnace.TabIndex = 1;
            this.lblOrePerFurnace.Text = "Ore Per Furnace";
            this.lblOrePerFurnace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(414, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Rust Furnace Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStackSize;
        private System.Windows.Forms.Label lblWoodPerFurnace;
        private System.Windows.Forms.Label lblWoodTotal;
        private System.Windows.Forms.Label lblCharcoal;
        private System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.TextBox txtFurnaces;
        public System.Windows.Forms.TextBox txtMetal;
        public System.Windows.Forms.TextBox txtSulfur;
        public System.Windows.Forms.TextBox txtHQM;
        public System.Windows.Forms.TextBox txtStackSize;
        public System.Windows.Forms.TextBox txtWoodPerFurnace;
        public System.Windows.Forms.TextBox txtWoodTotal;
        public System.Windows.Forms.TextBox txtCharcoal;
        public System.Windows.Forms.TextBox txtTime;
        public System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Button btnStartTimer;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Label lblFurnaces;
        public System.Windows.Forms.Label lblMetal;
        public System.Windows.Forms.Label lblSulfur;
        public System.Windows.Forms.Label lblHQM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOrePerFurnace;
        public System.Windows.Forms.TextBox txtOrePerFurnace;
    }
}

