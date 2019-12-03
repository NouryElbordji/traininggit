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
      timer1.Interval = 1000;
      timer1.Start();
      button1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      button1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        timer1.Stop();
      this.Close();
    }
  }
}
