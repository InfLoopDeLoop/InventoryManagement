using System.Windows.Forms;

namespace InventoryManagement
{
    partial class MainScreen : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButtton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.PartsTable = new System.Windows.Forms.ListView();
            this.ProductsTable = new System.Windows.Forms.ListView();
            this.LeftTableLabel = new System.Windows.Forms.Label();
            this.RightTableLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LeftSearchButton = new System.Windows.Forms.Button();
            this.RightSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(7, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(383, 25);
            this.WindowLabel.TabIndex = 1;
            this.WindowLabel.Text = "Inventory Management System";
            // 
            // AddPartButton
            // 
            this.AddPartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddPartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButton.Location = new System.Drawing.Point(255, 366);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartsButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ModifyPartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartButton.Location = new System.Drawing.Point(336, 366);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartButton.TabIndex = 3;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            // 
            // DeletePartButtton
            // 
            this.DeletePartButtton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeletePartButtton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButtton.Location = new System.Drawing.Point(417, 366);
            this.DeletePartButtton.Name = "DeletePartButtton";
            this.DeletePartButtton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButtton.TabIndex = 4;
            this.DeletePartButtton.Text = "Delete";
            this.DeletePartButtton.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            this.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(747, 366);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ModifyProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductButton.Location = new System.Drawing.Point(828, 366);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductButton.TabIndex = 6;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(909, 366);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 7;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            // 
            // PartsTable
            // 
            this.PartsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsTable.HideSelection = false;
            this.PartsTable.Location = new System.Drawing.Point(12, 120);
            this.PartsTable.Name = "PartsTable";
            this.PartsTable.Size = new System.Drawing.Size(480, 240);
            this.PartsTable.TabIndex = 8;
            this.PartsTable.UseCompatibleStateImageBehavior = false;
            // 
            // ProductsTable
            // 
            this.ProductsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductsTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsTable.HideSelection = false;
            this.ProductsTable.Location = new System.Drawing.Point(504, 120);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.Size = new System.Drawing.Size(480, 240);
            this.ProductsTable.TabIndex = 9;
            this.ProductsTable.UseCompatibleStateImageBehavior = false;
            // 
            // LeftTableLabel
            // 
            this.LeftTableLabel.AutoSize = true;
            this.LeftTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTableLabel.Location = new System.Drawing.Point(12, 99);
            this.LeftTableLabel.Name = "LeftTableLabel";
            this.LeftTableLabel.Size = new System.Drawing.Size(55, 18);
            this.LeftTableLabel.TabIndex = 10;
            this.LeftTableLabel.Text = "Parts";
            // 
            // RightTableLabel
            // 
            this.RightTableLabel.AutoSize = true;
            this.RightTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTableLabel.Location = new System.Drawing.Point(501, 99);
            this.RightTableLabel.Name = "RightTableLabel";
            this.RightTableLabel.Size = new System.Drawing.Size(86, 18);
            this.RightTableLabel.TabIndex = 11;
            this.RightTableLabel.Text = "Products";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(909, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(255, 94);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 20);
            this.textBox.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(747, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 14;
            // 
            // LeftSearchButton
            // 
            this.LeftSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LeftSearchButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftSearchButton.Location = new System.Drawing.Point(417, 94);
            this.LeftSearchButton.Name = "LeftSearchButton";
            this.LeftSearchButton.Size = new System.Drawing.Size(75, 23);
            this.LeftSearchButton.TabIndex = 15;
            this.LeftSearchButton.Text = "Search";
            this.LeftSearchButton.UseVisualStyleBackColor = true;
            // 
            // RightSearchButton
            // 
            this.RightSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RightSearchButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightSearchButton.Location = new System.Drawing.Point(909, 91);
            this.RightSearchButton.Name = "RightSearchButton";
            this.RightSearchButton.Size = new System.Drawing.Size(75, 23);
            this.RightSearchButton.TabIndex = 16;
            this.RightSearchButton.Text = "Search";
            this.RightSearchButton.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 401);
            this.Controls.Add(this.RightSearchButton);
            this.Controls.Add(this.LeftSearchButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RightTableLabel);
            this.Controls.Add(this.LeftTableLabel);
            this.Controls.Add(this.ProductsTable);
            this.Controls.Add(this.PartsTable);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.DeletePartButtton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.WindowLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label WindowLabel;
        private Button AddPartButton;
        private Button ModifyPartButton;
        private Button DeletePartButtton;
        private Button AddProductButton;
        private Button ModifyProductButton;
        private Button DeleteProductButton;
        private ListView PartsTable;
        private ListView ProductsTable;
        private Label LeftTableLabel;
        private Label RightTableLabel;
        private Button ExitButton;
        private TextBox textBox;
        private TextBox textBox2;
        private Button LeftSearchButton;
        private Button RightSearchButton;
    }
}

