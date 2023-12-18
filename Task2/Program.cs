var post = new Post();
post.Text = " Text = " + "I just updated my post";
post.Likes = "Likes : " + 10;
post.Comments = "Comments : " + 5;
System.Console.WriteLine(post.SetPosts());
System.Console.WriteLine(post.AddLike());
System.Console.WriteLine(post.AddComments());


class Post
{
  public string Text;
  public string Likes;
  public string Comments;

  public string SetPosts()
  {
    return $"{Text}";
  }
  public string AddLike()
  {
    return $" {Likes}";
  }
  public string AddComments()
  {
    return $" {Comments}";
  }
  public string GetInfo()
  {
   return $"{Text} {Likes} {Comments}";
  }
}