using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTraining
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      this.dateEdit1.EditValue = DateTime.Now.ToString();
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
      this.dateEdit1.DateTime = this.dateEdit1.DateTime.AddDays(1);
    }
  }
}
