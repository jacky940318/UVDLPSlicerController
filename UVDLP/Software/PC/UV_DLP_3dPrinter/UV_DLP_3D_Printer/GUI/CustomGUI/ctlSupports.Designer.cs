﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlSupports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressTitle = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlProgress();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttAddSupport = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttAutoSupport = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttSetup = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSuppotShape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numFB1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numFB = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numFT = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numHB = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.numHT = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.pictureSupport = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttMDownward = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlNumber1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlNumber3 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.ctlNumber2 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.ctlImageButton1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlToolTip1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlToolTip();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panelSuppotShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupport)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel2.Controls.Add(this.progressTitle);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(370, 294);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // progressTitle
            // 
            this.progressTitle.BarColor = System.Drawing.Color.RoyalBlue;
            this.progressTitle.BorderThickness = 2;
            this.progressTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressTitle.ForeColor = System.Drawing.Color.White;
            this.progressTitle.Location = new System.Drawing.Point(5, 4);
            this.progressTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.progressTitle.Maximum = 100;
            this.progressTitle.Minimum = 0;
            this.progressTitle.Name = "progressTitle";
            this.progressTitle.Size = new System.Drawing.Size(160, 25);
            this.progressTitle.TabIndex = 0;
            this.progressTitle.Text = "Supports";
            this.progressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressTitle.Value = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.buttAddSupport);
            this.flowLayoutPanel1.Controls.Add(this.buttAutoSupport);
            this.flowLayoutPanel1.Controls.Add(this.buttSetup);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 58);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttAddSupport
            // 
            this.buttAddSupport.BackColor = System.Drawing.Color.Navy;
            this.buttAddSupport.Checked = false;
            this.buttAddSupport.CheckImage = null;
            this.buttAddSupport.Gapx = 5;
            this.buttAddSupport.Gapy = 5;
            this.buttAddSupport.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupport.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAddSupport;
            this.buttAddSupport.Location = new System.Drawing.Point(5, 5);
            this.buttAddSupport.Margin = new System.Windows.Forms.Padding(5);
            this.buttAddSupport.Name = "buttAddSupport";
            this.buttAddSupport.Size = new System.Drawing.Size(48, 48);
            this.buttAddSupport.TabIndex = 23;
            this.buttAddSupport.Text = "ctlImageButton1";
            this.ctlToolTip1.SetToolTip(this.buttAddSupport, "Add manual\r\nsupport");
            this.buttAddSupport.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAddSupport.Click += new System.EventHandler(this.buttAddSupport_Click);
            // 
            // buttAutoSupport
            // 
            this.buttAutoSupport.BackColor = System.Drawing.Color.Navy;
            this.buttAutoSupport.Checked = false;
            this.buttAutoSupport.CheckImage = null;
            this.buttAutoSupport.Gapx = 5;
            this.buttAutoSupport.Gapy = 5;
            this.buttAutoSupport.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAutoSupport.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttAutoSupport;
            this.buttAutoSupport.Location = new System.Drawing.Point(58, 5);
            this.buttAutoSupport.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.buttAutoSupport.Name = "buttAutoSupport";
            this.buttAutoSupport.Size = new System.Drawing.Size(48, 48);
            this.buttAutoSupport.TabIndex = 24;
            this.buttAutoSupport.Text = "ctlImageButton3";
            this.ctlToolTip1.SetToolTip(this.buttAutoSupport, "Add automatic\r\nsupports");
            this.buttAutoSupport.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttAutoSupport.Click += new System.EventHandler(this.buttAutoSupport_Click);
            // 
            // buttSetup
            // 
            this.buttSetup.BackColor = System.Drawing.Color.Navy;
            this.buttSetup.Checked = false;
            this.buttSetup.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttSetup.Gapx = 5;
            this.buttSetup.Gapy = 5;
            this.buttSetup.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttSetup.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttGear;
            this.buttSetup.Location = new System.Drawing.Point(111, 5);
            this.buttSetup.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.buttSetup.Name = "buttSetup";
            this.buttSetup.Size = new System.Drawing.Size(48, 48);
            this.buttSetup.TabIndex = 25;
            this.buttSetup.Text = "ctlImageButton3";
            this.ctlToolTip1.SetToolTip(this.buttSetup, "Support configuration");
            this.buttSetup.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttSetup.Click += new System.EventHandler(this.buttSetup_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panelSuppotShape);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 97);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(366, 196);
            this.flowLayoutPanel3.TabIndex = 26;
            // 
            // panelSuppotShape
            // 
            this.panelSuppotShape.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuppotShape.Controls.Add(this.label1);
            this.panelSuppotShape.Controls.Add(this.numFB1);
            this.panelSuppotShape.Controls.Add(this.numFB);
            this.panelSuppotShape.Controls.Add(this.numFT);
            this.panelSuppotShape.Controls.Add(this.numHB);
            this.panelSuppotShape.Controls.Add(this.numHT);
            this.panelSuppotShape.Controls.Add(this.pictureSupport);
            this.panelSuppotShape.ForeColor = System.Drawing.Color.White;
            this.panelSuppotShape.Location = new System.Drawing.Point(0, 0);
            this.panelSuppotShape.Margin = new System.Windows.Forms.Padding(0);
            this.panelSuppotShape.Name = "panelSuppotShape";
            this.panelSuppotShape.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuppotShape.Size = new System.Drawing.Size(201, 194);
            this.panelSuppotShape.TabIndex = 25;
            this.panelSuppotShape.Text = "Support Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Support shape";
            // 
            // numFB1
            // 
            this.numFB1.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFB1.ButtonsColor = System.Drawing.Color.Navy;
            this.numFB1.ErrorColor = System.Drawing.Color.Red;
            this.numFB1.FloatVal = 10F;
            this.numFB1.Increment = 0.1F;
            this.numFB1.IntVal = 10;
            this.numFB1.IsFloat = true;
            this.numFB1.Location = new System.Drawing.Point(114, 160);
            this.numFB1.MaxFloat = 20F;
            this.numFB1.MaxInt = 1000;
            this.numFB1.MinFloat = -20F;
            this.numFB1.MinimumSize = new System.Drawing.Size(20, 5);
            this.numFB1.MinInt = 1;
            this.numFB1.Name = "numFB1";
            this.numFB1.Size = new System.Drawing.Size(79, 21);
            this.numFB1.TabIndex = 27;
            this.numFB1.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFB1, "Foot Bottom intra (mm)");
            this.numFB1.ValidColor = System.Drawing.Color.White;
            // 
            // numFB
            // 
            this.numFB.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFB.ButtonsColor = System.Drawing.Color.Navy;
            this.numFB.ErrorColor = System.Drawing.Color.Red;
            this.numFB.FloatVal = 10F;
            this.numFB.Increment = 0.1F;
            this.numFB.IntVal = 10;
            this.numFB.IsFloat = true;
            this.numFB.Location = new System.Drawing.Point(114, 133);
            this.numFB.MaxFloat = 20F;
            this.numFB.MaxInt = 1000;
            this.numFB.MinFloat = -20F;
            this.numFB.MinimumSize = new System.Drawing.Size(20, 5);
            this.numFB.MinInt = 1;
            this.numFB.Name = "numFB";
            this.numFB.Size = new System.Drawing.Size(79, 21);
            this.numFB.TabIndex = 26;
            this.numFB.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFB, "Foot Bottom (mm)");
            this.numFB.ValidColor = System.Drawing.Color.White;
            // 
            // numFT
            // 
            this.numFT.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFT.ButtonsColor = System.Drawing.Color.Navy;
            this.numFT.ErrorColor = System.Drawing.Color.Red;
            this.numFT.FloatVal = 10F;
            this.numFT.Increment = 0.1F;
            this.numFT.IntVal = 10;
            this.numFT.IsFloat = true;
            this.numFT.Location = new System.Drawing.Point(114, 106);
            this.numFT.MaxFloat = 20F;
            this.numFT.MaxInt = 1000;
            this.numFT.MinFloat = -20F;
            this.numFT.MinimumSize = new System.Drawing.Size(20, 5);
            this.numFT.MinInt = 1;
            this.numFT.Name = "numFT";
            this.numFT.Size = new System.Drawing.Size(79, 21);
            this.numFT.TabIndex = 25;
            this.numFT.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numFT, "Foot Top (mm)");
            this.numFT.ValidColor = System.Drawing.Color.White;
            // 
            // numHB
            // 
            this.numHB.BackColor = System.Drawing.Color.RoyalBlue;
            this.numHB.ButtonsColor = System.Drawing.Color.Navy;
            this.numHB.ErrorColor = System.Drawing.Color.Red;
            this.numHB.FloatVal = 10F;
            this.numHB.Increment = 0.1F;
            this.numHB.IntVal = 10;
            this.numHB.IsFloat = true;
            this.numHB.Location = new System.Drawing.Point(114, 58);
            this.numHB.MaxFloat = 20F;
            this.numHB.MaxInt = 1000;
            this.numHB.MinFloat = -20F;
            this.numHB.MinimumSize = new System.Drawing.Size(20, 5);
            this.numHB.MinInt = 1;
            this.numHB.Name = "numHB";
            this.numHB.Size = new System.Drawing.Size(79, 21);
            this.numHB.TabIndex = 24;
            this.numHB.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numHB, "Head Bottom (mm)");
            this.numHB.ValidColor = System.Drawing.Color.White;
            // 
            // numHT
            // 
            this.numHT.BackColor = System.Drawing.Color.RoyalBlue;
            this.numHT.ButtonsColor = System.Drawing.Color.Navy;
            this.numHT.ErrorColor = System.Drawing.Color.Red;
            this.numHT.FloatVal = 10F;
            this.numHT.Increment = 0.1F;
            this.numHT.IntVal = 10;
            this.numHT.IsFloat = true;
            this.numHT.Location = new System.Drawing.Point(114, 31);
            this.numHT.MaxFloat = 20F;
            this.numHT.MaxInt = 1000;
            this.numHT.MinFloat = -20F;
            this.numHT.MinimumSize = new System.Drawing.Size(20, 5);
            this.numHT.MinInt = 1;
            this.numHT.Name = "numHT";
            this.numHT.Size = new System.Drawing.Size(79, 21);
            this.numHT.TabIndex = 23;
            this.numHT.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.numHT, "Head Top (mm)");
            this.numHT.ValidColor = System.Drawing.Color.White;
            // 
            // pictureSupport
            // 
            this.pictureSupport.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureSupport.Location = new System.Drawing.Point(5, 31);
            this.pictureSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSupport.Name = "pictureSupport";
            this.pictureSupport.Size = new System.Drawing.Size(108, 150);
            this.pictureSupport.TabIndex = 12;
            this.pictureSupport.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.panel1);
            this.flowLayoutPanel4.Controls.Add(this.panel2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(204, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(162, 196);
            this.flowLayoutPanel4.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttMDownward);
            this.panel1.Controls.Add(this.ctlNumber1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 69);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Deg:";
            // 
            // buttMDownward
            // 
            this.buttMDownward.BackColor = System.Drawing.Color.Navy;
            this.buttMDownward.Checked = false;
            this.buttMDownward.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttMDownward.Gapx = 5;
            this.buttMDownward.Gapy = 5;
            this.buttMDownward.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttMDownward.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttDownward;
            this.buttMDownward.Location = new System.Drawing.Point(7, 32);
            this.buttMDownward.Margin = new System.Windows.Forms.Padding(5);
            this.buttMDownward.Name = "buttMDownward";
            this.buttMDownward.Size = new System.Drawing.Size(32, 32);
            this.buttMDownward.TabIndex = 31;
            this.buttMDownward.Text = "ctlImageButton1";
            this.ctlToolTip1.SetToolTip(this.buttMDownward, "Downward facing surfaces");
            this.buttMDownward.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlNumber1
            // 
            this.ctlNumber1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlNumber1.ButtonsColor = System.Drawing.Color.Navy;
            this.ctlNumber1.ErrorColor = System.Drawing.Color.Red;
            this.ctlNumber1.FloatVal = 10F;
            this.ctlNumber1.Increment = 0.1F;
            this.ctlNumber1.IntVal = 10;
            this.ctlNumber1.IsFloat = true;
            this.ctlNumber1.Location = new System.Drawing.Point(80, 43);
            this.ctlNumber1.MaxFloat = 20F;
            this.ctlNumber1.MaxInt = 1000;
            this.ctlNumber1.MinFloat = -20F;
            this.ctlNumber1.MinimumSize = new System.Drawing.Size(20, 5);
            this.ctlNumber1.MinInt = 1;
            this.ctlNumber1.Name = "ctlNumber1";
            this.ctlNumber1.Size = new System.Drawing.Size(79, 21);
            this.ctlNumber1.TabIndex = 30;
            this.ctlNumber1.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.ctlNumber1, "Downward facing degree");
            this.ctlNumber1.ValidColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Manual config";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ctlNumber3);
            this.panel2.Controls.Add(this.ctlNumber2);
            this.panel2.Controls.Add(this.ctlImageButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 122);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 32;
            this.label7.Text = "Y (mm):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 32;
            this.label6.Text = "X (mm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "Automatic Support Grid:";
            // 
            // ctlNumber3
            // 
            this.ctlNumber3.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlNumber3.ButtonsColor = System.Drawing.Color.Navy;
            this.ctlNumber3.ErrorColor = System.Drawing.Color.Red;
            this.ctlNumber3.FloatVal = 10F;
            this.ctlNumber3.Increment = 0.1F;
            this.ctlNumber3.IntVal = 10;
            this.ctlNumber3.IsFloat = true;
            this.ctlNumber3.Location = new System.Drawing.Point(49, 97);
            this.ctlNumber3.MaxFloat = 20F;
            this.ctlNumber3.MaxInt = 1000;
            this.ctlNumber3.MinFloat = -20F;
            this.ctlNumber3.MinimumSize = new System.Drawing.Size(20, 5);
            this.ctlNumber3.MinInt = 1;
            this.ctlNumber3.Name = "ctlNumber3";
            this.ctlNumber3.Size = new System.Drawing.Size(79, 21);
            this.ctlNumber3.TabIndex = 34;
            this.ctlNumber3.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.ctlNumber3, "Vertical grid spacing");
            this.ctlNumber3.ValidColor = System.Drawing.Color.White;
            // 
            // ctlNumber2
            // 
            this.ctlNumber2.BackColor = System.Drawing.Color.RoyalBlue;
            this.ctlNumber2.ButtonsColor = System.Drawing.Color.Navy;
            this.ctlNumber2.ErrorColor = System.Drawing.Color.Red;
            this.ctlNumber2.FloatVal = 10F;
            this.ctlNumber2.Increment = 0.1F;
            this.ctlNumber2.IntVal = 10;
            this.ctlNumber2.IsFloat = true;
            this.ctlNumber2.Location = new System.Drawing.Point(49, 73);
            this.ctlNumber2.MaxFloat = 20F;
            this.ctlNumber2.MaxInt = 1000;
            this.ctlNumber2.MinFloat = -20F;
            this.ctlNumber2.MinimumSize = new System.Drawing.Size(20, 5);
            this.ctlNumber2.MinInt = 1;
            this.ctlNumber2.Name = "ctlNumber2";
            this.ctlNumber2.Size = new System.Drawing.Size(79, 21);
            this.ctlNumber2.TabIndex = 33;
            this.ctlNumber2.TextFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctlToolTip1.SetToolTip(this.ctlNumber2, "Horizontal grid spacing");
            this.ctlNumber2.ValidColor = System.Drawing.Color.White;
            // 
            // ctlImageButton1
            // 
            this.ctlImageButton1.BackColor = System.Drawing.Color.Navy;
            this.ctlImageButton1.Checked = false;
            this.ctlImageButton1.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.ctlImageButton1.Gapx = 5;
            this.ctlImageButton1.Gapy = 5;
            this.ctlImageButton1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttDownward;
            this.ctlImageButton1.Location = new System.Drawing.Point(7, 26);
            this.ctlImageButton1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlImageButton1.Name = "ctlImageButton1";
            this.ctlImageButton1.Size = new System.Drawing.Size(32, 32);
            this.ctlImageButton1.TabIndex = 32;
            this.ctlImageButton1.Text = "ctlImageButton1";
            this.ctlToolTip1.SetToolTip(this.ctlImageButton1, "Generate support only on\r\ndownward facing surfaces");
            this.ctlImageButton1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Automatic config";
            // 
            // ctlToolTip1
            // 
            this.ctlToolTip1.AutoPopDelay = 5000;
            this.ctlToolTip1.BackColor = System.Drawing.Color.Turquoise;
            this.ctlToolTip1.ForeColor = System.Drawing.Color.Navy;
            this.ctlToolTip1.InitialDelay = 1500;
            this.ctlToolTip1.ReshowDelay = 100;
            // 
            // ctlSupports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ctlSupports";
            this.Size = new System.Drawing.Size(370, 294);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panelSuppotShape.ResumeLayout(false);
            this.panelSuppotShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupport)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ctlImageButton buttAddSupport;
        private ctlImageButton buttAutoSupport;
        private ctlImageButton buttSetup;
        private ctlProgress progressTitle;
        private ctlToolTip ctlToolTip1;
        private System.Windows.Forms.Panel panelSuppotShape;
        private ctlNumber numHT;
        private System.Windows.Forms.PictureBox pictureSupport;
        private ctlNumber numFB;
        private ctlNumber numFT;
        private ctlNumber numHB;
        private ctlNumber numFB1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private ctlNumber ctlNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private ctlImageButton buttMDownward;
        private ctlNumber ctlNumber3;
        private ctlNumber ctlNumber2;
        private ctlImageButton ctlImageButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}