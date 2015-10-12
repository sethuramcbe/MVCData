namespace MyMVP
{
  using MyMVP.Presenter;

  public interface  IUserView
  {
    // Userpresenter Presenter { get; set; }

    void SetData(string data);

    string GetData();

     string Username { get; set; }
  }
}