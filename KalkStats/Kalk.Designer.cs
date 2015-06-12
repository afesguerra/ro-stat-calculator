namespace KalkStats
{
    partial class Kalk
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalk));
            this.info = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.trans = new System.Windows.Forms.CheckBox();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.calc = new System.Windows.Forms.GroupBox();
            this.points = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Str = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Agi = new System.Windows.Forms.NumericUpDown();
            this.Vit = new System.Windows.Forms.NumericUpDown();
            this.Int = new System.Windows.Forms.NumericUpDown();
            this.Dex = new System.Windows.Forms.NumericUpDown();
            this.Luk = new System.Windows.Forms.NumericUpDown();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            this.calc.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info.Controls.Add(this.start);
            this.info.Controls.Add(this.trans);
            this.info.Controls.Add(this.level);
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(256, 67);
            this.info.TabIndex = 0;
            this.info.TabStop = false;
            this.info.Text = "Level";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(134, 38);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // trans
            // 
            this.trans.AutoSize = true;
            this.trans.Location = new System.Drawing.Point(134, 15);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(92, 17);
            this.trans.TabIndex = 1;
            this.trans.Text = "Transcendant";
            this.trans.UseVisualStyleBackColor = true;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(6, 23);
            this.level.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(120, 20);
            this.level.TabIndex = 0;
            this.level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calc
            // 
            this.calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calc.Controls.Add(this.points);
            this.calc.Controls.Add(this.reset);
            this.calc.Controls.Add(this.tableLayoutPanel1);
            this.calc.Location = new System.Drawing.Point(12, 85);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(256, 163);
            this.calc.TabIndex = 1;
            this.calc.TabStop = false;
            this.calc.Text = "Stats Calculator";
            // 
            // points
            // 
            this.points.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.points.Location = new System.Drawing.Point(91, 24);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(75, 17);
            this.points.TabIndex = 4;
            this.points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(91, 44);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Str, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Agi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Vit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Int, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dex, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Luk, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(79, 138);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Str
            // 
            this.Str.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Str.Location = new System.Drawing.Point(42, 3);
            this.Str.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Str.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(34, 20);
            this.Str.TabIndex = 2;
            this.Str.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Str.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "STR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "LUK";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "AGI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "DEX";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "VIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "INT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Agi
            // 
            this.Agi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Agi.Location = new System.Drawing.Point(42, 25);
            this.Agi.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Agi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Agi.Name = "Agi";
            this.Agi.Size = new System.Drawing.Size(34, 20);
            this.Agi.TabIndex = 2;
            this.Agi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Agi.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // Vit
            // 
            this.Vit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vit.Location = new System.Drawing.Point(42, 47);
            this.Vit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Vit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Vit.Name = "Vit";
            this.Vit.Size = new System.Drawing.Size(34, 20);
            this.Vit.TabIndex = 2;
            this.Vit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Vit.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // Int
            // 
            this.Int.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Int.Location = new System.Drawing.Point(42, 69);
            this.Int.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Int.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(34, 20);
            this.Int.TabIndex = 2;
            this.Int.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Int.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // Dex
            // 
            this.Dex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dex.Location = new System.Drawing.Point(42, 91);
            this.Dex.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Dex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(34, 20);
            this.Dex.TabIndex = 2;
            this.Dex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dex.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // Luk
            // 
            this.Luk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Luk.Location = new System.Drawing.Point(42, 113);
            this.Luk.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Luk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Luk.Name = "Luk";
            this.Luk.Size = new System.Drawing.Size(34, 20);
            this.Luk.TabIndex = 2;
            this.Luk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Luk.ValueChanged += new System.EventHandler(this.actualizar);
            // 
            // Kalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 258);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(296, 296);
            this.MinimumSize = new System.Drawing.Size(296, 296);
            this.Name = "Kalk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stat Kalk";
            this.Load += new System.EventHandler(this.Kalk_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            this.calc.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox trans;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.GroupBox calc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown Str;
        private System.Windows.Forms.NumericUpDown Agi;
        private System.Windows.Forms.NumericUpDown Vit;
        private System.Windows.Forms.NumericUpDown Int;
        private System.Windows.Forms.NumericUpDown Dex;
        private System.Windows.Forms.NumericUpDown Luk;
        private System.Windows.Forms.Label points;
    }
}

