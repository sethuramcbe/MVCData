using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMVP
{
  using System.Diagnostics.CodeAnalysis;

  using MyMVP.Presenter;

  public partial class Form1 : Form,IUserView
  {

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Username = textBox1.Text;

    }


    private void Form1_Load(object sender, EventArgs e)
    {
     
    }

    public event Action selected;

    public string Username { get; set; }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox1.Text = this.Username;
     
    }

    private void buttonclick(object sender, EventArgs e)
    {
      if (this.selected != null)
      {
        this.selected();
      }
    }

    public void SetData(string data)
    {
      textBox1.Text = data;
    }

    public string GetData()
    {
      return textBox1.Text;
    }
  }
}
