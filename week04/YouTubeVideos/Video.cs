using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length; // Length in seconds
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        public string GetTitle() => _title;
        public string GetAuthor() => _author;
        public int GetLength() => _length;
    }
}