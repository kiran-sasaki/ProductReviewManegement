using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManegement
{
    public class ProductMangement
    {
        List<ProductReview> productReviewList = new List<ProductReview>();

        public void AddProductList(List<ProductReview> list)
        {
            this.productReviewList = list;
        }
        public void RetriveTopRecords()
        {
            var result = this.productReviewList.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        public void Display(List<ProductReview> productReviews)
        {
            foreach (var productReview in productReviews)
            {
                Console.WriteLine(productReview.ProductID + " " + productReview.UserId + " " + productReview.Review + " " + productReview.Rating + " " + productReview.isLike);
            }
        }
    }
}
