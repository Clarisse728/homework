using System;
using System.Drawing;
using System.Windows.Forms;

namespace assignment6
{
    partial class MsgForm : Form
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
            this.AmountText = new TextBox();
            this.OrderAmount = new Label();
            this.CustomerText = new TextBox();
            this.OrderCustomer = new Label();
            this.NameText = new TextBox();
            this.OrderName = new Label();
            this.IDText = new TextBox();
            this.OrderID = new Label();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.OKButton = new Button();
            this.Cancel = new Button();

            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // AmountText
            this.AmountText.Dock = DockStyle.Fill;
            this.AmountText.Location = new Point(143, 263);
            this.AmountText.Multiline = true;
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new Size(654, 62);
            this.AmountText.TabIndex = 7;

            // OrderAmount
            this.OrderAmount.AutoSize = true;
            this.OrderAmount.Dock = DockStyle.Fill;
            this.OrderAmount.FlatStyle = FlatStyle.Flat;
            this.OrderAmount.Location = new Point(3, 260);
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.Size = new Size(134, 68);
            this.OrderAmount.TabIndex = 3;
            this.OrderAmount.Text = "OrderAmount";
            this.OrderAmount.TextAlign = ContentAlignment.MiddleCenter;

            // CustomerText
            this.CustomerText.Dock = DockStyle.Fill;
            this.CustomerText.Location = new Point(143, 170);
            this.CustomerText.Multiline = true;
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.Size = new Size(654, 87);
            this.CustomerText.TabIndex = 6;

            // OrderCustomer
            this.OrderCustomer.AutoSize = true;
            this.OrderCustomer.Dock = DockStyle.Fill;
            this.OrderCustomer.FlatStyle = FlatStyle.Flat;
            this.OrderCustomer.Location = new Point(3, 167);
            this.OrderCustomer.Name = "OrderCustomer";
            this.OrderCustomer.Size = new Size(134, 93);
            this.OrderCustomer.TabIndex = 2;
            this.OrderCustomer.Text = "OrderCustomer";
            this.OrderCustomer.TextAlign = ContentAlignment.MiddleCenter;

            // NameText
            this.NameText.Dock = DockStyle.Fill;
            this.NameText.Location = new Point(143, 83);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new Size(654, 81);
            this.NameText.TabIndex = 5;

            // OrderName
            this.OrderName.AutoSize = true;
            this.OrderName.Dock = DockStyle.Fill;
            this.OrderName.FlatStyle = FlatStyle.Flat;
            this.OrderName.Location = new Point(3, 80);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new Size(134, 87);
            this.OrderName.TabIndex = 1;
            this.OrderName.Text = "OrderName";
            this.OrderName.TextAlign = ContentAlignment.MiddleCenter;

            // IDText
            this.IDText.Dock = DockStyle.Fill;
            this.IDText.Location = new Point(143, 3);
            this.IDText.Multiline = true;
            this.IDText.Name = "IDText";
            this.IDText.Size = new Size(654, 74);
            this.IDText.TabIndex = 4;

            // OrderID
            this.OrderID.AutoSize = true;
            this.OrderID.Dock = DockStyle.Fill;
            this.OrderID.FlatStyle = FlatStyle.Flat;
            this.OrderID.Location = new Point(3, 0);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new Size(134, 80);
            this.OrderID.TabIndex = 0;
            this.OrderID.Text = "OrderID";
            this.OrderID.TextAlign = ContentAlignment.MiddleCenter;

            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.5F));
            this.tableLayoutPanel1.Controls.Add(this.OrderID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrderCustomer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AmountText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OrderAmount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CustomerText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IDText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameText, 1, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Top;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.66355F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.33645F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new Size(800, 328);
            this.tableLayoutPanel1.TabIndex = 10;

            // flowLayoutPanel1
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.OKButton);
            this.flowLayoutPanel1.Controls.Add(this.Cancel);
            this.flowLayoutPanel1.Dock = DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new Point(0, 404);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(800, 46);
            this.flowLayoutPanel1.TabIndex = 11;

            // OKButton
            this.OKButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.OKButton.AutoSize = true;
            this.OKButton.Location = new Point(3, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new Size(394, 40);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new EventHandler(this.OKButton_Click);

            // Cancel
            this.Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new Point(403, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new Size(394, 40);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new EventHandler(this.Cancel_Click);

            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private TextBox AmountText;
        private Label OrderAmount;
        private TextBox CustomerText;
        private Label OrderCustomer;
        private TextBox NameText;
        private Label OrderName;
        private TextBox IDText;
        private Label OrderID;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button OKButton;
        private Button Cancel;
    }
}