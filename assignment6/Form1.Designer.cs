using System;
using System.Drawing;
using System.Windows.Forms;

namespace assignment6
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Title = new Label();
            this.AddOrderButton = new Button();
            this.DeleteOrderButton = new Button();
            this.ChangeOrderButton = new Button();
            this.SortButton = new Button();
            this.SearchOrderButton = new Button();
            this.OrderList = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.IDSort = new RadioButton();
            this.NameSort = new RadioButton();
            this.CustomerSort = new RadioButton();
            this.AmountSort = new RadioButton();

            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();

            // Title
            this.Title.AutoSize = true;
            this.Title.Dock = DockStyle.Fill;
            this.Title.Font = new Font("OPPOSans B", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new Size(1134, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome to Order Manager";
            this.Title.TextAlign = ContentAlignment.MiddleCenter;

            // AddOrderButton
            this.AddOrderButton.Dock = DockStyle.Fill;
            this.AddOrderButton.Location = new Point(3, 3);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new Size(119, 51);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "AddOrder";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new EventHandler(this.AddOrderButton_Click);

            // DeleteOrderButton
            this.DeleteOrderButton.Dock = DockStyle.Fill;
            this.DeleteOrderButton.Location = new Point(128, 3);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new Size(119, 51);
            this.DeleteOrderButton.TabIndex = 2;
            this.DeleteOrderButton.Text = "DeleteOrder";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new EventHandler(this.DeleteOrderButton_Click);

            // ChangeOrderButton
            this.ChangeOrderButton.Dock = DockStyle.Fill;
            this.ChangeOrderButton.Location = new Point(253, 3);
            this.ChangeOrderButton.Name = "ChangeOrderButton";
            this.ChangeOrderButton.Size = new Size(119, 51);
            this.ChangeOrderButton.TabIndex = 3;
            this.ChangeOrderButton.Text = "ChangeOrder";
            this.ChangeOrderButton.UseVisualStyleBackColor = true;
            this.ChangeOrderButton.Click += new EventHandler(this.ChangeOrderButton_Click);

            // SearchOrderButton
            this.SearchOrderButton.Dock = DockStyle.Fill;
            this.SearchOrderButton.Location = new Point(378, 3);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new Size(119, 51);
            this.SearchOrderButton.TabIndex = 5;
            this.SearchOrderButton.Text = "SearchOrder";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new EventHandler(this.SearchOrderButton_Click);

            // SortButton
            this.SortButton.Dock = DockStyle.Fill;
            this.SortButton.Location = new Point(503, 3);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new Size(119, 51);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new EventHandler(this.SortButton_Click);

            // OrderList
            this.OrderList.BackgroundColor = SystemColors.ButtonFace;
            this.OrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Columns.AddRange(new DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.OrderList.Dock = DockStyle.Fill;
            this.OrderList.GridColor = SystemColors.InactiveBorder;
            this.OrderList.Location = new Point(3, 119);
            this.OrderList.Name = "OrderList";
            this.OrderList.ReadOnly = true;
            this.OrderList.RowHeadersWidth = 51;
            this.OrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.OrderList.Size = new Size(1134, 458);
            this.OrderList.TabIndex = 7;

            // dataGridViewTextBoxColumn1
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;

            // dataGridViewTextBoxColumn2
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;

            // dataGridViewTextBoxColumn3
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;

            // dataGridViewTextBoxColumn4
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;

            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrderList, 0, 2);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(1140, 580);
            this.tableLayoutPanel1.TabIndex = 8;

            // tableLayoutPanel2
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11F));
            this.tableLayoutPanel2.Controls.Add(this.AddOrderButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteOrderButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeOrderButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SearchOrderButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SortButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.IDSort, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.NameSort, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.CustomerSort, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.AmountSort, 8, 0);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new Size(1134, 57);
            this.tableLayoutPanel2.TabIndex = 9;

            // IDSort
            this.IDSort.AutoSize = true;
            this.IDSort.Dock = DockStyle.Fill;
            this.IDSort.Location = new Point(628, 3);
            this.IDSort.Name = "IDSort";
            this.IDSort.Size = new Size(119, 51);
            this.IDSort.TabIndex = 6;
            this.IDSort.TabStop = true;
            this.IDSort.Text = "ID";
            this.IDSort.UseVisualStyleBackColor = true;

            // NameSort
            this.NameSort.AutoSize = true;
            this.NameSort.Dock = DockStyle.Fill;
            this.NameSort.Location = new Point(753, 3);
            this.NameSort.Name = "NameSort";
            this.NameSort.Size = new Size(119, 51);
            this.NameSort.TabIndex = 7;
            this.NameSort.TabStop = true;
            this.NameSort.Text = "Name";
            this.NameSort.UseVisualStyleBackColor = true;

            // CustomerSort
            this.CustomerSort.AutoSize = true;
            this.CustomerSort.Dock = DockStyle.Fill;
            this.CustomerSort.Location = new Point(878, 3);
            this.CustomerSort.Name = "CustomerSort";
            this.CustomerSort.Size = new Size(119, 51);
            this.CustomerSort.TabIndex = 8;
            this.CustomerSort.TabStop = true;
            this.CustomerSort.Text = "Customer";
            this.CustomerSort.UseVisualStyleBackColor = true;

            // AmountSort
            this.AmountSort.AutoSize = true;
            this.AmountSort.Dock = DockStyle.Fill;
            this.AmountSort.Location = new Point(1003, 3);
            this.AmountSort.Name = "AmountSort";
            this.AmountSort.Size = new Size(128, 51);
            this.AmountSort.TabIndex = 9;
            this.AmountSort.TabStop = true;
            this.AmountSort.Text = "Amount";
            this.AmountSort.UseVisualStyleBackColor = true;

            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.ResumeLayout(false);
        }

        private Label Title;
        private Button AddOrderButton;
        private Button DeleteOrderButton;
        private Button ChangeOrderButton;
        private Button SortButton;
        private Button SearchOrderButton;
        private DataGridView OrderList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton IDSort;
        private RadioButton NameSort;
        private RadioButton CustomerSort;
        private RadioButton AmountSort;
    }
}