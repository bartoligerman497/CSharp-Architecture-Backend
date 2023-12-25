using CameraReview.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReview.Review
{
    public class ReviewImpl : IReview
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public IProduct Product { get; set; }

        public string GetContent()
        {
            return $"Title: {this.Title}\n" +
                $"Content: {Content}\n" +
                $"Author: {Author}" +
                $"Product: {Product}" ;
        }
    }
}
