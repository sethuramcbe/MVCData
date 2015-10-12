using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMVP
{
  using MyMVP.Presenter;

  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var model = new UserModel();
      var view = new Form1();
      var presenter = new Userpresenter(view, model);
      Application.Run(view);
    }
  }
}
