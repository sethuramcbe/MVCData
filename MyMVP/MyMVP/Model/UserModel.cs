namespace MyMVP
{
  using System;

  /// <summary>
  /// The user model.
  /// </summary>
  public class UserModel : IUserModel
  {

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

  }
}