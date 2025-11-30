namespace _014___firstWindowsForm
{
    partial class Products
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
            dataGridViewProducts = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            quantityTextBox = new TextBox();
            quantityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(17, 23);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(886, 313);
            dataGridViewProducts.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(751, 342);
            addButton.Name = "addButton";
            addButton.Size = new Size(147, 52);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Gold;
            editButton.Location = new Point(751, 400);
            editButton.Name = "editButton";
            editButton.Size = new Size(147, 52);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(751, 458);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(147, 52);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(119, 372);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(237, 31);
            nameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = SystemColors.HotTrack;
            nameLabel.Location = new Point(17, 375);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(119, 479);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(237, 31);
            priceTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = SystemColors.HotTrack;
            priceLabel.Location = new Point(17, 479);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(49, 25);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(119, 421);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(237, 31);
            quantityTextBox.TabIndex = 12;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.ForeColor = SystemColors.HotTrack;
            quantityLabel.Location = new Point(17, 424);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(80, 25);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(942, 541);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(dataGridViewProducts);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            FormClosing += Products_FormClosing;
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox quantityTextBox;
        private Label quantityLabel;
    }
}