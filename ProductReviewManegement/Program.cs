namespace ProductReviewManegement
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserId= 1,Rating =5,Review="good",isLike=true},
                new ProductReview(){ProductID=1,UserId= 14,Rating =3,Review="good",isLike=true},
                new ProductReview(){ProductID=3,UserId= 10,Rating =2,Review="good",isLike=true},
                new ProductReview(){ProductID=4,UserId= 7,Rating =1,Review="nice",isLike=true},
                new ProductReview(){ProductID=9,UserId= 3,Rating =5,Review="bad",isLike=false},
                new ProductReview(){ProductID=2,UserId= 16,Rating =4,Review="good",isLike=false},
                new ProductReview(){ProductID=7,UserId= 9,Rating =4,Review="worst",isLike=true},
                new ProductReview(){ProductID=4,UserId= 8,Rating =1,Review="good",isLike=true},
                new ProductReview(){ProductID=9,UserId= 5,Rating =4,Review="good",isLike=false},
                new ProductReview(){ProductID=2,UserId= 45,Rating =5,Review="good",isLike=true},
                new ProductReview(){ProductID=9,UserId= 10,Rating =5,Review="good",isLike=true}
            };
            ProductMangement product = new ProductMangement();
            product.AddProductList(productReviewList);
            product.RetriveTopRecords();

        }
    }
}
