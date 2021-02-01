namespace LosowanieZwyciezcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.buttonAddNewPerson = new System.Windows.Forms.Button();
            this.labelNumberOfPerson = new System.Windows.Forms.Label();
            this.labelWinnner = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelIcon = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpen);
            this.flowLayoutPanel1.Controls.Add(this.buttonDraw);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 308);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 183);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(385, 41);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Otwórz plik";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDraw.Location = new System.Drawing.Point(3, 50);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(385, 40);
            this.buttonDraw.TabIndex = 10;
            this.buttonDraw.Text = "Losuj zwycięzcę";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Usuń zaznaczony element";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(3, 142);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(385, 40);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Wyczyść listę";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 26);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(295, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "@Adrian Kut 2020";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.18341F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.74089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.25911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxMain
            // 
            this.listBoxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 21;
            this.listBoxMain.Items.AddRange(new object[] {
            "Jan Nowak",
            "Anna Kowalska"});
            this.listBoxMain.Location = new System.Drawing.Point(3, 3);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(190, 299);
            this.listBoxMain.TabIndex = 8;
            this.listBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMain_KeyDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxPerson);
            this.flowLayoutPanel2.Controls.Add(this.buttonAddNewPerson);
            this.flowLayoutPanel2.Controls.Add(this.labelNumberOfPerson);
            this.flowLayoutPanel2.Controls.Add(this.labelIcon);
            this.flowLayoutPanel2.Controls.Add(this.labelWinnner);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(204, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(192, 299);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(3, 3);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(184, 20);
            this.textBoxPerson.TabIndex = 0;
            // 
            // buttonAddNewPerson
            // 
            this.buttonAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewPerson.Location = new System.Drawing.Point(3, 29);
            this.buttonAddNewPerson.Name = "buttonAddNewPerson";
            this.buttonAddNewPerson.Size = new System.Drawing.Size(184, 31);
            this.buttonAddNewPerson.TabIndex = 1;
            this.buttonAddNewPerson.Text = "Dodaj";
            this.buttonAddNewPerson.UseVisualStyleBackColor = true;
            this.buttonAddNewPerson.Click += new System.EventHandler(this.buttonAddNewPerson_Click);
            // 
            // labelNumberOfPerson
            // 
            this.labelNumberOfPerson.AutoSize = true;
            this.labelNumberOfPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumberOfPerson.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPerson.Location = new System.Drawing.Point(3, 63);
            this.labelNumberOfPerson.Name = "labelNumberOfPerson";
            this.labelNumberOfPerson.Size = new System.Drawing.Size(161, 26);
            this.labelNumberOfPerson.TabIndex = 4;
            this.labelNumberOfPerson.Text = "👥Liczba osób:    ";
            // 
            // labelWinnner
            // 
            this.labelWinnner.AutoSize = true;
            this.labelWinnner.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnner.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelWinnner.Location = new System.Drawing.Point(173, 89);
            this.labelWinnner.Name = "labelWinnner";
            this.labelWinnner.Size = new System.Drawing.Size(0, 30);
            this.labelWinnner.TabIndex = 5;
            this.labelWinnner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelIcon.Location = new System.Drawing.Point(3, 89);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(164, 30);
            this.labelIcon.TabIndex = 6;
            this.labelIcon.Text = "🥇Zwycięzca:   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                         Losowanie";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNumberOfPerson;
        private System.Windows.Forms.Label labelWinnner;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Button buttonAddNewPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIcon;
    }
}

