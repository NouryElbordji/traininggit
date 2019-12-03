namespace GitTraining
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
      this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
      this.buttonPlus = new EBP.Framework.Windows.Controls.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
      this.SuspendLayout();
      // 
      // dateEdit1
      // 
      this.dateEdit1.Location = new System.Drawing.Point(170, 145);
      this.dateEdit1.Name = "dateEdit1";
      // 
      // 
      // 
      this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      // 
      // 
      // 
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateEdit1.Size = new System.Drawing.Size(417, 22);
      this.dateEdit1.TabIndex = 0;
      // 
      // buttonPlus
      // 
      this.buttonPlus.Location = new System.Drawing.Point(179, 189);
      this.buttonPlus.Name = "buttonPlus";
      this.buttonPlus.Size = new System.Drawing.Size(35, 23);
      this.buttonPlus.TabIndex = 1;
      this.buttonPlus.Text = "+";
      this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonPlus);
      this.Controls.Add(this.dateEdit1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.DateEdit dateEdit1;
    private EBP.Framework.Windows.Controls.Button buttonPlus;
  }
}

