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
        public void RetriveAllRecords()
        {
            var result = this.productReviewList.Where(x => x.Rating == 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            Display(result.ToList());
        }
        public void RetriveAllRecordsGroupby()
        {
            var result = this.productReviewList.GroupBy(x => x.ProductID);
            foreach (var data in result)
            {
                Console.WriteLine(data.Count());
                Display(data.ToList());
            }
        }
        public void RetriveAllRecordsFileds()
        {
            var result = this.productReviewList.Select(x => new { x.ProductID, x.Rating });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductID + " " + data.Rating);
            }
        }
        public void Display(List<ProductReview> productReviews)
        {
            foreach (var productReview in productReviews)
            {
                Console.WriteLine(productReview.ProductID +" "+ productReview.UserId +" "+productReview.Review + " " + productReview.Rating + " " + productReview.isLike);
            }
        }
    }
}
