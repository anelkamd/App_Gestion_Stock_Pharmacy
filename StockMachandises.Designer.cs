namespace GestionStockFarmacy
{
    partial class FrmProduits
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
            Submite = new Button();
            txDesignation = new TextBox();
            txPrixUnitaire = new TextBox();
            txQuantite = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txCodeProduit = new TextBox();
            label4 = new Label();
            dgProduits = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgProduits).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Submite
            // 
            Submite.BackColor = Color.FromArgb(0, 192, 0);
            Submite.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submite.ForeColor = SystemColors.ButtonHighlight;
            Submite.Location = new Point(12, 553);
            Submite.Name = "Submite";
            Submite.Size = new Size(154, 45);
            Submite.TabIndex = 0;
            Submite.Text = "Ajouter";
            Submite.UseVisualStyleBackColor = false;
            Submite.Click += Submite_Click;
            // 
            // txDesignation
            // 
            txDesignation.Location = new Point(145, 32);
            txDesignation.Name = "txDesignation";
            txDesignation.Size = new Size(281, 31);
            txDesignation.TabIndex = 1;
            // 
            // txPrixUnitaire
            // 
            txPrixUnitaire.Location = new Point(145, 85);
            txPrixUnitaire.Name = "txPrixUnitaire";
            txPrixUnitaire.Size = new Size(281, 31);
            txPrixUnitaire.TabIndex = 2;
            // 
            // txQuantite
            // 
            txQuantite.Location = new Point(145, 133);
            txQuantite.Name = "txQuantite";
            txQuantite.Size = new Size(281, 31);
            txQuantite.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 8;
            label1.Text = "Designation :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 9;
            label2.Text = "Prix Unitaire :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 10;
            label3.Text = "Quantites :";
            // 
            // txCodeProduit
            // 
            txCodeProduit.Location = new Point(145, 185);
            txCodeProduit.Name = "txCodeProduit";
            txCodeProduit.Size = new Size(281, 31);
            txCodeProduit.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 12;
            label4.Text = "Code Produit :";
            // 
            // dgProduits
            // 
            dgProduits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduits.Location = new Point(26, 55);
            dgProduits.Name = "dgProduits";
            dgProduits.RowHeadersWidth = 62;
            dgProduits.Size = new Size(727, 196);
            dgProduits.TabIndex = 13;
            dgProduits.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgProduits);
            groupBox1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 280);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produits En stock";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(172, 553);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 15;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(332, 553);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 16;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__2_;
            pictureBox1.Location = new Point(463, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FrmProduits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txCodeProduit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txQuantite);
            Controls.Add(txPrixUnitaire);
            Controls.Add(txDesignation);
            Controls.Add(Submite);
            Name = "FrmProduits";
            Text = "Produits En Stocks";
            Load += FrmProduits_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduits).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submite;
        private TextBox txDesignation;
        private TextBox txPrixUnitaire;
        private TextBox txQuantite;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txCodeProduit;
        private Label label4;
        private DataGridView dgProduits;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}