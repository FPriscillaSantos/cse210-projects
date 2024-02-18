class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length) {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string name, string text) {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int GetNumComments() {
        return _comments.Count;
    }

    public void DisplayComments() {
        foreach (var comment in _comments) {
            comment.DisplayComment();
        }
    }
}