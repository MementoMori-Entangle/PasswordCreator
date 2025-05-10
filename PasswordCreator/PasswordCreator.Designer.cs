namespace PasswordCreator
{
    partial class PasswordCreator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CRandomButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NumberCheckBox = new System.Windows.Forms.CheckBox();
            this.AlphabetUPCheckBox = new System.Windows.Forms.CheckBox();
            this.AlphabetLOWCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetUPTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetLOWTextBox = new System.Windows.Forms.TextBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this.NumberDataTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetUPDataTextBox = new System.Windows.Forms.TextBox();
            this.AlphabetLOWDataTextBox = new System.Windows.Forms.TextBox();
            this.SymbolDataTextBox = new System.Windows.Forms.TextBox();
            this.InitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordLabel.Location = new System.Drawing.Point(8, 136);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 19);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // CRandomButton
            // 
            this.CRandomButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CRandomButton.Location = new System.Drawing.Point(12, 11);
            this.CRandomButton.Name = "CRandomButton";
            this.CRandomButton.Size = new System.Drawing.Size(105, 34);
            this.CRandomButton.TabIndex = 1;
            this.CRandomButton.Text = "C Random";
            this.CRandomButton.UseVisualStyleBackColor = true;
            this.CRandomButton.Click += new System.EventHandler(this.CRandomButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClearButton.Location = new System.Drawing.Point(123, 11);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 34);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NumberCheckBox
            // 
            this.NumberCheckBox.AutoSize = true;
            this.NumberCheckBox.Location = new System.Drawing.Point(12, 51);
            this.NumberCheckBox.Name = "NumberCheckBox";
            this.NumberCheckBox.Size = new System.Drawing.Size(63, 16);
            this.NumberCheckBox.TabIndex = 4;
            this.NumberCheckBox.Text = "Number";
            this.NumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlphabetUPCheckBox
            // 
            this.AlphabetUPCheckBox.AutoSize = true;
            this.AlphabetUPCheckBox.Location = new System.Drawing.Point(12, 73);
            this.AlphabetUPCheckBox.Name = "AlphabetUPCheckBox";
            this.AlphabetUPCheckBox.Size = new System.Drawing.Size(90, 16);
            this.AlphabetUPCheckBox.TabIndex = 7;
            this.AlphabetUPCheckBox.Text = "Alphabet-UP";
            this.AlphabetUPCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlphabetLOWCheckBox
            // 
            this.AlphabetLOWCheckBox.AutoSize = true;
            this.AlphabetLOWCheckBox.Location = new System.Drawing.Point(12, 95);
            this.AlphabetLOWCheckBox.Name = "AlphabetLOWCheckBox";
            this.AlphabetLOWCheckBox.Size = new System.Drawing.Size(98, 16);
            this.AlphabetLOWCheckBox.TabIndex = 10;
            this.AlphabetLOWCheckBox.Text = "Alphabet-LOW";
            this.AlphabetLOWCheckBox.UseVisualStyleBackColor = true;
            // 
            // SymbolCheckBox
            // 
            this.SymbolCheckBox.AutoSize = true;
            this.SymbolCheckBox.Location = new System.Drawing.Point(12, 117);
            this.SymbolCheckBox.Name = "SymbolCheckBox";
            this.SymbolCheckBox.Size = new System.Drawing.Size(61, 16);
            this.SymbolCheckBox.TabIndex = 13;
            this.SymbolCheckBox.Text = "Symbol";
            this.SymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordRichTextBox
            // 
            this.PasswordRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordRichTextBox.Location = new System.Drawing.Point(12, 158);
            this.PasswordRichTextBox.Name = "PasswordRichTextBox";
            this.PasswordRichTextBox.Size = new System.Drawing.Size(255, 51);
            this.PasswordRichTextBox.TabIndex = 16;
            this.PasswordRichTextBox.Text = "";
            this.PasswordRichTextBox.WordWrap = false;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(116, 48);
            this.NumberTextBox.MaxLength = 2;
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(19, 19);
            this.NumberTextBox.TabIndex = 5;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // AlphabetUPTextBox
            // 
            this.AlphabetUPTextBox.Location = new System.Drawing.Point(116, 70);
            this.AlphabetUPTextBox.MaxLength = 2;
            this.AlphabetUPTextBox.Name = "AlphabetUPTextBox";
            this.AlphabetUPTextBox.Size = new System.Drawing.Size(19, 19);
            this.AlphabetUPTextBox.TabIndex = 8;
            this.AlphabetUPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AlphabetUPTextBox.TextChanged += new System.EventHandler(this.AlphabetUPTextBox_TextChanged);
            // 
            // AlphabetLOWTextBox
            // 
            this.AlphabetLOWTextBox.Location = new System.Drawing.Point(116, 92);
            this.AlphabetLOWTextBox.MaxLength = 2;
            this.AlphabetLOWTextBox.Name = "AlphabetLOWTextBox";
            this.AlphabetLOWTextBox.Size = new System.Drawing.Size(19, 19);
            this.AlphabetLOWTextBox.TabIndex = 11;
            this.AlphabetLOWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AlphabetLOWTextBox.TextChanged += new System.EventHandler(this.AlphabetLOWTextBox_TextChanged);
            // 
            // SymbolTextBox
            // 
            this.SymbolTextBox.Location = new System.Drawing.Point(116, 114);
            this.SymbolTextBox.MaxLength = 2;
            this.SymbolTextBox.Name = "SymbolTextBox";
            this.SymbolTextBox.Size = new System.Drawing.Size(19, 19);
            this.SymbolTextBox.TabIndex = 14;
            this.SymbolTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SymbolTextBox.TextChanged += new System.EventHandler(this.SymbolTextBox_TextChanged);
            // 
            // NumberDataTextBox
            // 
            this.NumberDataTextBox.Location = new System.Drawing.Point(141, 48);
            this.NumberDataTextBox.MaxLength = 10;
            this.NumberDataTextBox.Name = "NumberDataTextBox";
            this.NumberDataTextBox.Size = new System.Drawing.Size(126, 19);
            this.NumberDataTextBox.TabIndex = 6;
            this.NumberDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberDataTextBox_KeyPress);
            // 
            // AlphabetUPDataTextBox
            // 
            this.AlphabetUPDataTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AlphabetUPDataTextBox.Location = new System.Drawing.Point(141, 70);
            this.AlphabetUPDataTextBox.MaxLength = 26;
            this.AlphabetUPDataTextBox.Name = "AlphabetUPDataTextBox";
            this.AlphabetUPDataTextBox.Size = new System.Drawing.Size(126, 19);
            this.AlphabetUPDataTextBox.TabIndex = 9;
            this.AlphabetUPDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetUPDataTextBox_KeyPress);
            // 
            // AlphabetLOWDataTextBox
            // 
            this.AlphabetLOWDataTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AlphabetLOWDataTextBox.Location = new System.Drawing.Point(141, 92);
            this.AlphabetLOWDataTextBox.MaxLength = 26;
            this.AlphabetLOWDataTextBox.Name = "AlphabetLOWDataTextBox";
            this.AlphabetLOWDataTextBox.Size = new System.Drawing.Size(126, 19);
            this.AlphabetLOWDataTextBox.TabIndex = 12;
            this.AlphabetLOWDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetLOWDataTextBox_KeyPress);
            // 
            // SymbolDataTextBox
            // 
            this.SymbolDataTextBox.Location = new System.Drawing.Point(141, 114);
            this.SymbolDataTextBox.MaxLength = 33;
            this.SymbolDataTextBox.Name = "SymbolDataTextBox";
            this.SymbolDataTextBox.Size = new System.Drawing.Size(126, 19);
            this.SymbolDataTextBox.TabIndex = 15;
            this.SymbolDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolDataTextBox_KeyPress);
            // 
            // InitButton
            // 
            this.InitButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InitButton.Location = new System.Drawing.Point(189, 11);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(47, 34);
            this.InitButton.TabIndex = 3;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // PasswordCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 221);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.SymbolDataTextBox);
            this.Controls.Add(this.AlphabetLOWDataTextBox);
            this.Controls.Add(this.AlphabetUPDataTextBox);
            this.Controls.Add(this.NumberDataTextBox);
            this.Controls.Add(this.SymbolTextBox);
            this.Controls.Add(this.AlphabetLOWTextBox);
            this.Controls.Add(this.AlphabetUPTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.PasswordRichTextBox);
            this.Controls.Add(this.SymbolCheckBox);
            this.Controls.Add(this.AlphabetLOWCheckBox);
            this.Controls.Add(this.AlphabetUPCheckBox);
            this.Controls.Add(this.NumberCheckBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CRandomButton);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "PasswordCreator";
            this.Text = "PasswordCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button CRandomButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox NumberCheckBox;
        private System.Windows.Forms.CheckBox AlphabetUPCheckBox;
        private System.Windows.Forms.CheckBox AlphabetLOWCheckBox;
        private System.Windows.Forms.CheckBox SymbolCheckBox;
        private System.Windows.Forms.RichTextBox PasswordRichTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox AlphabetUPTextBox;
        private System.Windows.Forms.TextBox AlphabetLOWTextBox;
        private System.Windows.Forms.TextBox SymbolTextBox;
        private System.Windows.Forms.TextBox NumberDataTextBox;
        private System.Windows.Forms.TextBox AlphabetUPDataTextBox;
        private System.Windows.Forms.TextBox AlphabetLOWDataTextBox;
        private System.Windows.Forms.TextBox SymbolDataTextBox;
        private System.Windows.Forms.Button InitButton;
    }
}

