
namespace Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_quit = new System.Windows.Forms.Label();
            this.button_minimize = new System.Windows.Forms.Label();
            this.pb_white = new System.Windows.Forms.PictureBox();
            this.pb_black = new System.Windows.Forms.PictureBox();
            this.label_number = new System.Windows.Forms.Label();
            this.numberContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_c = new System.Windows.Forms.Label();
            this.button_ce = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Label();
            this.button_divide = new System.Windows.Forms.Label();
            this.button_multiply = new System.Windows.Forms.Label();
            this.button_subtract = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Label();
            this.button_equals = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Label();
            this.button_comma = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Label();
            this.button_2 = new System.Windows.Forms.Label();
            this.button_3 = new System.Windows.Forms.Label();
            this.button_4 = new System.Windows.Forms.Label();
            this.button_5 = new System.Windows.Forms.Label();
            this.button_6 = new System.Windows.Forms.Label();
            this.button_7 = new System.Windows.Forms.Label();
            this.button_8 = new System.Windows.Forms.Label();
            this.button_9 = new System.Windows.Forms.Label();
            this.label_comma = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_black)).BeginInit();
            this.numberContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.Brown;
            this.button_quit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_quit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_quit.Location = new System.Drawing.Point(474, 0);
            this.button_quit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(93, 79);
            this.button_quit.TabIndex = 2;
            this.button_quit.Tag = "gray2";
            this.button_quit.Text = "X";
            this.button_quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_quit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_quit.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_quit.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button_minimize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_minimize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_minimize.Location = new System.Drawing.Point(381, 0);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(91, 79);
            this.button_minimize.TabIndex = 3;
            this.button_minimize.Tag = "gray2";
            this.button_minimize.Text = "-";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_minimize.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_minimize.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // pb_white
            // 
            this.pb_white.BackColor = System.Drawing.Color.White;
            this.pb_white.Location = new System.Drawing.Point(13, 85);
            this.pb_white.Margin = new System.Windows.Forms.Padding(6);
            this.pb_white.Name = "pb_white";
            this.pb_white.Size = new System.Drawing.Size(542, 260);
            this.pb_white.TabIndex = 4;
            this.pb_white.TabStop = false;
            // 
            // pb_black
            // 
            this.pb_black.Location = new System.Drawing.Point(17, 90);
            this.pb_black.Margin = new System.Windows.Forms.Padding(6);
            this.pb_black.Name = "pb_black";
            this.pb_black.Size = new System.Drawing.Size(535, 252);
            this.pb_black.TabIndex = 5;
            this.pb_black.TabStop = false;
            // 
            // label_number
            // 
            this.label_number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_number.ContextMenuStrip = this.numberContextMenu;
            this.label_number.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_number.Location = new System.Drawing.Point(17, 243);
            this.label_number.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_number.Name = "label_number";
            this.label_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_number.Size = new System.Drawing.Size(535, 98);
            this.label_number.TabIndex = 6;
            this.label_number.Text = "0";
            // 
            // numberContextMenu
            // 
            this.numberContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.numberContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.numberContextMenu.Name = "contextMenuStrip1";
            this.numberContextMenu.Size = new System.Drawing.Size(144, 80);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(143, 38);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuLeftClick);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(143, 38);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuLeftClick);
            // 
            // button_c
            // 
            this.button_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_c.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_c.Location = new System.Drawing.Point(13, 371);
            this.button_c.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(126, 90);
            this.button_c.TabIndex = 8;
            this.button_c.Tag = "gray3";
            this.button_c.Text = "C";
            this.button_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_c.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_c.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_c.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_ce
            // 
            this.button_ce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_ce.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ce.Location = new System.Drawing.Point(150, 371);
            this.button_ce.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(126, 90);
            this.button_ce.TabIndex = 9;
            this.button_ce.Tag = "gray3";
            this.button_ce.Text = "CE";
            this.button_ce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_ce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_ce.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_ce.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(288, 371);
            this.button_delete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(126, 90);
            this.button_delete.TabIndex = 10;
            this.button_delete.Tag = "gray3";
            this.button_delete.Text = "⌫";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_delete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_delete.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_delete.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_divide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_divide.Location = new System.Drawing.Point(425, 371);
            this.button_divide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(126, 90);
            this.button_divide.TabIndex = 11;
            this.button_divide.Tag = "gray3";
            this.button_divide.Text = "÷";
            this.button_divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_divide.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_divide.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_multiply.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_multiply.Location = new System.Drawing.Point(425, 474);
            this.button_multiply.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(126, 90);
            this.button_multiply.TabIndex = 12;
            this.button_multiply.Tag = "gray3";
            this.button_multiply.Text = "×";
            this.button_multiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_multiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_multiply.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_multiply.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_subtract
            // 
            this.button_subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_subtract.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_subtract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_subtract.Location = new System.Drawing.Point(425, 578);
            this.button_subtract.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(126, 90);
            this.button_subtract.TabIndex = 13;
            this.button_subtract.Tag = "gray3";
            this.button_subtract.Text = "−";
            this.button_subtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_subtract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_subtract.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_subtract.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(425, 681);
            this.button_add.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(126, 90);
            this.button_add.TabIndex = 14;
            this.button_add.Tag = "gray3";
            this.button_add.Text = "+";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_add.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_add.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(47)))));
            this.button_equals.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_equals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_equals.Location = new System.Drawing.Point(425, 783);
            this.button_equals.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(126, 90);
            this.button_equals.TabIndex = 15;
            this.button_equals.Tag = "gray1";
            this.button_equals.Text = "=";
            this.button_equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_equals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_equals.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_equals.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_0.Location = new System.Drawing.Point(13, 783);
            this.button_0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(264, 90);
            this.button_0.TabIndex = 16;
            this.button_0.Tag = "gray4";
            this.button_0.Text = "0";
            this.button_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_0.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_0.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_comma
            // 
            this.button_comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_comma.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_comma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_comma.Location = new System.Drawing.Point(288, 783);
            this.button_comma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(126, 90);
            this.button_comma.TabIndex = 17;
            this.button_comma.Tag = "gray4";
            this.button_comma.Text = ",";
            this.button_comma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_comma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_comma.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_comma.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_1.Location = new System.Drawing.Point(13, 681);
            this.button_1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(126, 90);
            this.button_1.TabIndex = 18;
            this.button_1.Tag = "gray4";
            this.button_1.Text = "1";
            this.button_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_1.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_1.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_2.Location = new System.Drawing.Point(150, 681);
            this.button_2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(126, 90);
            this.button_2.TabIndex = 19;
            this.button_2.Tag = "gray4";
            this.button_2.Text = "2";
            this.button_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_2.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_2.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_3.Location = new System.Drawing.Point(288, 681);
            this.button_3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(126, 90);
            this.button_3.TabIndex = 20;
            this.button_3.Tag = "gray4";
            this.button_3.Text = "3";
            this.button_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_3.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_3.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_4.Location = new System.Drawing.Point(13, 578);
            this.button_4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(126, 90);
            this.button_4.TabIndex = 21;
            this.button_4.Tag = "gray4";
            this.button_4.Text = "4";
            this.button_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_4.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_4.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_5.Location = new System.Drawing.Point(150, 576);
            this.button_5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(126, 90);
            this.button_5.TabIndex = 22;
            this.button_5.Tag = "gray4";
            this.button_5.Text = "5";
            this.button_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_5.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_5.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_6.Location = new System.Drawing.Point(288, 576);
            this.button_6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(126, 90);
            this.button_6.TabIndex = 23;
            this.button_6.Tag = "gray4";
            this.button_6.Text = "6";
            this.button_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_6.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_6.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_7.Location = new System.Drawing.Point(13, 474);
            this.button_7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(126, 90);
            this.button_7.TabIndex = 24;
            this.button_7.Tag = "gray4";
            this.button_7.Text = "7";
            this.button_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_7.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_7.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_8.Location = new System.Drawing.Point(150, 474);
            this.button_8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(126, 90);
            this.button_8.TabIndex = 25;
            this.button_8.Tag = "gray4";
            this.button_8.Text = "8";
            this.button_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_8.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_8.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_9.Location = new System.Drawing.Point(288, 474);
            this.button_9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(126, 90);
            this.button_9.TabIndex = 26;
            this.button_9.Tag = "gray4";
            this.button_9.Text = "9";
            this.button_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickEvent);
            this.button_9.MouseEnter += new System.EventHandler(this.MouseOver);
            this.button_9.MouseLeave += new System.EventHandler(this.MouseExit);
            // 
            // label_comma
            // 
            this.label_comma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_comma.ContextMenuStrip = this.numberContextMenu;
            this.label_comma.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_comma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_comma.Location = new System.Drawing.Point(17, 243);
            this.label_comma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_comma.Name = "label_comma";
            this.label_comma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_comma.Size = new System.Drawing.Size(535, 98);
            this.label_comma.TabIndex = 27;
            this.label_comma.Text = "0";
            this.label_comma.Visible = false;
            // 
            // label_input
            // 
            this.label_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.label_input.Location = new System.Drawing.Point(22, 90);
            this.label_input.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_input.Name = "label_input";
            this.label_input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_input.Size = new System.Drawing.Size(522, 166);
            this.label_input.TabIndex = 28;
            this.label_input.Text = "8 + 5 + 6 * 5 + 8 -12 + 44 - 19 * 77 / 4 +";
            this.label_input.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(566, 890);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label_comma);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.pb_black);
            this.Controls.Add(this.pb_white);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_black)).EndInit();
            this.numberContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label button_quit;
        private System.Windows.Forms.Label button_minimize;
        private System.Windows.Forms.PictureBox pb_white;
        private System.Windows.Forms.PictureBox pb_black;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label button_c;
        private System.Windows.Forms.Label button_ce;
        private System.Windows.Forms.Label button_delete;
        private System.Windows.Forms.Label button_divide;
        private System.Windows.Forms.Label button_multiply;
        private System.Windows.Forms.Label button_subtract;
        private System.Windows.Forms.Label button_add;
        private System.Windows.Forms.Label button_equals;
        private System.Windows.Forms.Label button_0;
        private System.Windows.Forms.Label button_comma;
        private System.Windows.Forms.Label button_1;
        private System.Windows.Forms.Label button_2;
        private System.Windows.Forms.Label button_3;
        private System.Windows.Forms.Label button_4;
        private System.Windows.Forms.Label button_5;
        private System.Windows.Forms.Label button_6;
        private System.Windows.Forms.Label button_7;
        private System.Windows.Forms.Label button_8;
        private System.Windows.Forms.Label button_9;
        private System.Windows.Forms.Label label_comma;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.ContextMenuStrip numberContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

