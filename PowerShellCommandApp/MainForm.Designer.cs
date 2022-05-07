
namespace PowerShellCommandApp
{
    partial class MainForm
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
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.rtbCommandResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.Location = new System.Drawing.Point(13, 13);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(128, 23);
            this.btnExecuteCommand.TabIndex = 0;
            this.btnExecuteCommand.Text = "Execute Command";
            this.btnExecuteCommand.UseVisualStyleBackColor = true;
            this.btnExecuteCommand.Click += new System.EventHandler(this.btnExecuteCommand_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommand.Location = new System.Drawing.Point(147, 15);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(641, 20);
            this.tbCommand.TabIndex = 1;
            // 
            // rtbCommandResult
            // 
            this.rtbCommandResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommandResult.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rtbCommandResult.ForeColor = System.Drawing.Color.White;
            this.rtbCommandResult.Location = new System.Drawing.Point(13, 43);
            this.rtbCommandResult.Name = "rtbCommandResult";
            this.rtbCommandResult.ReadOnly = true;
            this.rtbCommandResult.Size = new System.Drawing.Size(775, 395);
            this.rtbCommandResult.TabIndex = 2;
            this.rtbCommandResult.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCommandResult);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.btnExecuteCommand);
            this.Name = "MainForm";
            this.Text = "PowerShellCommandApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.RichTextBox rtbCommandResult;
    }
}

