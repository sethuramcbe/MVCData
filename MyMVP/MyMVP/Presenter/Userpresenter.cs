using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVP.Presenter
{
  public class Userpresenter
  {
    /// <summary>
    /// The m_view.
    /// </summary>
    private IUserView m_view;

    /// <summary>
    /// The m_model.
    /// </summary>
    private IUserModel m_model;

    /// <summary>
    /// Initializes a new instance of the <see cref="Userpresenter"/> class.
    /// </summary>
    /// <param name="view">
    /// The view.
    /// </param>
    /// <param name="model">
    /// The model.
    /// </param>
    public Userpresenter(IUserView view,IUserModel model)
    {
      this.m_view = view;
      this.m_model = model;
      
    }

    /// <summary>
    /// The set name.
    /// </summary>
    /// <param name="data">
    /// The data.
    /// </param>
    public void SetName(string data)
    {
      this.m_model.Name = data;
    }

    /// <summary>
    /// The get name.
    /// </summary>
    /// <returns>
    /// The <see cref="string"/>.
    /// </returns>
    internal string GetName()
    {
      return this.m_model.Name;
    }
  }
}
