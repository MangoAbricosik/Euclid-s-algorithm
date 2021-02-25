using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euclid
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Start();
    }
    public void Start()
    {
      int firstV = Convert.ToInt32(textBox1.Text), twoV = Convert.ToInt32(textBox2.Text);

      NOD(firstV, twoV);
    }
    public void NOD(int firstV, int twoV)
    {
      if (firstV > twoV)
      {
        while (true)
        {
          if (firstV == twoV)
          {
            textBox3.Text = (firstV).ToString();
            return;
          }
          firstV -= twoV;
          NOD(firstV, twoV);
          return;
        }

      }
      else
      {
        while (true)
        {
          if (twoV == firstV)
          {
            textBox3.Text = (twoV).ToString();
            return;
          }
          twoV -= firstV;
          NOD(firstV, twoV);
          return;
        }
      }
    }
  }
}
